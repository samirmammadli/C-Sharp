using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows;
using Arxivator.Extensions;

namespace Arxivator.Services
{
    class GzipArchiver : IArchiver
    {
        public event CompressionDone CompressionDoneEventHandler;
        public event ThreadsCountChanged ThreadsChanged;
        public event ProgressChanged ProgressValueChanged;
        private static readonly byte[] gzipHeader = new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0 };

        public List<byte[]> ParseBytes(byte[] bytes, int count)
        {
            var list = new List<byte[]>();
            var chunkSize = bytes.Length / count;
            if (chunkSize < 2 || count == 1)
            {
                list.Add(bytes);
                return list;
            }
            var rest = bytes.Length - chunkSize * (count - 1);
            for (int i = 0; i < count - 1; i++)
            {
                var chunk = new byte[chunkSize];
                Buffer.BlockCopy(bytes, chunkSize * i, chunk, 0, chunkSize);
                list.Add(chunk);
            }

            var chunk1 = new byte[rest];
            Buffer.BlockCopy(bytes, chunkSize * (count - 1), chunk1, 0, rest);
            list.Add(chunk1);

            return list;
        }

        public void Compress(string file, int threadsCount)
        {
            var fileBytes = File.ReadAllBytes(file);
            var inputChunks = ParseBytes(fileBytes, threadsCount);
            ThreadsChanged?.Invoke(inputChunks.Count);
            var threads = new List<Task<byte[]>>();
            const string extension = ".gz";
            var start = DateTime.Now.Ticks;
            for (var i = 0; i < inputChunks.Count; i++)
            {
                var iter = i;
                threads.Add(new Task<byte[]>(() =>
                {
                    try
                    {
                        using (var mStream = new MemoryStream())
                        {
                            using (var gZipStream = new GZipStream(mStream, CompressionMode.Compress))
                            {
                                var lenght = inputChunks[iter].Length / 100;
                                if (lenght < 1)
                                {
                                    gZipStream.Write(inputChunks[iter], 0, inputChunks[iter].Length);
                                    ProgressValueChanged?.Invoke(iter, 100);
                                }
                                else
                                {
                                    for (var j = 0; j < 100; j++)
                                    {
                                        gZipStream.Write(inputChunks[iter], j * lenght, lenght);
                                        ProgressValueChanged?.Invoke(iter);
                                    }
                                    gZipStream.Write(inputChunks[iter], lenght * 100, inputChunks[iter].Length - lenght * 100);
                                }
                            }
                            return mStream.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }));
            }
            threads.ForEach(x => x.Start());
            WhenCompressThreadsDone(file + extension, threads, start);
        }

        public void WhenCompressThreadsDone(string filename, List<Task<byte[]>> threads, long ticks)
        {

                Task.WhenAll(threads).ContinueWith(param =>
                {
                    try
                    {
                        var list = new byte[threads.Sum(x => x.Result.Length)];
                        var offset = 0;
                        threads.ForEach(x => { Buffer.BlockCopy(x.Result, 0, list, offset, x.Result.Length); offset += x.Result.Length; });
                        File.WriteAllBytes(filename, list);
                        GC.Collect();
                        CompressionDoneEventHandler?.Invoke(true, $"Success!\nElapsed time - {ElapsedTimeInSeconds(ticks, DateTime.Now.Ticks)} seconds.");
                    }
                    catch (Exception ex)
                    {
                        CompressionDoneEventHandler?.Invoke(true, ex.Message);
                    }
                }); 
        }

        private string ElapsedTimeInSeconds(long start, long end)
        {
            return ((double)(end - start) / 10000000).ToString(("0.###"));
        }

        public void Decompress(string fileName)
        {
            var start = DateTime.Now.Ticks;
            var file = File.ReadAllBytes(fileName);
            fileName = fileName.Remove(fileName.Length - 3, 3);
            var chunks = file.SearchBytePattern(gzipHeader);
            ThreadsChanged?.Invoke(chunks.Count);
            if (chunks.Count == 0 || chunks[0] != 0)
            {
                CompressionDoneEventHandler?.Invoke(true, "File is not an archive, or damaged!");
                return;
            }
            var threads = new List<Task<byte[]>>();
            var offset = 0;
            try
            {
                if (chunks.Count == 1)
                {
                    DecompressThreadsAdd(threads, 0, file.Length, file);
                }
                else
                {
                    for (int i = 1; i < chunks.Count; i++)
                    {
                        var iter = i;
                        offset = chunks[iter - 1];
                        DecompressThreadsAdd(threads, offset, chunks[iter] - offset, file);
                    }
                    DecompressThreadsAdd(threads, chunks.LastOrDefault(), file.Length - chunks.LastOrDefault() - 1, file);
                }
                threads.ForEach(x => x.Start());
                WhenCompressThreadsDone(fileName, threads, start);
            }
            catch (Exception ex)
            {
                CompressionDoneEventHandler?.Invoke(true, ex.Message);
            }
        }

        private void DecompressThreadsAdd(List<Task<byte[]>> threads, int offset, int count, byte[] file)
        {
            int threadCnt = threads.Count;
            threads.Add(new Task<byte[]>(() =>
            {
                using (var source = new MemoryStream(file, offset, count))
                {
                    using (var target = new MemoryStream())
                    {
                        using (var gZipStream = new GZipStream(source, CompressionMode.Decompress))
                        {
                            var readed = 1;
                            var bufferSize = count / 100 < 0 ? 1 : count / 100;
                            var buffer = new byte[bufferSize];
                            while (readed  != 0)
                            {
                                readed = gZipStream.Read(buffer, 0, bufferSize);
                                target.Write(buffer, 0, readed);
                                ProgressValueChanged?.Invoke(threadCnt);
                            }
                        }
                        return target.ToArray();
                    }
                }
            }));
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Arxivator
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<int> threadsCount;
        public ObservableCollection<int> ThreadsCount
        {
            get { return threadsCount; }
            set { Set(ref threadsCount, value); }
        }

        private int selectedCount;
        public int SelectedCount
        {
            get { return selectedCount; }
            set { Set(ref selectedCount, value); }
        }

        public IArchiver Archiver { get; set; }

        private bool isCompleted;
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { Set(ref isCompleted, value); }
        }

        public MainViewModel(IArchiver archiver)
        {
            Progress = new ObservableCollection<int>();
            ThreadsCount = new ObservableCollection<int>();
            for (int i = 0; i < 4; i++)
            {
                Progress.Add(0);
                ThreadsCount.Add(i + 1);
            }
            SelectedCount = threadsCount[0];
            IsCompleted = true;
            Archiver = archiver;
            Archiver.CompressionDoneEventHandler += IsCompressiondone;
        }

        private string selectedFile;
        public string SelectedFile
        {
            get => selectedFile;
            set => Set(ref selectedFile, value);
        }

        private ObservableCollection<int> progress;
        public ObservableCollection<int> Progress
        {
            get => progress;
            set => Set(ref progress, value);
        }

        private RelayCommand compressCommand;
        public RelayCommand CompressCommand
        {
            get
            {
                return compressCommand ?? (compressCommand = new RelayCommand(
                    () => { Compress(SelectedFile); IsCompleted = false; }, () => (SelectedFile != null && !CheckExstension() && IsCompleted)
                ));
            }
        }

        private RelayCommand openFile;

        public RelayCommand OpenFile
        {
            get
            {
                return openFile ?? (openFile = new RelayCommand(
                    () => {
                        var dialog = new OpenFileDialog();
                        if (dialog.ShowDialog() == true)
                        {
                            SelectedFile = dialog.FileName;
                        }
                    }, () => isCompleted 
                    ));
            }
        }


        private RelayCommand decompressCommand;
        public RelayCommand DecompressCommand
        {
            get
            {
                return decompressCommand ?? (decompressCommand = new RelayCommand(
                    () => Archiver.Decompress(""), () => (SelectedFile != null && CheckExstension() && IsCompleted)
                ));
            }
        }

        public void Compress(string fileName)
        {
            try
            {
                Archiver.Compress(SelectedFile, selectedCount, new ArchiverParam(Progress));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void IsCompressiondone(bool isDone, string message)
        {
            MessageBox.Show(message);
            IsCompleted = isDone;
        }

        public bool CheckExstension()
        {
            return SelectedFile.EndsWith(".gz");
        }
    }
}

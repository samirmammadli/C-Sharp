using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
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
        public MainViewModel()
        {
            Thread1Progress = 0;

        }

        private string selectedFile;
        public string SelectedFile
        {
            get => selectedFile;
            set => Set(ref selectedFile, value);
        }

        private int thread1Progress;
        public int Thread1Progress
        {
            get => thread1Progress;
            set => Set(ref thread1Progress, value);
        }

        private int thread2Progress;
        public int Thread2Progress
        {
            get => thread2Progress;
            set => Set(ref thread2Progress, value);
        }

        private int thread3Progress;
        public int Thread3Progress
        {
            get => thread3Progress;
            set => Set(ref thread3Progress, value);
        }

        private int thread4Progress;
        public int Thread4Progress
        {
            get => thread4Progress;
            set => Set(ref thread4Progress, value);
        }

        private RelayCommand compressCommand;
        public RelayCommand CompressCommand
        {
            get
            {
                return compressCommand ?? (compressCommand = new RelayCommand(
                    () => Compress(SelectedFile), () => (SelectedFile != null && !CheckExstension())
                ));
            }
        }

        private RelayCommand decompressCommand;
        public RelayCommand DecompressCommand
        {
            get
            {
                return decompressCommand ?? (decompressCommand = new RelayCommand(
                    () => MessageBox.Show(SelectedFile), () => (SelectedFile != null && CheckExstension())
                ));
            }
        }

        public void Compress(string fileName)
        {
            try
            {
                var archiver = new Archiver();
                archiver.Compress(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("File Successfully compressed!");
        }

        public bool CheckExstension()
        {
            return SelectedFile.EndsWith(".gz");
        }
    }
}

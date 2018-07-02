using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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

        private bool isCompleted;

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { Set(ref isCompleted, value); }
        }



        public MainViewModel()
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
                    () => { Compress(SelectedFile); }, () => (SelectedFile != null && !CheckExstension() && IsCompleted)
                ));
            }
        }

        private RelayCommand decompressCommand;
        public RelayCommand DecompressCommand
        {
            get
            {
                return decompressCommand ?? (decompressCommand = new RelayCommand(
                    () => MessageBox.Show(SelectedFile), () => (SelectedFile != null && CheckExstension() && IsCompleted)
                ));
            }
        }

        public void Compress(string fileName)
        {
            try
            {
                var archiver = new Archiver();
                archiver.Compress(SelectedFile, Progress, SelectedCount);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckExstension()
        {
            return SelectedFile.EndsWith(".gz");
        }
    }
}

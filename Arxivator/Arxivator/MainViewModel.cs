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
        private ObservableCollection<int> selectedThreadsCount;

        public ObservableCollection<int> SelectedThreadsCount
        {
            get { return selectedThreadsCount; }
            set { Set(ref selectedThreadsCount, value); }
        }


        public MainViewModel()
        {
            Progress = new ObservableCollection<int>();
            SelectedThreadsCount = new ObservableCollection<int>();
            for (int i = 0; i < 4; i++)
            {
                Progress.Add(0);
                SelectedThreadsCount.Add(i + 1);
            }
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
                archiver.Compress(SelectedFile, Progress);
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

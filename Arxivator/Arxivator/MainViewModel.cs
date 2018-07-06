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
using System.Windows.Controls;
using System.Windows.Threading;

namespace Arxivator
{
    public class ProgressBarValues : ObservableObject
    {
        private string barName;
        public string BarName
        {
            get => barName;
            set => Set(ref barName, value);
        }

        private int barValue;
        public int BarValue
        {
            get => barValue;
            set => Set(ref barValue, value);
        }

        public ProgressBarValues(int number)
        {
            BarName = $"Thread {number + 1}:";
            BarValue = 0;
        }
    }

    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<int> threadsCount;
        public ObservableCollection<int> ThreadsCount
        {
            get => threadsCount;
            set => Set(ref threadsCount, value);
        }

        private int selectedCount;
        public int SelectedCount
        {
            get => selectedCount;
            set => Set(ref selectedCount, value);
        }

        public IArchiver Archiver { get; set; }

        private bool isCompleted;
        public bool IsCompleted
        {
            get => isCompleted;
            set => Set(ref isCompleted, value);
        }

        public MainViewModel(IArchiver archiver)
        {
            ThreadsCount = new ObservableCollection<int>();
            for (var i = 0; i < Environment.ProcessorCount; i++)
            {
                ThreadsCount.Add(i + 1);
            }
            SelectedCount = threadsCount[0];
            IsCompleted = true;
            Archiver = archiver;
            Archiver.CompressionDoneEventHandler += IsCompressiondone;
            CountSelected();
        }

        private string selectedFile;
        public string SelectedFile
        {
            get => selectedFile;
            set => Set(ref selectedFile, value);
        }

        private ObservableCollection<ProgressBarValues> progress;
        public ObservableCollection<ProgressBarValues> Progress
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
                    () => Archiver.Decompress(SelectedFile), () => (SelectedFile != null && CheckExstension() && IsCompleted)
                ));
            }
        }

        private RelayCommand addBarsCommand;
        public RelayCommand AddBarsCommand
        {
            get
            {
                return addBarsCommand ?? (addBarsCommand = new RelayCommand(CountSelected));
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

        private void CountSelected()
        {
            Progress = new ObservableCollection<ProgressBarValues>();
            for (int i = 0; i < selectedCount; i++)
            {
                Progress.Add(new ProgressBarValues(i));
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

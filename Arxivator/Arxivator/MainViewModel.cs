using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arxivator
{
    public class MainViewModel : ViewModelBase
    {
        private string selectedFile;
        public string SelectedFile
        {
            get => selectedFile;
            set => Set(ref selectedFile, value);
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
                archiver.Compress(fileName);
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

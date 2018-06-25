using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

using AppDll;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pluginsapp.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private List<Assembly> assemblies;
        public  List<IPlugin> Plugins { get; set; }
        public IPlugin CurrentPlugin { get; set; }
        public MainViewModel()
        {
            assemblies = new List<Assembly>();
            Plugins = new List<IPlugin>();
            LoadAllPlugins();
            if(Plugins.Count > 0) CurrentPlugin = Plugins[0];
        }
        private void LoadAllPlugins()
        {
            var di = new DirectoryInfo("Plugins");
            var dlls = di.GetFiles();
            foreach (var item in dlls)
            {
                assemblies.Add(Assembly.LoadFile(item.FullName));
            }

            foreach (var item in assemblies[0].GetTypes())
            {
                if (item.GetInterface("IPlugin") != null)
                {
                    IPlugin obj = Activator.CreateInstance(item) as IPlugin;
                    Plugins.Add(obj);
                }
            }
        }

        //TODO
        //private RelayCommand goCommand;
        //public RelayCommand GoCommand
        //{
        //    get
        //    {
        //        return goCommand ?? (goCommand = new RelayCommand(
        //                   () => 
        //               ));
        //    }
        //}
    }
}

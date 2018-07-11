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
        public MainViewModel()
        {
            assemblies = new List<Assembly>();
            LoadAllPlugins();
        }
        private void LoadAllPlugins()
        {
            var di = new DirectoryInfo("Plugins");
            var dlls = di.GetFiles();
            foreach (var item in dlls)
            {
                MessageBox.Show(item.FullName);
                assemblies.Add(Assembly.LoadFile(item.FullName));
            }

            foreach (var item in assemblies[0].GetTypes())
            {
                if (item.GetInterface("IPlugin") != null)
                {
                    IPlugin obj = Activator.CreateInstance(item) as IPlugin;
                    MessageBox.Show(obj.Request("baku"));
                }
            }
        }
    }
}

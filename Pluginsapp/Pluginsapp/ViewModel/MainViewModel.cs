﻿using AppDll;
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

        private string outputText;
        public string OutputText
        {
            get => outputText;
            set => Set(ref outputText, value);
        }

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


            var classes = assemblies.SelectMany(x => x.GetTypes());
            foreach (var item in classes)
            {
                if (item.GetInterface("IPlugin") != null)
                {
                    IPlugin obj = Activator.CreateInstance(item) as IPlugin;
                    Plugins.Add(obj);
                }
            }
        }

         private RelayCommand<string> goCommand;
         public RelayCommand<string> GoCommand
        {
            get
            {
                return goCommand ?? (goCommand = new RelayCommand<string>(
                          param => GetData(param), param => !String.IsNullOrWhiteSpace(param)
                       ));
            }
        }

        async public void GetData(string input)
        {
            OutputText = await Task.Run( () => CurrentPlugin.Request(input));
        }
    }
}

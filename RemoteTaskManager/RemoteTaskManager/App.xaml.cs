using RemoteTaskManager.View;
using RemoteTaskManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteTaskManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var window = new AppView();
            window.DataContext = new MainViewModel();
            window.ShowDialog();
        }
    }
}

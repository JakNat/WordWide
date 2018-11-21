using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WordWide.UI.Data;
using WordWide.UI.ViewModel;

namespace WordWide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(
                new WordViewModel(
                    new WordDataService()));
            mainWindow.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CINCOPA.Common;
using CINCOPA.Views;

namespace CINCOPA
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var currentUser = Authentification.GetCurrentUser();
            if (Authentification.Authentificated())
            {
            //    MainViewModel main = new MainViewModel();
            //    MainView window = new View.MainView { DataContext = main };
            //    window.Show();
            }
            else
            {
         //       LoginViewModel authVm = new LoginViewModel();
                LoginView authV = new LoginView();
                authV.Show();
            }
        }

        /// <summary>
        /// Cleans up any resources on exit
        /// </summary>
        /// <param name="e">Arguments of the exit event</param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}

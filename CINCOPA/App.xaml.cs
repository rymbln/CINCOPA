using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CINCOPA.Common;
using CINCOPA.Views;
using System.Globalization;
using System.Windows.Markup;
using System.Threading;

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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                        XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
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

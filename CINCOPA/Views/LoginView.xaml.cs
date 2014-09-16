using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.ViewModel;

namespace CINCOPA.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((txtName.Text != "") & (txtPassword.Text != ""))
            {
                var user = new USER();
                user.NAME = txtName.Text;
                user.PASSWORD = txtPassword.Text;
                if (Authentification.AuthentificateUser(user))
                {
                    MainWindowViewModel main = new MainWindowViewModel();
                    MainWindow window = new MainWindow { DataContext = main };
                    window.Show();

                    this.Close();
                }

            }
        }
    }


}

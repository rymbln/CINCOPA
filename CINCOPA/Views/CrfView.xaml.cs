using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CINCOPA.Views
{
    /// <summary>
    /// Interaction logic for CrfView.xaml
    /// </summary>
    public partial class CrfView : Window
    {
        public CrfView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        //    OnPropertyChanged("AllCrf");
        }


     
       

       
    }
}

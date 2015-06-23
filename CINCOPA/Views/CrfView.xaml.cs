using CINCOPA.Common;
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
            uiScaleSlider.MouseDoubleClick +=

            new MouseButtonEventHandler(RestoreScalingFactor); 
            if (Authentification.GetCurrentUser().NAME == "user1")
            {
                uiScaleSlider.Value = 1.25;
            }
        }
        void RestoreScalingFactor(object sender, MouseButtonEventArgs args)
        {

            ((Slider)sender).Value = 1.0;

        } 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {

                tb.SelectAll();

            }
        }

        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {

                tb.SelectAll();

            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
        
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            this.firstTextbox.Focus();
            this.firstTextbox.SelectAll();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uiScaleSlider.Value = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            uiScaleSlider.Value = 1.25;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            uiScaleSlider.Value = 1.5;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            uiScaleSlider.Value = 1.75;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            uiScaleSlider.Value = 2;
        }


     
       

       
    }
}

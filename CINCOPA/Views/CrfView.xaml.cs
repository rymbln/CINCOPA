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
        }


        //private void TextBox_GotFocus1(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(e.OriginalSource as TextBox, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus1(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(e.OriginalSource as TextBox, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus2(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus2(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus3(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus3(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus4(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus4(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus5(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus5(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus6(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus6(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus7(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus7(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus8(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus8(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus9(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus9(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus10(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus10(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus11(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus11(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus12(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus12(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus13(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus13(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus14(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus14(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }

        //private void TextBox_GotFocus15(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("en-US")); }
        //private void TextBox_LostFocus15(object sender, RoutedEventArgs e) { TextBox tb = e.OriginalSource as TextBox; InputLanguageManager.SetInputLanguage(tb, CultureInfo.GetCultureInfo("ru-RU")); }


       

       
    }
}

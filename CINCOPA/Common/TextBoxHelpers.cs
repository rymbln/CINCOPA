using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CINCOPA.Common
{
   static class TextBoxHelpers
    {
        const string ALLOWED_CHARS = "0123456789ABCDEF.,";

        public static bool GetOnlyDecimal(TextBox textBox)
        {
            return (bool)textBox.GetValue(OnlyDecimalProperty);
        }

        public static void SetOnlyDecimal(TextBox textBox, bool value)
        {
            textBox.SetValue(OnlyDecimalProperty, value);
        }

        public static readonly DependencyProperty OnlyDecimalProperty =
            DependencyProperty.RegisterAttached(
                "OnlyDecimal", typeof(bool), typeof(TextBoxHelpers),
                new PropertyMetadata(false, OnOnlyDecimalChanged));

        static void OnOnlyDecimalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = d as TextBox;

            if (textBox == null)
                throw new InvalidOperationException("This property can only be applied to TextBox");

            var oldValue = (bool)e.OldValue;
            if (oldValue)
            {
                textBox.Text = textBox.Text.Replace(",", ".");
                textBox.PreviewTextInput -= OnPreviewTextInput;
            }

            var newValue = (bool)e.NewValue;
            if (newValue)
            {
                textBox.Text = textBox.Text.Replace(",", ".");
                textBox.PreviewTextInput += OnPreviewTextInput;
            }
        }

        static void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        static bool IsTextAllowed(string text)
        {
            return text.All(ALLOWED_CHARS.Contains);
        }
    }
}

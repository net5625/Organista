using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Organista.Components
{
    /// <summary>
    /// Logika interakcji dla klasy NumericBox.xaml
    /// </summary>
    public partial class NumericBox : UserControl
    {
        public NumericBox()
        {
            InitializeComponent();
        }

        public string Text { get; internal set; } = String.Empty;

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}

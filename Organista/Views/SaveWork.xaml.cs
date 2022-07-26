using System;
using System.Windows.Controls;

namespace Organista.Views
{
    /// <summary>
    /// Logika interakcji dla klasy SaveWork.xaml
    /// </summary>
    public partial class SaveWork : UserControl
    {
        public SaveWork()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            //Innicjalizacja standardowych danych - ostatnie dwa tygodnie.
            StartDate.SelectedDate = now.AddDays(-14);
            EndDate.SelectedDate = now;
            //Blokada rozpiętości kalendarza.
            StartDate.DisplayDateEnd = EndDate.DisplayDateEnd = now;
            StartDate.DisplayDateStart = EndDate.DisplayDateStart = now.AddDays(-60);
        }
    }
}

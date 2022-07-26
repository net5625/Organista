using Organista.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Organista.Views
{
    /// <summary>
    /// Logika interakcji dla klasy WorkTime.xaml
    /// </summary>
    public partial class WorkTime : UserControl
    {
        private readonly ModelContext _context;
        public protected WorkTime(ModelContext context)
        {
            InitializeComponent();
            _context = context;

            Date.DisplayDateEnd = DateTime.Now.AddDays(30);
            Date.DisplayDateStart = DateTime.Now.AddDays(-30);
            Date.SelectedDate = DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date;
            byte m, d, h, w, f, c, b;
            try
            {
                //Przygotowanie wartości...
                m = (byte)(int)Int16.Parse(Mass.Text);
                d = (byte)(int)Int16.Parse(Devotion.Text);
                h = (byte)(int)Int16.Parse(Houers.Text);
                w = (byte)(int)Int16.Parse(Wedding.Text);
                f = (byte)(int)Int16.Parse(Funeral.Text);
                c = (byte)(int)Int16.Parse(Cross.Text);
                b = (byte)(int)Int16.Parse(Bitter.Text);
                date = (DateTime)Date.SelectedDate;
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd podczas zapisu wprowadzonych danych", "Nieoczekiwany błąd!");
                return;
            }




            //Dodanie aktywności do bazy danych
            Model.Activity activity = new() { 
                Date = date,
                Mass = m,
                Wedding = w,
                Hours = h,
                Bitter = b,
                Devotion = d,
                Funeral = f,
                Cross = c,
            };
            _context.Activities.Add(activity);
            _context.SaveChangesAsync();
        }
    }
}

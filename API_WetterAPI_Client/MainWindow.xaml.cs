using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_App2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_1_Sub_Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Schließen?", "Beenden",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question,
                            MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test erfolgreich :)");
        }

        private void Btn_Datenabfragen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void ComboBox_AuswahlDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calender_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            if (calendar.SelectedDate.HasValue)
            {
                // Display SelectedDate in Title
                DateTime date = calendar.SelectedDate.Value;
                this.Title = date.ToShortDateString();
            } 
        }

    }
}

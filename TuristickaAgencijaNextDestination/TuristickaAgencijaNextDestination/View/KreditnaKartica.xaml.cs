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
using System.Windows.Shapes;

namespace TuristickaAgencijaNextDestination.View
{
    /// <summary>
    /// Interaction logic for KreditnaKartica.xaml
    /// </summary>
    public partial class KreditnaKartica : Window
    {
        // KOMENTAR BY RAMIZA
        public KreditnaKartica()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }
        
        private void btnPlati_Click(object sender, RoutedEventArgs e)
        {
            // poziv metode za verifikacuju kreditne kartice
            if (TuristickaAgencijaNextDestination.Klijent.IsValid(brojKreditneKartice.Text))
            {
                MessageBox.Show("Uspješno ste izvršili plaćanje putovanja!", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }

            else
            {
                MessageBox.Show("Broj kreditne kartice nije validan", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

            imePlacanje.Text = "";
            brojKreditneKartice.Text = "";
        } 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

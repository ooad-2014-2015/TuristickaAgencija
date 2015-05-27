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
        public KreditnaKartica()
        {
            InitializeComponent();
        }

        private void btnPlati_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspješno ste izvršili plaćanje putovanja!", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}

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
    /// Interaction logic for FormaPlacanje.xaml
    /// </summary>
    public partial class FormaPlacanje : Window
    {
        public FormaPlacanje()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspješno ste izvršili plaćanje", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

      
    }
}

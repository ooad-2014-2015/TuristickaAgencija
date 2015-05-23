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
    /// Interaction logic for FormaObrisiPredlozenoPutovanjeSaIzletom.xaml
    /// </summary>
    public partial class FormaObrisiPredlozenoPutovanjeSaIzletom : Window
    {
        public FormaObrisiPredlozenoPutovanjeSaIzletom()
        {
            InitializeComponent();
            gridObrisiPredlozenoPutovanjeSaIzletom.ItemsSource = null;
            gridObrisiPredlozenoPutovanjeSaIzletom.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gridObrisiPredlozenoPutovanjeSaIzletom.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali niti jedno putovanje", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            // Brise putovanje bez izleta

            TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom predlozenoSaIzletom = (Model.PutovanjeSaIzletom)gridObrisiPredlozenoPutovanjeSaIzletom.SelectedItem;
            //int id = predlozenoSaIzletom.Id;
            Model.PutovanjeSaIzletom.ObrisiPredlozenoPutovanjeSaIzletom(predlozenoSaIzletom);
            gridObrisiPredlozenoPutovanjeSaIzletom.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom;
            gridObrisiPredlozenoPutovanjeSaIzletom.Items.Refresh();
        }
    }
}

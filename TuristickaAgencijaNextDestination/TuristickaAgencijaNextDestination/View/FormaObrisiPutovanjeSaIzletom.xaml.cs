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
    /// Interaction logic for FormaObrisiPutovanjeSaIzletom.xaml
    /// </summary>
    public partial class FormaObrisiPutovanjeSaIzletom : Window
    {
        public FormaObrisiPutovanjeSaIzletom()
        {
            InitializeComponent();
            gridBrisiPutovanjaSaIzletom.ItemsSource = null;
            gridBrisiPutovanjaSaIzletom.ItemsSource = Model.PutovanjeSaIzletom.listaPutovanja;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (gridBrisiPutovanjaSaIzletom.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali putovanje za obrisati");
            }
            else
            {
                TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom pbz = (Model.PutovanjeSaIzletom)gridBrisiPutovanjaSaIzletom.SelectedItem;
               // int id = pbz.Id;
                Model.PutovanjeSaIzletom.ObrisiPutovanjeSaIzletom(pbz);
                gridBrisiPutovanjaSaIzletom.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.listaPutovanja;
                gridBrisiPutovanjaSaIzletom.Items.Refresh();
                //Close();
                //TuristickaAgencijaNextDestination.View.FormaObrisiPutovanjeSaIzletom forma = new FormaObrisiPutovanjeSaIzletom();
                //forma.Show();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

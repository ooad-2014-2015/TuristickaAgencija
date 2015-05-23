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
    /// Interaction logic for FormaObrisiPutovanje.xaml
    /// </summary>
    public partial class FormaObrisiPutovanje : Window
    {
        public FormaObrisiPutovanje()
        {
            InitializeComponent();
            gridObrisiPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gridObrisiPutovanje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali putovanje za obrisati");
            }
            else
            {
                TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta pbz=(Model.PutovanjaBezIzleta)gridObrisiPutovanje.SelectedItem;
                Model.PutovanjaBezIzleta.ObrisiPutovanje(pbz);
                gridObrisiPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
                gridObrisiPutovanje.Items.Refresh();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
        }
    }

          
        



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
    /// Interaction logic for FormaOdaberiPutovanje.xaml
    /// </summary>
    public partial class FormaOdaberiPutovanje : Window
    {
        public FormaOdaberiPutovanje()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (rbPutovanjaSaIzletom.IsChecked == true)
            {
                //ucitaj listu sa izletom
                gridOdaberiPutovanje.ItemsSource = null;
                gridOdaberiPutovanje.ItemsSource = Model.PutovanjeSaIzletom.listaPutovanja;
            }
            else
            {
                //ucitaj listu bez izleta
                gridOdaberiPutovanje.ItemsSource = null;
                gridOdaberiPutovanje.ItemsSource = Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (gridOdaberiPutovanje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali putovanje za obrisati");
            }
            else
            {
                if (rbPutovanjaSaIzletom.IsChecked == true)
                {
                    Model.PutovanjeSaIzletom p = (Model.PutovanjeSaIzletom)gridOdaberiPutovanje.SelectedItem;
                    Model.PutovanjeSaIzletom.listaOdabranihPutovanja.Add(p);
                }
                else if (rbPutovanjeBezIzleta.IsChecked == true)
                {
                    Model.PutovanjaBezIzleta pb = (Model.PutovanjaBezIzleta)gridOdaberiPutovanje.SelectedItem;
                    Model.PutovanjaBezIzleta.listaOdabranihPutovanja.Add(pb);
                }
                else 
                {
                    MessageBox.Show("Greska!");
                }
                FormaPlacanje f = new FormaPlacanje();
                f.Show();
            }
        }
    }
}

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
    /// Interaction logic for FormaOdobriPutovanje.xaml
    /// </summary>
    public partial class FormaOdobriPutovanje : Window
    {
        public FormaOdobriPutovanje()
        {
            InitializeComponent();
            //ucitati grid sa odobrenim putovanjima
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //putovanja bez izleta
            if (rbPutovanjeBezIzleta.IsChecked == true)
            {
                gridOdobriPutovanja.ItemsSource = null;
                gridOdobriPutovanja.ItemsSource = Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta;
            }
            else if (rbPutovanjeSaizletom.IsChecked == true)
            {
                //putovanja sa izletom
                gridOdobriPutovanja.ItemsSource = null;
                gridOdobriPutovanja.ItemsSource = Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom;
            }
            else if (rbPutovanjeSaizletom.IsChecked == false && rbPutovanjeBezIzleta.IsChecked == false)
            {
                MessageBox.Show("Odaberi koju listu zelis");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //putovanja sa izletom
            gridOdobriPutovanja.ItemsSource = null;
            gridOdobriPutovanja.ItemsSource = Model.PutovanjeSaIzletom.listaPutovanja;
        }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            if (rbPutovanjeBezIzleta.IsChecked == false && rbPutovanjeSaizletom.IsChecked == false)
                MessageBox.Show("Potrebno je odabrati listu za prikaz");

            if (gridOdobriPutovanja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali putovanje za odobriti");
            }
            else
            {
                //provjeravam koja od listi je ucitana u grid

                //dodaje to u listu putovanja bez izleta
                if (rbPutovanjeBezIzleta.IsChecked == true)
                {
                    //onaj selektovani
                    TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta pbz = (Model.PutovanjaBezIzleta)gridOdobriPutovanja.SelectedItem;
                        



                    //njega dodaje u listu
                    Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Add(pbz);
     
                    pbz.Id = Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Capacity + 1;
                    
                    int id = pbz.Id;
                     Model.PutovanjaBezIzleta.ObrisiPredlozenoPutovanje(id);

                    //potrebno je izbrisati sa grida
                     gridOdobriPutovanja.ItemsSource = Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
                     gridOdobriPutovanja.Items.Refresh();
                     //Close();
                     //FormaOdobriPutovanje f = new FormaOdobriPutovanje();
      
                     //f.Show();
                    

                }
                else
                {
                    //selektovan je onaj sa izletom
                    //dodam u listu sa izletom
                    TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom psi = (Model.PutovanjeSaIzletom)gridOdobriPutovanja.SelectedItem;
                    Model.PutovanjeSaIzletom.listaPutovanja.Add(psi);
                    psi.Id= Model.PutovanjeSaIzletom.listaPutovanja.Capacity + 1;
                    gridOdobriPutovanja.ItemsSource = Model.PutovanjeSaIzletom.listaPutovanja;
                    gridOdobriPutovanja.Items.Refresh();
                    
                }
                
                
            }
        }
    }
}

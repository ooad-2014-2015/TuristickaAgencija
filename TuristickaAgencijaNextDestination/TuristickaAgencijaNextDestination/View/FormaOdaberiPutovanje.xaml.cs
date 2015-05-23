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
            else if (rbPutovanjeBezIzleta.IsChecked == true)
            {
                //ucitaj listu bez izleta
                gridOdaberiPutovanje.ItemsSource = null;
                gridOdaberiPutovanje.ItemsSource = Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
            }
            else 
            {
                MessageBox.Show("Odaberite kategoriju putovanja!");
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
                    if (p.BrojSlobodnihMjesta == 0) MessageBox.Show("Nema slobodnih mjesta!");
                    else
                    {
                        Model.PutovanjeSaIzletom.listaOdabranihPutovanja.Add(p);
                        p.BrojSlobodnihMjesta -= 1;
                        if (p.BrojSlobodnihMjesta == 0)
                        {
                            Model.PutovanjeSaIzletom.ObrisiPutovanjeSaIzletom(p);
                        }
                        gridOdaberiPutovanje.Items.Refresh();

                    }
                }
                else if (rbPutovanjeBezIzleta.IsChecked == true)
                {
                    Model.Putovanje pb = (Model.Putovanje)gridOdaberiPutovanje.SelectedItem;
                    if (Convert.ToInt32(pb.BrojSlobodnihMjesta) == 0) MessageBox.Show("Nema slobodnih mjesta");
                    else
                    {
                        Model.PutovanjaBezIzleta.listaOdabranihPutovanja.Add(pb);
                        pb.BrojSlobodnihMjesta -= 1;
                        //if (pb.BrojSlobodnihMjesta == 0)
                        //{
                        //    Model.PutovanjaBezIzleta.listaOdabranihPutovanja.
                        //}
                        gridOdaberiPutovanje.Items.Refresh();
                    }
                }
                else 
                {
                    MessageBox.Show("Greska!");
                }

                FormaPlacanje f = new FormaPlacanje();
                f.Show();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for FormaObrisiPredlozenoPutovanje.xaml
    /// </summary>
    public partial class FormaObrisiPredlozenoPutovanje : Window
    {
        public FormaObrisiPredlozenoPutovanje()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            
            gridObrisiPredlozenoPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta;


        }

        private void btObrisiPredlozeno_Click(object sender, RoutedEventArgs e)
        {
            //Upotreba Thread - a (punjenje progressBar-a)

            new Thread(() =>
            {

                btObrisiPredlozeno.Dispatcher.BeginInvoke(new Action(() => { btObrisiPredlozeno.IsEnabled = false; }));

                for (int i = 0; i < 100; i++)
                {
                    progress.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        progress.Value = i;
                    }));
                    Thread.Sleep(1000);
                }
                btObrisiPredlozeno.Dispatcher.BeginInvoke(new Action(() => { btObrisiPredlozeno.IsEnabled = true; }));

            }).Start();


            if (gridObrisiPredlozenoPutovanje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali niti jedno putovanje", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            else
            {

                //Brise putovanje bez izleta

                TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta predlozenoBezIzleta = (Model.PutovanjaBezIzleta)gridObrisiPredlozenoPutovanje.SelectedItem;
                //int id = Convert.ToInt32(predlozenoBezIzleta.Id);
                Model.PutovanjaBezIzleta.ObrisiPredlozenoPutovanje(predlozenoBezIzleta);
                gridObrisiPredlozenoPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta;
                gridObrisiPredlozenoPutovanje.Items.Refresh();

                MessageBox.Show("Uspješno ste obrisali putovanje!", "Obavještenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

      
    }
}

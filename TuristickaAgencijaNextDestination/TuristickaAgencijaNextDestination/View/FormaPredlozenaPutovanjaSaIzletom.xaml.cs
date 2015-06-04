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
    /// Interaction logic for FormaPredlozenoPutovanjeBezIzleta.xaml
    /// </summary>
    public partial class FormaPredlozenoPutovanjeBezIzleta : Window
    {
        public FormaPredlozenoPutovanjeBezIzleta()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }
        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.Putovanje _putovanje = new TuristickaAgencijaNextDestination.Model.Putovanje();

            int id = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.dajNaredniIdPredlozeno();
            if (predlozeniAvion.IsChecked == true)
            {
                _putovanje.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.avion;
            }

            if (predlozeniAutobus.IsChecked == true)
            {
                _putovanje.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.autobus;
            }
            if (predlozeniBrod.IsChecked == true)
            {
                _putovanje.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.brod;
            }

            if (predlozenoSaOs.IsChecked == true)
            {
                _putovanje.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SarajevoOsiguranje;
            }

            if (predlozenoTrOs.IsChecked == true)
            {
                _putovanje.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.TriglavOsiguranje;
            }

            if (predlozenoASAOs.IsChecked == true)
            {
                _putovanje.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.ASAOsiguranje;
            }

            if (predlozenoSuOs.IsChecked == true)
            {
                _putovanje.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SunceOsiguranje;
            }

            //Validacija


            if (predlozenaDestinacija.Text == "" || cijenaPredlozenog == null || predlozeniIzlet.Text == "" || slobodnaMjestaPredlozeno.Text == "")
            {
                MessageBox.Show("Niste unijeli destinaciju, cijenu, izlet ili slobodna mjesta", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {
                TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom predlozenoPutovanjeSaIzletom = new TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom();


                predlozenoPutovanjeSaIzletom.Id = id;
                predlozenoPutovanjeSaIzletom.Destinacija = predlozenaDestinacija.Text;
                predlozenoPutovanjeSaIzletom.Cijena = Convert.ToDouble(cijenaPredlozenog.Text);
                predlozenoPutovanjeSaIzletom.DatumPolaska = Convert.ToDateTime(datumPolaskaPredlozenog.Text);
                predlozenoPutovanjeSaIzletom.DatumDolaska = Convert.ToDateTime(datumDolaskaPredlozenog.Text);
                // racunanje trajanja putovanja
                predlozenoPutovanjeSaIzletom.TrajanjePutovanja = predlozenoPutovanjeSaIzletom.DatumDolaska.DayOfYear - predlozenoPutovanjeSaIzletom.DatumPolaska.DayOfYear + 1;
                predlozenoPutovanjeSaIzletom.TrajanjePutovanja = Convert.ToInt32(trajanjePredlozenog.Text);
                predlozenoPutovanjeSaIzletom.BrojSlobodnihMjesta = Convert.ToInt32(slobodnaMjestaPredlozeno.Text);
                predlozenoPutovanjeSaIzletom.PrevoznoSredstvo = _putovanje.PrevoznoSredstvo;
                predlozenoPutovanjeSaIzletom.PutnoOsiguranje = _putovanje.PutnoOsiguranje;
                predlozenoPutovanjeSaIzletom.Izlet = predlozeniIzlet.Text;

                // provjera da li to putovanje vec postoji u listi putovanja

                if (Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom.Any(postojecePutovanje => postojecePutovanje.Id == predlozenoPutovanjeSaIzletom.Id))
                {
                    throw new ArgumentException("Putovanje već postoji u listi!");
                }
                else
                    // dodaj putovanje u listu

                    Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom.Add(predlozenoPutovanjeSaIzletom);
                    MessageBox.Show("Usješno ste dodali predloženo putovanje", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            predlozenaDestinacija.Text = "";
            cijenaPredlozenog.Text = "";
            trajanjePredlozenog.Text = "";
            slobodnaMjestaPredlozeno.Text = "";
            datumDolaskaPredlozenog.Text = "";
            datumPolaskaPredlozenog.Text = "";
            predlozeniIzlet.Text = "";
            predlozeniAutobus.IsChecked = false;
            predlozeniAvion.IsChecked = false;
            predlozeniBrod.IsChecked = false;
            predlozenoASAOs.IsChecked = false;
            predlozenoSaOs.IsChecked = false;
            predlozenoSuOs.IsChecked = false;
            predlozenoTrOs.IsChecked = false;

        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FormaObrisiPredlozenoPutovanjeSaIzletom f = new FormaObrisiPredlozenoPutovanjeSaIzletom();
            f.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        

       
       
    }
}

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
    /// Interaction logic for FormaPredlozenaPutovanja.xaml
    /// </summary>
    public partial class FormaPredlozenaPutovanja : Window
    {
        
        public FormaPredlozenaPutovanja()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void dodavanjePredlozenog_Click(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.Putovanje _putovanje = new TuristickaAgencijaNextDestination.Model.Putovanje();

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

            //Validacije

            if (predlozenaDestinacija.Text == "" || cijenaPredlozenog == null || slobodnaMjestaPredlozeno.Text == "")
            {
                MessageBox.Show("Niste unijeli destinaciju, cijenu i broj slobodnih mjesta", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta predlozenoPutovanjeBezIzleta = new TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta();

                predlozenoPutovanjeBezIzleta.Destinacija = predlozenaDestinacija.Text;
                predlozenoPutovanjeBezIzleta.Cijena = Convert.ToDouble(cijenaPredlozenog.Text);
                predlozenoPutovanjeBezIzleta.DatumPolaska = Convert.ToDateTime(datumPolaskaPredlozenog.Text);
                predlozenoPutovanjeBezIzleta.DatumDolaska = Convert.ToDateTime(datumDolaskaPredlozenog.Text);
                //racunanje trajanja putovanja
                int d = predlozenoPutovanjeBezIzleta.DatumDolaska.DayOfYear - predlozenoPutovanjeBezIzleta.DatumPolaska.DayOfYear + 1;
                predlozenoPutovanjeBezIzleta.TrajanjePutovanja = d;
                predlozenoPutovanjeBezIzleta.TrajanjePutovanja = Convert.ToInt32(trajanjePredlozenog.Text);
                predlozenoPutovanjeBezIzleta.BrojSlobodnihMjesta = Convert.ToInt32(slobodnaMjestaPredlozeno.Text);
                predlozenoPutovanjeBezIzleta.PrevoznoSredstvo = _putovanje.PrevoznoSredstvo;
                predlozenoPutovanjeBezIzleta.PutnoOsiguranje = _putovanje.PutnoOsiguranje;

                //provjera da li putovanje postoji u listi predlozenih putovanja


                if (Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta.Any(postojecePutovanje => postojecePutovanje.Id == predlozenoPutovanjeBezIzleta.Id))
                {
                    throw new ArgumentException("Putovanje već postoji u listi!");
                }
                else
                    // dodaj putovanje u listu

                    Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta.Add(predlozenoPutovanjeBezIzleta);
                    MessageBox.Show("Uspješno ste dodali putovanje bez izleta!", "Obavještenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            predlozenaDestinacija.Text = "";
            cijenaPredlozenog.Text = "";
            trajanjePredlozenog.Text = "";
            slobodnaMjestaPredlozeno.Text = "";
            datumDolaskaPredlozenog.Text = "";
            datumPolaskaPredlozenog.Text = "";
            predlozeniAutobus.IsChecked = false;
            predlozeniAvion.IsChecked = false;
            predlozeniBrod.IsChecked = false;
            predlozenoASAOs.IsChecked = false;
            predlozenoSaOs.IsChecked = false;
            predlozenoSuOs.IsChecked = false;
            predlozenoTrOs.IsChecked = false;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormaObrisiPredlozenoPutovanje f = new FormaObrisiPredlozenoPutovanje();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }       
    
}

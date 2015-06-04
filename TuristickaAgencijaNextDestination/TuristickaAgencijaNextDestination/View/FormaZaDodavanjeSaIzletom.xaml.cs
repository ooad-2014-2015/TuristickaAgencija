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
    /// Interaction logic for FormaZaDodavanjeSaIzletom.xaml
    /// </summary>
    public partial class FormaZaDodavanjeSaIzletom : Window
    {
        public FormaZaDodavanjeSaIzletom()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom putovanje1 = new TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom();
            int id = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.DajMiNaredniID();
            if (cbASAOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.ASAOsiguranje;
            }
            if (cbSarajevoOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SarajevoOsiguranje;
            }
            if (cbSunceOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SunceOsiguranje;
            }
            if (cbTriglavOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.TriglavOsiguranje;
            }


            if (cbAutobus.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.autobus;
            }
            if (cbAvion.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.avion;
            }
            if (cbBrod.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.brod;
            }
            if (txtDrzava.Text == "" || txtIzlet.Text == "" || txtCijena.Text == "" || txtBrojMjesta.Text == "")
            {

                MessageBox.Show("Niste unijeli sve podatke");
            }
            else
            {

                //TuristickaAgencijaNextDestination.Model.PutovanjeSaIzleta putovanja = new TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta();
                TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom putovanja = new Model.PutovanjeSaIzletom();
                putovanja.Id = id;
                putovanja.Destinacija = txtDrzava.Text;
                putovanja.Izlet = txtIzlet.Text;
                putovanja.Cijena = Convert.ToDouble(txtCijena.Text);
                putovanja.DatumDolaska = Convert.ToDateTime(dtpdatumOdlaska.Text);
                putovanja.DatumPolaska = Convert.ToDateTime(dtpDatumPolaska.Text);
                //oduzimanje dana
                int d = putovanja.DatumDolaska.DayOfYear - putovanja.DatumPolaska.DayOfYear + 1;
                txtTrajanjePutovanja.Text = d.ToString();
                putovanja.BrojSlobodnihMjesta = Convert.ToInt32(txtBrojMjesta.Text);
                putovanja.PrevoznoSredstvo = putovanje1.PrevoznoSredstvo;
                putovanja.PutnoOsiguranje = putovanje1.PutnoOsiguranje;
                putovanja.TrajanjePutovanja = Convert.ToInt32(txtTrajanjePutovanja.Text);
                // TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Add(putovanja);
                TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.listaPutovanja.Add(putovanja);



                MessageBox.Show("Snimljeno!");
            }
            txtBrojMjesta.Text = "";
            txtCijena.Text = "";
            txtDrzava.Text = "";
            txtTrajanjePutovanja.Text = "";
            txtIzlet.Text = "";
            dtpdatumOdlaska.Text = "";
            dtpDatumPolaska.Text = "";
            cbASAOsiguranje.IsChecked = false;
            cbAutobus.IsChecked = false;
            cbAvion.IsChecked = false;
            cbBrod.IsChecked = false;
            cbSarajevoOsiguranje.IsChecked = false;
            cbSunceOsiguranje.IsChecked = false;
            cbTriglavOsiguranje.IsChecked = false;




        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FormaPergledPutovanja frm = new FormaPergledPutovanja();
            frm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

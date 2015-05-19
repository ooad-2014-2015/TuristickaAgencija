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
    /// Interaction logic for FormaPutovanja.xaml
    /// </summary>
    public partial class FormaZaDodavanjePutovanja : Window
    {
        public FormaZaDodavanjePutovanja()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.Putovanje putovanje1=new TuristickaAgencijaNextDestination.Model.Putovanje();
            int id = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.DajMiNaredniID();
            if(rbASAOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje=TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.ASAOsiguranje;  
            }
            if (rbSarajevoOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SarajevoOsiguranje;
            }
            if (rbSunceOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SunceOsiguranje;
            }
            if (rbTriglavOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.TriglavOsiguranje;
            }


            if (rbAutobus.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.autobus;
            }
            if (rbAvion.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.avion;
            }
            if (rbBrod.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.brod;
            }
            TuristickaAgencijaNextDestination.Model.Putovanje putovanja = new TuristickaAgencijaNextDestination.Model.Putovanje(id, txtDrzava.Text, Convert.ToDouble(txtCijena.Text), Convert.ToDateTime(dtpDatumPolaska), Convert.ToDateTime(dtpdatumOdlaska), Convert.ToInt32(txtTrajanjePutovanja.Text), Convert.ToInt32(txtBrojMjesta.Text), putovanje1.PrevoznoSredstvo, putovanje1.PutnoOsiguranje);
            putovanja.Destinacija = txtDrzava.Text;
            putovanja.Cijena = Convert.ToDouble(txtCijena.Text);
            putovanja.DatumDolaska = Convert.ToDateTime(dtpdatumOdlaska);
            putovanja.DatumPolaska = Convert.ToDateTime(dtpDatumPolaska);
            putovanja.BrojSlobodnihMjesta = Convert.ToInt32(txtBrojMjesta.Text);
            putovanja.PrevoznoSredstvo = putovanje1.PrevoznoSredstvo;
            putovanja.PutnoOsiguranje = putovanje1.PutnoOsiguranje;
            putovanja.TrajanjePutovanja = Convert.ToInt32(txtTrajanjePutovanja.Text);
            TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.listaPutovanja.Add(putovanja);
            MessageBox.Show("Snimljeno!");
            txtBrojMjesta.Text = "";
            txtCijena.Text = "";
            txtDrzava.Text = "";
            txtTrajanjePutovanja.Text = "";
         

           
        }



       
    }
}

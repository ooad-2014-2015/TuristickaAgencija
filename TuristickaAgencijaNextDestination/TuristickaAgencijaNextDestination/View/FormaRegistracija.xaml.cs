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

namespace TuristickaAgencijaNextDestination
{
    /// <summary>
    /// Interaction logic for FormaRegistracija.xaml
    /// </summary>
    public partial class FormaRegistracija : Window
    {
        public FormaRegistracija()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            StatusKlijenta status;
    
            if (cmbStatus.SelectedIndex == 0)
                status = StatusKlijenta.student;
            else if (cmbStatus.SelectedIndex == 1)
                status = StatusKlijenta.penzioner;
            else
                status = StatusKlijenta.ostalo;

            string kartica = txtBrojKreditneKartice.Text;
            int brojKartice = int.Parse(kartica);

            Klijent k = new Klijent(Klijent.listaKlijenata.Count + 1, txtIme.Text, txtPrezime.Text,
                txtEmail.Text, brojKartice, status);

            Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Add(new Model.KorisnickiNalogKlijent( Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Count+1, k, txtUsername.Text, txtPassword.Text));

            MessageBox.Show("Uspjesna registracija. Dobrodosao/la: " + k.ime, "Poruka");

            Close();

        }
    }
}

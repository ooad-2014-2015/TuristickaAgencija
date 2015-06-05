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
using MySql.Data.MySqlClient;

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

        private bool jeLiPopunjenaForma()
        {
            if (txtIme.Text == "") return false;
            else if (txtPrezime.Text == "") return false;
            else if (txtEmail.Text == "") return false;
            else if (txtUsername.Text == "") return false;
            else if (txtPrezime.Text == "") return false;
            else if (cmbStatus.SelectedIndex != 0 && cmbStatus.SelectedIndex != 1 && cmbStatus.SelectedIndex != 2) return false;
            else if (txtBrojKreditneKartice.Text == "") return false;
            return true;
        }

        private void ponistiKontroleForme()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPrezime.Text = "";
            txtBrojKreditneKartice.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (jeLiPopunjenaForma())
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

                Klijent k = new Klijent(txtIme.Text, txtPrezime.Text,
                    txtEmail.Text, brojKartice, status);

                //Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Add(new Model.KorisnickiNalogKlijent(k, txtUsername.Text, txtPassword.Text));

                // rad sa bazom
                try
                {
                    k.upisKNalogaUBazu(txtIme.Text, txtPrezime.Text, txtUsername.Text, txtPassword.Text);
                    Model.KorisnickiNalogKlijent.ucitajListuKNAlogaIBaze();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                MessageBox.Show("Uspjesna registracija. Dobrodosao/la: " + k.ime, "Poruka");

                Close();
            }
            else
            {
                MessageBox.Show("Niste popunili sve podatke za registraciju!", "Poruka");
                ponistiKontroleForme();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}

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

            Klijent k = new Klijent(txtIme.Text, txtPrezime.Text,
                txtEmail.Text, brojKartice, status);

            Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Add(new Model.KorisnickiNalogKlijent(k, txtUsername.Text, txtPassword.Text));

            // rad sa bazom
            try
            {
                string username = "root";
                string password = "";
                string db = "turistickaagencija";
                
                string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
                MySqlConnection msc = new MySqlConnection(connectionString);
                msc.Open();

                MySqlCommand insertUpit = new MySqlCommand("insert into klijenti(username, password) values ('" + txtUsername.Text + "','" + txtPassword.Text  + "')", msc);

                //MySqlCommand insertUpit = new MySqlCommand();
                //insertUpit.CommandText = "insert into klijent values (@Username,@Password)";
                //insertUpit.Parameters.AddWithValue("@Username", txtUsername.Text);
                //insertUpit.Parameters.AddWithValue("@Password", txtPassword.Text);

                insertUpit.ExecuteNonQuery();

                msc.Close(); 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Uspjesna registracija. Dobrodosao/la: " + k.ime, "Poruka");

            Close();

        }
    }
}

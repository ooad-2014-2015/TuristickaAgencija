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
    /// Interaction logic for FormaPrijava.xaml
    /// </summary>
    public partial class FormaPrijava : Window
    {
        public FormaPrijava()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txbUsername.Text;
            string password = txbPassword.Password.ToString();
            bool pronasao = false;
            for (int i = 0; i < KorisnickiNalogKlijent.listaKNalogaKlijenata.Count; i++)
            {
                if (KorisnickiNalogKlijent.listaKNalogaKlijenata[i].username == userName &&
                    KorisnickiNalogKlijent.listaKNalogaKlijenata[i].password == password)
                {
                    Close();
                    FormaPergledPutovanja pregled = new FormaPergledPutovanja();
                    pregled.Show();
                    pronasao = true;
                }
                else if (Model.KorisnickiNalogTAgent.listaKNalogaTAgenata[i].username == userName &&
                         Model.KorisnickiNalogTAgent.listaKNalogaTAgenata[i].password == password)
                {
                    Close();
                    View.FormaPredlozenaPutovanja pregled = new View.FormaPredlozenaPutovanja();
                    pregled.Show();
                    pronasao = true;
                }
            }
            if (!pronasao)
            {
                MessageBox.Show("Korisnicki nalog sa ovim podacima nije registrovan.", "Poruka");
                txbUsername.Text = "";
                txbPassword.Password = "";
            }
        }
    }
}

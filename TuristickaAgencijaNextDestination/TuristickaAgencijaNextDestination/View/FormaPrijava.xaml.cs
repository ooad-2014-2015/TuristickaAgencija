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

            if ((userName == "admin") && (password == "admin"))
            {
                    Close();
                    View.FormaDodajBrisiPrihvati pregled = new View.FormaDodajBrisiPrihvati();
                    pregled.Show();
                    pronasao = true;
            }

            if (!pronasao)
            {
                for (int i = 0; i < Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Count; i++)
                {
                    if (Model.KorisnickiNalogKlijent.listaKNalogaKlijenti[i].username == userName &&
                             Model.KorisnickiNalogKlijent.listaKNalogaKlijenti[i].password == password)
                    {
                        Close();
                        FormaPergledPutovanja pregled = new FormaPergledPutovanja();
                        pregled.Show();
                        pronasao = true;
                    }
                }
            }

            if (!pronasao)
            {
                for (int i = 0; i < Model.KorisnickiNalogTAgent.listaKNalogaTAgent.Count; i++)
                {
                    if (Model.KorisnickiNalogTAgent.listaKNalogaTAgent[i].username == userName &&
                             Model.KorisnickiNalogTAgent.listaKNalogaTAgent[i].password == password)
                    {
                        Close();
                        View.FormaPredlozenaPutovanja pregled = new View.FormaPredlozenaPutovanja();
                        pregled.Show();
                        pronasao = true;
                    }
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

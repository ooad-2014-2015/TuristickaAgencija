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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TuristickaAgencijaNextDestination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen; // postavila sam na centar ekrana da se pojavljuje(Lejla)
            
            Klijent admin = new Klijent(0, "Admin", "Admin", "", 000, StatusKlijenta.ostalo);
            Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Add(new Model.KorisnickiNalogKlijent(0, admin, "admin", "admin"));

            TuristickiAgent tAgent = new TuristickiAgent(0, "tagent", "tagent", "");
            Model.KorisnickiNalogTAgent.listaKNalogaTAgent.Add(new Model.KorisnickiNalogTAgent(0, tAgent, "tagent", "tagent"));

            Klijent klijent = new Klijent(1, "Klijent", "Klijent", "", 000, StatusKlijenta.ostalo);
            Model.KorisnickiNalogKlijent.listaKNalogaKlijenti.Add(new Model.KorisnickiNalogKlijent(1, klijent, "klijent", "klijent"));
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FormaPrijava prijava = new FormaPrijava();
            prijava.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //FormaPergledPutovanja pregled = new FormaPergledPutovanja();
            //pregled.Show();
            Close();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            FormaRegistracija registracija = new FormaRegistracija();
            registracija.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.View.FormaDodajBrisiPrihvati frmDodajBrisiPrihvati = new View.FormaDodajBrisiPrihvati();
            frmDodajBrisiPrihvati.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FormaPergledPutovanja frm = new FormaPergledPutovanja();
            frm.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Turisticka agencija Next Destinatination \n Ukoliko niste registrovani registrujte se, nakon toga prijavite sa Vasim podacima i nesmetano pristupajte nasim informacijama");
        }
    }
}

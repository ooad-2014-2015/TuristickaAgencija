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
            MessageBox.Show("Upustva za pristup stranici \n \n \n Postovani korisnice ukoliko niste registrovani na nasu stranicu, molimo Vas da se na dugme ” Sign up” registrujete. \n Postovani korisnice ukoliko niste registrovani na nasu stranicu, molimo Vas da se na dugme ” Sign up” registrujete. \n Nakon sto ste se registrovali mozete se ulogovati na nasu stranicu. Klikom na dugme “Login” i unoseci validne podatke omogucava Vam se pristup nasoj stranici. \n Prozor koji Vam se automatski nakon logovanja otvara nudi Vam pregled dostupnih putovanja, Vase je samo da odaberete koji tip putovanja zelite. Ponudjena su Vam putovanja sa izletom i bez izleta. \n Pregledom putovanja ne obavezujete se da niti jedno putovanje izaberete kao Vasu destinaciju u svakom momentu slobodni ste da zatvorite stranicu. \n Ukoliko se ipak na nasoj listi putovanja nalazi nesto za vas, u desnom dornjem uglu se nalazi dugme ””  sa kojim Vam omogucavamo da odaberete zeljeno putovanje, rezervisete mjesto te zakljucite placanjem putovanja. Za placanje putovanja ce Vam biti potrebna kreditna kartica i na njoj odgovarajuci iznos ukoliko na Vasem racunu nema dovoljno sredstava otkazujemo Vasu registraciju.\n");
        }
    }
}

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
            KorisnickiNalog.listaKNaloga.Add(new KorisnickiNalog(0, admin, "admin", "admin"));
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
    }
}

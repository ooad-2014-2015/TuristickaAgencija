using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TuristickaAgencija
{
    public partial class Page1 : PhoneApplicationPage
    {
        
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click_3_bezIzleta(object sender, RoutedEventArgs e)
        {
            PutovanjaBezIzleta.DodajPutovanjeBezIzleta();
            string tekst = "Destinacija - Datum polaska - Datum dolaska - Cijena" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < PutovanjaBezIzleta.listaPutovanjaBezIzleta.Count; i++)
            {
                tekst += PutovanjaBezIzleta.Printaj(i);
                tekst += Environment.NewLine;
              
            }
            MessageBox.Show(tekst);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PutovanjeSaIzletom.DodajPutovanjaUListu();
            string tekst = "Destinacija - Izlet - Datum polaska - Datum dolaska - Cijena" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < PutovanjeSaIzletom.listaPutovanja.Count; i++)
            {
                tekst += PutovanjeSaIzletom.Printaj(i);
                tekst += Environment.NewLine;

            }
            MessageBox.Show(tekst);
        }

       
    }
}
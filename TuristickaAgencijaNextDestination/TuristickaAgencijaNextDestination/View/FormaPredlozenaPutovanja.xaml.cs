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
    /// Interaction logic for FormaPredlozenaPutovanja.xaml
    /// </summary>
    public partial class FormaPredlozenaPutovanja : Window
    {
        
        public FormaPredlozenaPutovanja()
        {
            InitializeComponent();
        }

        private void dodavanjePredlozenog_Click(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta predlozenoPutovanjeBezIzleta = new TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta();
            
            if (predlozenoBezIzleta.IsChecked == true )
            {

            predlozenoPutovanjeBezIzleta.Destinacija = predlozenaDestinacija.Text;
            predlozenoPutovanjeBezIzleta.Cijena = Convert.ToDouble(cijenaPredlozenog.Text);
            predlozenoPutovanjeBezIzleta.DatumPolaska = Convert.ToDateTime(datumPolaskaPredlozenog.Text);
            predlozenoPutovanjeBezIzleta.DatumDolaska = Convert.ToDateTime(datumDolaskaPredlozenog.Text);
            predlozenoPutovanjeBezIzleta.TrajanjePutovanja = Convert.ToInt32(trajanjePredlozenog.Text);
            predlozenoPutovanjeBezIzleta.BrojSlobodnihMjesta = Convert.ToInt32(slobodnaMjestaPredlozeno.Text);
           // predlozenoPutovanjeBezIzleta.PrevoznoSredstvo = new Model.PrevoznoSredstvo();
           // predlozenoPutovanjeBezIzleta.PutnoOsiguranje = new Model.PutnoOsiguranje();  
            predlozenoPutovanjeBezIzleta.Id = Convert.ToInt32(idPredlozenog.Text);

            Model.PutovanjaBezIzleta.listaPredlozenihPutovanjaBezIzleta.Add(predlozenoPutovanjeBezIzleta);
           
            }
           

            TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom  predlozenoPutovanjeSaIzletom = new TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom ();

            if (predlozenoSaIzletom.IsChecked == true)
            {

                predlozenoPutovanjeSaIzletom.Destinacija = predlozenaDestinacija.Text;
                predlozenoPutovanjeSaIzletom.Cijena = Convert.ToDouble(cijenaPredlozenog.Text);
                predlozenoPutovanjeSaIzletom.DatumPolaska = Convert.ToDateTime(datumPolaskaPredlozenog.Text);
                predlozenoPutovanjeSaIzletom.DatumDolaska = Convert.ToDateTime(datumDolaskaPredlozenog.Text);
                predlozenoPutovanjeSaIzletom.TrajanjePutovanja = Convert.ToInt32(trajanjePredlozenog.Text);
                predlozenoPutovanjeSaIzletom.BrojSlobodnihMjesta = Convert.ToInt32(slobodnaMjestaPredlozeno.Text);
                predlozenoPutovanjeSaIzletom.PrevoznoSredstvo = new Model.PrevoznoSredstvo();
             //   predlozenoPutovanjeSaIzletom.PutnoOsiguranje = new Model.PutnoOsiguranje();
            //    predlozenoPutovanjeSaIzletom.Id = Convert.ToInt32(idPredlozenog.Text);
                 predlozenoPutovanjeSaIzletom.Izlet = predlozeniIzlet.Text;

                 Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom.Add(predlozenoPutovanjeSaIzletom);
            }
        }

        

        }       
    
}

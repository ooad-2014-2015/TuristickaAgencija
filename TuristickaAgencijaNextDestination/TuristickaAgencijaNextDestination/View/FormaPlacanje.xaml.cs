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
    /// Interaction logic for FormaPlacanje.xaml
    /// </summary>
    public partial class FormaPlacanje : Window
    {
        
        public FormaPlacanje()
        {
            InitializeComponent();

            foreach (var item in TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaOdabranihPutovanja)
            {
                txtDestinacija.AppendText(item.Destinacija);
                txtPolazak.AppendText(Convert.ToString(item.DatumPolaska));
                txtDolazak.AppendText(Convert.ToString(item.DatumDolaska));
                txtTrajanje.AppendText(Convert.ToString(item.TrajanjePutovanja));
                txtPrevoznoSredstvo.AppendText(Convert.ToString(item.PrevoznoSredstvo));
                txtPutnoOsiguranje.AppendText(Convert.ToString(item.PutnoOsiguranje));
                txtCijena.AppendText(Convert.ToString(item.Cijena));
               
            }
            // da se izbrisu podaci iz liste
            TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaOdabranihPutovanja.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            KreditnaKartica fkk = new KreditnaKartica();
            fkk.Show();
        }
        

       

      
    }
}

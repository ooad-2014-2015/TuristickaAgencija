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

namespace TuristickaAgencijaNextDestination.View
{
    /// <summary>
    /// Interaction logic for UCPregledPutovanja.xaml
    /// </summary>
    public partial class UCPregledPutovanja : UserControl
    {
        public UCPregledPutovanja()
        {
            InitializeComponent();
            
            //WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.DodajPutovanjaUListu();
            gridPregledPutovanja.ItemsSource = null;
            gridPregledPutovanja.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.listaPutovanjaSaIzletom;
        }


        private void gridPregledPutovanja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

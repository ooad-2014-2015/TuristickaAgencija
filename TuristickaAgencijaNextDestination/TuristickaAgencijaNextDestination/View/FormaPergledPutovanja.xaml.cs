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
    /// Interaction logic for FormaPergledPutovanja.xaml
    /// </summary>
    public partial class FormaPergledPutovanja : Window
    {
        TuristickaAgencijaNextDestination.View.UCPregledPutovanja pregled;
        TuristickaAgencijaNextDestination.View.UCPregledPutovanjaBezIzleta pregled2;
        public FormaPergledPutovanja()
        {
            InitializeComponent();
        }

        private void btnPutovanjaSaIzletom_Click(object sender, RoutedEventArgs e)
        {
            panelPregledPutovanja.Children.Clear();
            pregled = new TuristickaAgencijaNextDestination.View.UCPregledPutovanja();
            panelPregledPutovanja.Children.Add(pregled);
        }


        private void btnPutovanjaBezIzleta_Click(object sender, RoutedEventArgs e)
        {
            panelPregledPutovanja.Children.Clear();
            pregled2 = new TuristickaAgencijaNextDestination.View.UCPregledPutovanjaBezIzleta();
            panelPregledPutovanja.Children.Add(pregled2);
        }

    }
}

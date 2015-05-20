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
    /// Interaction logic for FormaDodajBrisiPrihvati.xaml
    /// </summary>
    public partial class FormaDodajBrisiPrihvati : Window
    {
        public FormaDodajBrisiPrihvati()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FormaZaDodavanjePutovanja forma2 = new FormaZaDodavanjePutovanja();
            forma2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.View.FormaZaDodavanjePutovanja frm = new FormaZaDodavanjePutovanja();
            frm.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FormaZaDodavanjeSaIzletom frmDodavanje = new FormaZaDodavanjeSaIzletom();
            frmDodavanje.Show();
        }
    }
}

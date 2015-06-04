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
    /// Interaction logic for FormaTAgentOdabir.xaml
    /// </summary>
    public partial class FormaTAgentOdabir : Window
    {
        public FormaTAgentOdabir()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnPredlozenoPutovanjeBezIzleta_Click(object sender, RoutedEventArgs e)
        {
            View.FormaPredlozenaPutovanja f = new View.FormaPredlozenaPutovanja();
            f.Show();
        }

        private void btnPredlozenoPutovanjeSaIzletom_Click(object sender, RoutedEventArgs e)
        {

            View.FormaPredlozenoPutovanjeBezIzleta f = new FormaPredlozenoPutovanjeBezIzleta();
            f.Show();
        }
    }
}

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
    /// Interaction logic for UCPregledPutovanjaBezIzleta.xaml
    /// </summary>
    public partial class UCPregledPutovanjaBezIzleta : UserControl
    {
        public UCPregledPutovanjaBezIzleta()
        {
            InitializeComponent();
            TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.DodajPutovanjeBezIzleta();
            gridPregledPutovanjaBezIzleta.ItemsSource = null;
            gridPregledPutovanjaBezIzleta.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
        }
    }
}

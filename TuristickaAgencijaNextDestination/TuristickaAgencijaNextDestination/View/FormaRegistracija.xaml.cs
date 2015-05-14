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
    /// Interaction logic for FormaRegistracija.xaml
    /// </summary>
    public partial class FormaRegistracija : Window
    {
        public FormaRegistracija()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            lblIme.Foreground = new SolidColorBrush(Colors.White);
            lblPrezime.Foreground = new SolidColorBrush(Colors.White);
            lblEmail.Foreground = new SolidColorBrush(Colors.White);
            lblUsername.Foreground = new SolidColorBrush(Colors.White);
            lblPassword.Foreground = new SolidColorBrush(Colors.White);
            lblStatus.Foreground = new SolidColorBrush(Colors.White);
        }
    }
}

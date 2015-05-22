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
    /// Interaction logic for FormaBrisanjeNaloga.xaml
    /// </summary>
    public partial class FormaBrisanjeNaloga : Window
    {
        public FormaBrisanjeNaloga()
        {
            InitializeComponent();
            gridObrisiNalog.ItemsSource = TuristickaAgencijaNextDestination.Model.KorisnickiNalogKlijent.listaKorisnickihNalogaZaBrisanje;
        }

        private void btnObrisiNalog_Click(object sender, RoutedEventArgs e)
        {
            if (gridObrisiNalog.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali nalog za obrisati");
            }
            else
            {
                TuristickaAgencijaNextDestination.Model.KorisnickiNalogKlijent klijent = (Model.KorisnickiNalogKlijent)gridObrisiNalog.SelectedItem;
                int id = klijent.id;
                Model.KorisnickiNalogKlijent.obrisiKorisnickiNalog(id);
                gridObrisiNalog.ItemsSource = TuristickaAgencijaNextDestination.Model.KorisnickiNalogKlijent.listaKorisnickihNalogaZaBrisanje;
                gridObrisiNalog.Items.Refresh();
            }
        }
    }
}

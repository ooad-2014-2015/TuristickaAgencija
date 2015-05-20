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
    /// Interaction logic for FormaObrisiPutovanje.xaml
    /// </summary>
    public partial class FormaObrisiPutovanje : Window
    {
        public FormaObrisiPutovanje()
        {
            InitializeComponent();
            gridObrisiPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //if (gridObrisiPutovanje.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Niste odabrali putovanje za obrisati");
            //}
            //else
            //{
            //    int id = Convert.ToInt32(gridObrisiPutovanje.SelectedCells["ID"]);
            //    //int id = Convert.ToInt32(gridObrisiPutovanje.SelectedCells["ID1"].ToString());
            //    if (e.OriginalSource == DataGrid.DeleteCommand)
            //    {
            //        if (!(MessageBox.Show("Are you sure you want to delete?", "Please confirm.", MessageBoxButton.YesNo) == MessageBoxResult.Yes))
            //        {
            //            // Cancel Delete.
            //            e.Handled = true;
            //        }
            //    }
            //    MessageBox.Show("Obrisano");
            }
            
           // gridObrisiPutovanje.ItemsSource=
                //TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Remove(gridObrisiPutovanje.SelectAllCells());
                    
                /*int id = Convert.ToInt32(gridObrisiPutovanje.SelectedItem.ToString()) - 1;
                //int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID1"].Value.ToString()) - 1;
                TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.ObrisiPutovanje(id);
                MessageBox.Show("Uspješno ste obrisali putovanje");
                Close();
                gridObrisiPutovanje.ItemsSource = TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta;
                FormaObrisiPutovanje frmObrisiP = new FormaObrisiPutovanje();
                frmObrisiP.Show();*/
            }
          
        }



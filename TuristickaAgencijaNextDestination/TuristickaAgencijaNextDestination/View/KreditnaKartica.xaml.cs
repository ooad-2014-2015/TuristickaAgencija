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
    /// Interaction logic for KreditnaKartica.xaml
    /// </summary>
    public partial class KreditnaKartica : Window
    {
        public KreditnaKartica()
        {
            InitializeComponent();
        }
        
        private void btnPlati_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
               MessageBox.Show("Uspješno ste izvršili plaćanje putovanja!", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Information);
               Close();
        } 

        //Metoda za validaciju kreditne kartice 

        public static bool IsValid(string id)
        {

            int idLength = id.Length;
            int currentDigit;
            int idSum = 0;
            int currentProcNum = 0; 

            for (int i = idLength - 1; i >= 0; i--)
            {
                
                string idCurrentRightmostDigit = id.Substring(i, 1);

                if (!int.TryParse(idCurrentRightmostDigit, out currentDigit))
                    return false;

                if (currentProcNum % 2 != 0)
                {
                    if ((currentDigit *= 2) > 9)
                        currentDigit -= 9;
                }
                currentProcNum++; 

                idSum += currentDigit;
            }

            return (idSum % 10 == 0);
        }

=======
            MessageBox.Show("Uspješno ste izvršili plaćanje putovanja!", "Obavještenje", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            Close();

            
        }


>>>>>>> origin/master
    }
}

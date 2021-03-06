﻿using System;
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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            View.FormaOdaberiPutovanje f = new View.FormaOdaberiPutovanje();
            f.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}

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

namespace TuristickaAgencijaNextDestination.View
{
    /// <summary>
    /// Interaction logic for FormaPutovanja.xaml
    /// </summary>
    public partial class FormaZaDodavanjePutovanja : Window
    {
        public FormaZaDodavanjePutovanja()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TuristickaAgencijaNextDestination.Model.Putovanje putovanje1=new TuristickaAgencijaNextDestination.Model.Putovanje();
            int id = TuristickaAgencijaNextDestination.Model.PutovanjeSaIzletom.DajMiNaredniID();
            if(rbASAOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje=TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.ASAOsiguranje;  
            }
            if (rbSarajevoOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SarajevoOsiguranje;
            }
            if (rbSunceOsiguranje.IsChecked==true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.SunceOsiguranje;
            }
            if (rbTriglavOsiguranje.IsChecked == true)
            {
                putovanje1.PutnoOsiguranje = TuristickaAgencijaNextDestination.Model.PutnoOsiguranje.TriglavOsiguranje;
            }


            if (rbAutobus.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.autobus;
            }
            if (rbAvion.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.avion;
            }
            if (rbBrod.IsChecked == true)
            {
                putovanje1.PrevoznoSredstvo = TuristickaAgencijaNextDestination.Model.PrevoznoSredstvo.brod;
            }

           
            //PITANJE!!!!!!!!!!!!!!!!



            TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta putovanja = new TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta();
            putovanja.Destinacija = txtDrzava.Text;
            putovanja.Cijena = Convert.ToDouble(txtCijena.Text);
            putovanja.DatumDolaska = Convert.ToDateTime(dtpdatumOdlaska.Text);
            putovanja.DatumPolaska = Convert.ToDateTime(dtpDatumPolaska.Text);
            //oduzimanje dana
            int d = putovanja.DatumDolaska.DayOfYear - putovanja.DatumPolaska.DayOfYear+1;
            txtTrajanjePutovanja.Text = d.ToString();
            putovanja.BrojSlobodnihMjesta = Convert.ToInt32(txtBrojMjesta.Text);
            putovanja.PrevoznoSredstvo = putovanje1.PrevoznoSredstvo;
            putovanja.PutnoOsiguranje = putovanje1.PutnoOsiguranje;
            putovanja.TrajanjePutovanja = Convert.ToInt32(txtTrajanjePutovanja.Text);
            TuristickaAgencijaNextDestination.Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Add(putovanja);
            MessageBox.Show("Snimljeno!");
            txtBrojMjesta.Text = "";
            txtCijena.Text = "";
            txtDrzava.Text = "";
            txtTrajanjePutovanja.Text = "";
         

           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FormaPergledPutovanja frm = new FormaPergledPutovanja();
            frm.Show();
        }



       
    }
}

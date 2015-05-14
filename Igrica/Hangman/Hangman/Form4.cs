using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form4 : Form
    {
        private int brojGresaka;

        public string ime { get; set; }

        public Form4(int broj)
        {
            InitializeComponent();
            brojGresaka = broj;
            int brojBodova = 30 - brojGresaka * 5;
            label1.Text += brojBodova.ToString();
            label1.Text += " bodova.";
            toolStripStatusLabel1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacijaUnosaImena() == false)
            {
                errorProvider1.SetError(textBox1, "Greska");
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska. Niste unijeli ime.";
            }
            else
            {
                errorProvider1.Clear();
                toolStripStatusLabel1.Text = "";
                ime = textBox1.Text;
                // MessageBox.Show(ime); ok
                if (System.Windows.Forms.Application.OpenForms[1] != null)
                {
                    (System.Windows.Forms.Application.OpenForms[1] as Form2).ucitajNovogIgraca(textBox1.Text);
                }
                Close();
            }
        }

        private bool validacijaUnosaImena()
        {
            if (textBox1.Text == "") return false;
            return true;
        }

        public string dajImeIgraca()
        {
            return ime;
        }
    }
}

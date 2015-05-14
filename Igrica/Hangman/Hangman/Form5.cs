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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        internal Form5(List<Igrac> _igraci)
        {
            InitializeComponent();
            for (int i = 0; i < _igraci.Count(); i++)
            {
                //textBox1.Text += ime;
                richTextBox1.Text += _igraci[i].ime + Environment.NewLine;
                richTextBox2.Text += _igraci[i].brojBodova + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

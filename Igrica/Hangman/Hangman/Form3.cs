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
    public partial class Form3 : Form
    {
        public string level;
        public string field; 
        public Form3()
        {
            InitializeComponent();
            radioButton4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = kojiJeLevel();
            field = kojiJeField();
            Form2 igra = new Form2(level, field);
            igra.Show();
            Close(); 
        }

        private string kojiJeLevel()
        {
            if (radioButton1.Checked)
                return level = radioButton1.Text;
            else if (radioButton2.Checked)
                return level = radioButton2.Text;
            return level = radioButton3.Text;
        }

        private string kojiJeField()
        {
            if (radioButton4.Checked)
                return field = radioButton4.Text;
            return field = radioButton5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

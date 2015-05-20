using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

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
                upisiUXml(_igraci);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void upisiUXml(List<Igrac> _igraci)
        {
            try
            {

                XmlSerializer x = new XmlSerializer(typeof(List<Igrac>));
                StreamWriter sw = new StreamWriter(@"C:\Users\Lejla\Documents\Lejla\Fakultet\4. semestar\OOAD\Projekat\Igrica\Hangman\Igraci.xml");

                x.Serialize(sw, _igraci);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Izuzetak pri xml serijalizaciji: " + ex.Message, "Izuzetak");
            }
        }
    }
}

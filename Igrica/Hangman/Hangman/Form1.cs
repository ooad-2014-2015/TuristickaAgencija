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
    public partial class Form1 : Form
    {
        private List<Igrac> igraci = new List<Igrac>();

        public Form1()
        {
            InitializeComponent();
            /*Igrac novi1 = new Igrac("Lejla", 2);
            Igrac novi2 = new Igrac("Merseda", 0);
            Igrac novi3 = new Igrac("Ramiza", 4);
            igraci.Add(novi1);
            igraci.Add(novi2);
            igraci.Add(novi3);*/
            ucitajIzXml();
            sortirajIgracePoBodovima();
        }

        private void ucitajIzXml()
        {
            try
            {
                string putanja = Path.Combine(Environment.CurrentDirectory, @"\Igraci.xml");
                MessageBox.Show(putanja);
                using (FileStream fs = new FileStream(putanja, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Igrac>));
                    igraci = serializer.Deserialize(fs) as List<Igrac>;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Izuzetak pri deserijalizaciji: " + ex.Message, "Izuzetak");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 opcije = new Form3();
            opcije.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 rezultati = new Form5(igraci);
            rezultati.Show();
        }

        private void sortirajIgracePoBodovima()
        {
            igraci = igraci.OrderBy(o => o.brojBodova).ToList();
            igraci.Reverse();
        }

        internal void ucitajIgrace(List<Igrac> _igraci)
        {
            for (int i = 0; i < _igraci.Count(); i++)
            {
                igraci.Add(_igraci[i]);
            }
            sortirajIgracePoBodovima();
        }
    }
}

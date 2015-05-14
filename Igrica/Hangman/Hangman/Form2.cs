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
    public partial class Form2 : Form
    {
        List<string> easyCities = new List<string>();
        List<string> easyCountries = new List<string>();

        List<string> normalCities = new List<string>();
        List<string> normalCountries = new List<string>();

        List<string> hardCities = new List<string>();
        List<string> hardCountries = new List<string>();

        private List<Igrac> igraci = new List<Igrac>();

        private string level, field;
        private string pojam;
        private int brojacGreski = 0;
        private int brojacPogodjenih = 0;

        List<int> niz = new List<int>();

        public Form2(string _level, string _field)
        {
            InitializeComponent();

            level = _level;
            field = _field;

            if (field == "Cities")
                label3.Visible = true;
            else label4.Visible = true;

            easyCities.Add("RIM");
            easyCities.Add("OSLO");
            easyCities.Add("RIGA");

            easyCountries.Add("KINA");
            easyCountries.Add("PERU");

            normalCities.Add("ZAGREB");
            normalCities.Add("MADRID");

            normalCountries.Add("ANGOLA");
            normalCountries.Add("RUSIJA");

            hardCities.Add("BELFAST");
            hardCities.Add("BRAZILIJA");

            hardCountries.Add("BUGARSKA");
            hardCountries.Add("PARAGVAJ");

            nacrtajPojam(); 
        }

        private string pronadjiRandomPojam()
        {
            var random = new Random();
            int index;

            if (level == "Easy")
            {
                if (field == "Cities")
                {
                    index = random.Next(easyCities.Count);
                    return easyCities[index];
                }
                index = random.Next(easyCountries.Count);
                return easyCountries[index];
            }
            if (level == "Normal")
            {
                if (field == "Cities")
                {
                    index = random.Next(normalCities.Count);
                    return normalCities[index];
                }
                index = random.Next(normalCountries.Count);
                return normalCountries[index];
            }
            else
            {
                if (field == "Cities")
                {
                    index = random.Next(hardCities.Count);
                    return hardCities[index];
                }
                index = random.Next(hardCountries.Count);
                return hardCountries[index];
            }
        }

        private void prvaTriButtonaVidljiva()
        {
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
        }

        private void prvaCetiriButtonaVidljiva()
        {
            prvaTriButtonaVidljiva();
            button30.Visible = true;
        }

        private void prvihPetButtonaVidljiva()
        {
            prvaCetiriButtonaVidljiva();
            button31.Visible = true;
        }

        private void prvihSestButtonaVidljiva()
        {
            prvihPetButtonaVidljiva();
            button32.Visible = true;
        }

        private void prvihSedamButtonaVidljiva()
        {
            prvihSestButtonaVidljiva();
            button33.Visible = true;
        }

        private void prvihOsamButtonaVidljiva()
        {
            prvihSedamButtonaVidljiva();
            button34.Visible = true;
        }

        private void prvihDevetButtonaVidljiva()
        {
            prvihOsamButtonaVidljiva();
            button36.Visible = true;
        }

        private void nacrtajPojam()
        {
            pojam = pronadjiRandomPojam();
            int brojDugmadi = pojam.Length;

            if (brojDugmadi == 3) prvaTriButtonaVidljiva();

            else if (brojDugmadi == 4) prvaCetiriButtonaVidljiva();

            else if (brojDugmadi == 5) prvihPetButtonaVidljiva();

            else if (brojDugmadi == 6) prvihSestButtonaVidljiva();

            else if (brojDugmadi == 7) prvihSedamButtonaVidljiva();

            else if (brojDugmadi == 8) prvihOsamButtonaVidljiva();

            else prvihDevetButtonaVidljiva();
            
        }

        private bool jeLiSlovoUPojmu(string s)
        {
            int brojacPonavljanja = 0;
            for (int i = 0; i < pojam.Length; i++)
            {
                if (s == pojam[i].ToString())
                {
                    brojacPonavljanja++;
                    niz.Add(i+1);
                }
            }
            if (brojacPonavljanja == 0)
                return false;
            else
                return true;
        }

        private void onesposobiDugmad()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
        }

        private void staviTriSlovaUPolja()
        {
            button27.Text = pojam[0].ToString();
            button27.BackColor = Color.Red;
            button28.Text = pojam[1].ToString();
            button28.BackColor = Color.Red;
            button29.Text = pojam[2].ToString();
            button29.BackColor = Color.Red;

        }

        private void staviCetiriSlovaUPolja()
        {
            staviTriSlovaUPolja();
            button30.Text = pojam[3].ToString();
            button30.BackColor = Color.Red;
        }

        private void staviPetSlovaUPolja()
        {
            staviCetiriSlovaUPolja();
            button31.Text = pojam[4].ToString();
            button31.BackColor = Color.Red;
        }

        private void staviSestSlovaUPolja()
        {
            staviPetSlovaUPolja();
            button32.Text = pojam[5].ToString();
            button32.BackColor = Color.Red;
        }

        private void staviSedamSlovaUPolja()
        {
            staviSestSlovaUPolja();
            button33.Text = pojam[6].ToString();
            button33.BackColor = Color.Red;
        }

        private void staviOsamSlovaUPolja()
        {
            staviSedamSlovaUPolja();
            button34.Text = pojam[7].ToString();
            button34.BackColor = Color.Red;
        }

        private void staviDevetSlovaUPolja()
        {
            staviOsamSlovaUPolja();
            button36.Text = pojam[8].ToString();
            button36.BackColor = Color.Red;
        }

        private void staviPojamUPolja()
        {
            if (pojam.Length == 3) staviTriSlovaUPolja();
            else if (pojam.Length == 4) staviCetiriSlovaUPolja();
            else if (pojam.Length == 5) staviPetSlovaUPolja();
            else if (pojam.Length == 6) staviSestSlovaUPolja();
            else if (pojam.Length == 7) staviSedamSlovaUPolja();
            else if (pojam.Length == 8) staviOsamSlovaUPolja();
            else staviDevetSlovaUPolja();
        }

        private void crtajLik()
        {
            if (brojacGreski == 1)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman2;
            }
            if (brojacGreski == 2)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman3;
            }
            if (brojacGreski == 3)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman4;
            }
            if (brojacGreski == 4)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman5;
            }
            if (brojacGreski == 5)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman6;
            }
            if (brojacGreski == 6)
            {
                pictureBox1.Image = Hangman.Properties.Resources.rsz_hangman7;
                label2.Visible = true;
                onesposobiDugmad();
                staviPojamUPolja();
                upisRezultata();
            }

        }

        private void obojiPoljaUZeleno()
        {
            button27.BackColor = Color.GreenYellow;
            button28.BackColor = Color.GreenYellow;
            button29.BackColor = Color.GreenYellow;
            button30.BackColor = Color.GreenYellow;
            button31.BackColor = Color.GreenYellow;
            button32.BackColor = Color.GreenYellow;
            button33.BackColor = Color.GreenYellow;
            button34.BackColor = Color.GreenYellow;
            button36.BackColor = Color.GreenYellow;
        }

        private void popuniMjestaSlovom(string s)
        {
            int brojDuplikata = niz.Count;
            int i = 0;
            while (brojDuplikata != 0)
            {
                if (niz[i] == 1) button27.Text = s;
                else if (niz[i] == 2) button28.Text = s;
                else if (niz[i] == 3) button29.Text = s;
                else if (niz[i] == 4) button30.Text = s;
                else if (niz[i] == 5) button31.Text = s;
                else if (niz[i] == 6) button32.Text = s;
                else if (niz[i] == 7) button33.Text = s;
                else if (niz[i] == 8) button34.Text = s;
                else if (niz[i] == 9) button36.Text = s;
                brojDuplikata--;
                i++;
                brojacPogodjenih++;
            }
            if (brojacPogodjenih == pojam.Length)
            {
                label1.Visible = true;
                onesposobiDugmad();
                obojiPoljaUZeleno();
                upisRezultata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button1.Text))
            {
                popuniMjestaSlovom(button1.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button2.Text))
            {
                popuniMjestaSlovom(button2.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button3.Text))
            {
                popuniMjestaSlovom(button3.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button4.Text))
            {
                popuniMjestaSlovom(button4.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button5.Text))
            {
                popuniMjestaSlovom(button5.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button6.Text))
            {
                popuniMjestaSlovom(button6.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button7.Text))
            {
                popuniMjestaSlovom(button7.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button7.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button8.Text))
            {
                popuniMjestaSlovom(button8.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button8.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button9.Text))
            {
                popuniMjestaSlovom(button9.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button9.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button10.Text))
            {
                popuniMjestaSlovom(button10.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button10.Enabled = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button11.Text))
            {
                popuniMjestaSlovom(button11.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button11.Enabled = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button12.Text))
            {
                popuniMjestaSlovom(button12.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button12.Enabled = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button13.Text))
            {
                popuniMjestaSlovom(button13.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button13.Enabled = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button14.Text))
            {
                popuniMjestaSlovom(button14.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button14.Enabled = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button15.Text))
            {
                popuniMjestaSlovom(button15.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button15.Enabled = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button16.Text))
            {
                popuniMjestaSlovom(button16.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button16.Enabled = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button17.Text))
            {
                popuniMjestaSlovom(button17.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button17.Enabled = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button18.Text))
            {
                popuniMjestaSlovom(button18.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button18.Enabled = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button19.Text))
            {
                popuniMjestaSlovom(button19.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button19.Enabled = false;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button20.Text))
            {
                popuniMjestaSlovom(button20.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button20.Enabled = false;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button21.Text))
            {
                popuniMjestaSlovom(button21.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button21.Enabled = false;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button22.Text))
            {
                popuniMjestaSlovom(button22.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button22.Enabled = false;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button23.Text))
            {
                popuniMjestaSlovom(button23.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button23.Enabled = false;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button24.Text))
            {
                popuniMjestaSlovom(button24.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button24.Enabled = false;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button25.Text))
            {
                popuniMjestaSlovom(button25.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button25.Enabled = false;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            niz.Clear();
            if (jeLiSlovoUPojmu(button26.Text))
            {
                popuniMjestaSlovom(button26.Text);
            }
            else
            {
                brojacGreski++;
                crtajLik();
            }
            button26.Enabled = false;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms[0] != null)
            {
                (System.Windows.Forms.Application.OpenForms[0] as Form1).ucitajIgrace(igraci);
            }
            Close();
        }

        private void upisRezultata()
        {
            Form4 upisRezultataa = new Form4(brojacGreski);
            upisRezultataa.Show();
            
            //Igrac _novi = new Igrac(upisRezultataa.ime, brojacGreski);

            //igraci.Add(_novi);
        }

        public void ucitajNovogIgraca(string _ime)
        {
            Igrac _novi = new Igrac(_ime, brojacGreski);

            igraci.Add(_novi);
        }
    }
}

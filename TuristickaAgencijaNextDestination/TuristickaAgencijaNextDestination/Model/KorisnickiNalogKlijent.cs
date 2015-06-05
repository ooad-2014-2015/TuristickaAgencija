using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TuristickaAgencijaNextDestination.Model
{
    public class KorisnickiNalogKlijent :KorisnickiNalog
    {
        public string imeVlasnika { get; set; }
        public string prezimeVlasnika { get; set; }

        public static List<KorisnickiNalogKlijent> listaKNalogaKlijenti = new List<KorisnickiNalogKlijent>();

        public static List<KorisnickiNalogKlijent> listaKorisnickihNalogaZaBrisanje = new List<KorisnickiNalogKlijent>();

        // ucitaj listu korisnickih naloga iz baze
        public static void ucitajListuKNAlogaIBaze()
        {
            string username = "root";
            string password = "";
            string db = "turistickaagencija";
            //Konekcija na bazu 
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand upitKomanda = new MySqlCommand("select * from korisnickinalozi", con);
            MySqlDataReader r = upitKomanda.ExecuteReader();
            while (r.Read())
            {
                listaKNalogaKlijenti.Add(new KorisnickiNalogKlijent(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"), r.GetString("password")));

            }

            //MySqlCommand upitKomanda = new MySqlCommand("select * from studenti", con);
            //MySqlDataReader r = upitKomanda.ExecuteReader();
            //while (r.Read())
            //{
            //    studenti.Add(new Student(r.GetString("Ime"), r.GetString("Prezime"),
            //   r.GetString("Email"), r.GetDateTime("DatumUpisa")));
            //    Console.Out.Write(r.GetString("Ime") + " " + r.GetString("Prezime"));
            //} 
        }


        //Funkcija za brisanje korisnickih naloga

        public static void ObrisiKorisnickiNalog(KorisnickiNalogKlijent nalog)
        {
            for (int i = 0; i < listaKorisnickihNalogaZaBrisanje.Count(); i++)
            {
                if (nalog.username == listaKorisnickihNalogaZaBrisanje[i].username)
                {
                    listaKorisnickihNalogaZaBrisanje.RemoveAt(i);
                }
            }
        }

        public KorisnickiNalogKlijent()
        {

        }

        public KorisnickiNalogKlijent(string _ime, string _prezime, string _username, string _password)
            : base(_username, _password)
        {
            imeVlasnika = _ime;
            prezimeVlasnika = _prezime;
        }

        
     
    }
}

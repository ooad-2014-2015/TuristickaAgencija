using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TuristickaAgencijaNextDestination
{
    public enum StatusKlijenta {student, penzioner, ostalo};

    public class Klijent : Osoba
    {

        public int brojKreditneKartice { get; set; }

        public StatusKlijenta statusKlijenta { get; set; }

        public static List<Klijent> listaKlijenata = new List<Klijent>();

        public Klijent()
        {

        }
      
        public Klijent(String _ime, String _prezime, String _eMail, int _broj, StatusKlijenta _status) 
            : base(_ime, _prezime, _eMail)
        {
            brojKreditneKartice = _broj;
            statusKlijenta = _status;
        }
        // Funkcija za verifikaciju kreditne kartice

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


        // unos korisnickog naloga klijenta u bazu
        public void upisKNalogaUBazu(string _ime, string _prezime, string _username, string _password)
        {
            string username = "root";
            string password = "";
            string db = "turistickaagencija";

            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            MySqlConnection msc = new MySqlConnection(connectionString);
            msc.Open();

            MySqlCommand insertUpit = new MySqlCommand("insert into korisnickinalozi(ime, prezime, username, password) values ('" + _ime + "','" + _prezime + "','" + _username + "','" + _password + "')", msc); 
            insertUpit.ExecuteNonQuery();

            msc.Close();

        }
      
    }
}

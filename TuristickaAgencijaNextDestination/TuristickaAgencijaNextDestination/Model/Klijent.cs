using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public enum StatusKlijenta {student, penzioner, ostalo};

    public class Klijent : Osoba
    {
        //Komentar by bajgorio

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
      
    }
}

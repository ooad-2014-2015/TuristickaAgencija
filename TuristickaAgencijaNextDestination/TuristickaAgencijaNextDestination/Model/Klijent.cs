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
      
        public Klijent(int _id, String _ime, String _prezime, String _eMail, int _broj, StatusKlijenta _status) 
            : base(_id, _ime, _prezime, _eMail)
        {
            brojKreditneKartice = _broj;
            statusKlijenta = _status;
        }

      
    }
}

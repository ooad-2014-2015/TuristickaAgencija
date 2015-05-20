using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    enum StatusKlijenta {student, penzioner, ostalo};
    class Klijent : Osoba
    {
        public int brojKreditneKartice { get; set; }

        public StatusKlijenta statusKlijenta { get; set; }

        public Klijent(int _id, String _ime, String _prezime, String _eMail, int _broj, StatusKlijenta _status) 
            : base(_id, _ime, _prezime, _eMail)
        {
            brojKreditneKartice = _broj;
            statusKlijenta = _status;
        }
    }
}

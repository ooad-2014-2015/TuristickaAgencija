using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public class Osoba
    {

        public String ime { get; set; }

        public String prezime { get; set; }

        public String eMail { get; set; }

        public Osoba()
        {

        }

        public Osoba(String _ime, String _prezime, String _eMail)
        {
            ime = _ime;
            prezime = _prezime;
            eMail = _eMail;
        }
    }
}

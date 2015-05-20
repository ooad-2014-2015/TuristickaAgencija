using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public class Osoba
    {
        public int id { get; set; }

        public String ime { get; set; }

        public String prezime { get; set; }

        public String eMail { get; set; }

        public Osoba()
        {

        }

        public Osoba(int _id, String _ime, String _prezime, String _eMail)
        {
            id = _id;
            ime = _ime;
            prezime = _prezime;
            eMail = _eMail;
        }
    }
}

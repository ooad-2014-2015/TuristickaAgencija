using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    public class KorisnickiNalogKlijent :KorisnickiNalog
    {
        public Klijent vlasnik { get; set; }

        public static List<KorisnickiNalogKlijent> listaKNalogaKlijenti = new List<KorisnickiNalogKlijent>();

        public KorisnickiNalogKlijent()
        {

        }

        public KorisnickiNalogKlijent(int _id, Klijent _vlasnik, string _username, string _password)
            : base(_id, _username, _password)
        {
            vlasnik = _vlasnik;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    public class KorisnickiNalogTAgent : KorisnickiNalog
    {
        public TuristickiAgent vlasnik { get; set; }

        public static List<KorisnickiNalogTAgent> listaKNalogaTAgent = new List<KorisnickiNalogTAgent>();

        public KorisnickiNalogTAgent()
        {

        }

        public KorisnickiNalogTAgent(TuristickiAgent _vlasnik, string _username, string _password)
            : base(_username, _password)
        {
            vlasnik = _vlasnik;
        }
    }
}

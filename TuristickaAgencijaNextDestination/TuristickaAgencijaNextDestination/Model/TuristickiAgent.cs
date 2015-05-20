using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public class TuristickiAgent : Osoba
    {
        public TuristickiAgent(int _id, String _ime, String _prezime, String _eMail)
            : base(_id, _ime, _prezime, _eMail)
        {

        }
    }
}

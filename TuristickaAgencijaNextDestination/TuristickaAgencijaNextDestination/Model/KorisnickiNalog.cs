using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    class KorisnickiNalog
    {
        public int id { get; set; }

        public Klijent vlasnikNaloga { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public KorisnickiNalog()
        {

        }

        public KorisnickiNalog(int _id, Klijent _vlasnik)
        {
            id = _id;
            vlasnikNaloga = _vlasnik;
        }

        public void ispisKorisnickogNaloga()
        {

        }

        public KorisnickiNalog unosKorisnickogNAloga()
        {
            KorisnickiNalog kn;
            kn = new KorisnickiNalog(id, vlasnikNaloga);
            return kn;
        }
    }
}

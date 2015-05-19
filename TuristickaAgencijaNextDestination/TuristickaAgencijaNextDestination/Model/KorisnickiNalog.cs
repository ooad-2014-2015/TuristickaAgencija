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

        public static List<KorisnickiNalog> listaKNaloga = new List<KorisnickiNalog>();

        public KorisnickiNalog()
        {
            
        }

        public KorisnickiNalog(int _id, Klijent _vlasnik, string _userName, string _password)
        {
            id = _id;
            vlasnikNaloga = _vlasnik;
            username = _userName;
            password = _password;
        }

        public void ispisKorisnickogNaloga()
        {

        }

        public KorisnickiNalog unosKorisnickogNAloga()
        {
            KorisnickiNalog kn;
            kn = new KorisnickiNalog(id, vlasnikNaloga, username, password);
            return kn;
        }

    }
}

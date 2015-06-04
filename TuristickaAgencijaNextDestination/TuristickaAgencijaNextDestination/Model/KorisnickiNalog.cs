using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public class KorisnickiNalog
    {
        public String username { get; set; }

        public String password { get; set; }

        public KorisnickiNalog()
        {
            
        }

        public KorisnickiNalog(string _userName, string _password)
        {
            username = _userName;
            password = _password;
        }

        public void ispisKorisnickogNaloga()
        {

        }

        /*public KorisnickiNalog unosKorisnickogNAloga()
        {
            KorisnickiNalog kn;
            kn = new KorisnickiNalog(id, vlasnikNaloga, username, password);
            return kn;
        }*/

    }
}

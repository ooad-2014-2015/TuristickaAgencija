using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination
{
    public class KorisnickiNalog
    {
        public int id { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public KorisnickiNalog()
        {
            
        }

        public KorisnickiNalog(int _id, string _userName, string _password)
        {
            id = _id;
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

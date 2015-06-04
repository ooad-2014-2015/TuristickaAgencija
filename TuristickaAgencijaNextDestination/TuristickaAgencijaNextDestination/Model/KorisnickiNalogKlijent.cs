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

        public static List<KorisnickiNalogKlijent> listaKorisnickihNalogaZaBrisanje = new List<KorisnickiNalogKlijent>();

        //Funkcija za brisanje korisnickih naloga

        public static void ObrisiKorisnickiNalog(KorisnickiNalogKlijent nalog)
        {
            for (int i = 0; i < listaKorisnickihNalogaZaBrisanje.Count(); i++)
            {
                if (nalog.username == listaKorisnickihNalogaZaBrisanje[i].username)
                {
                    listaKorisnickihNalogaZaBrisanje.RemoveAt(i);
                }
            }
        }

        public KorisnickiNalogKlijent()
        {

        }

        public KorisnickiNalogKlijent(Klijent _vlasnik, string _username, string _password)
            : base(_username, _password)
        {
            vlasnik = _vlasnik;
        }
     
    }
}

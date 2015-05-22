using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    public class PutovanjaBezIzleta:Putovanje
    {
        int id;

        public int Id1
        {
            get { return id; }
            set { id = value; }
        }

        

        public PutovanjaBezIzleta() { }
        public static List<Putovanje> listaPutovanjaBezIzleta = new List<Putovanje>();

        public static List<Putovanje> listaOdabranihPutovanja = new List<Putovanje>();

        public static void DodajPutovanjeBezIzleta()
        {
            Putovanje p = new Putovanje("Turska", 200, DateTime.Now, DateTime.Now, 12, 40, PrevoznoSredstvo.avion, PutnoOsiguranje.SarajevoOsiguranje, 1);
             Putovanje putovanje1 = new Putovanje("Egipat", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,2);
             Putovanje putovanje2 = new Putovanje("Bugarska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,3);
             Putovanje putovanje3 = new Putovanje("Njemacka", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,4);
             Putovanje putovanje4 = new Putovanje("Svedska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,5);
             Putovanje putovanje5 = new Putovanje("Spanija", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,5);
             listaPutovanjaBezIzleta.Add(p);
             listaPutovanjaBezIzleta.Add(putovanje1);
             listaPutovanjaBezIzleta.Add(putovanje2);
             listaPutovanjaBezIzleta.Add(putovanje3);
             listaPutovanjaBezIzleta.Add(putovanje4);
             listaPutovanjaBezIzleta.Add(putovanje5);

        }
        
        //Ramiza : dodala sam ovaj konstruktor jer mi je tako trebalo 

        public PutovanjaBezIzleta(string destinacija, double cijena, DateTime datumPolaska, DateTime datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id)
            : base(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id) { }
      
        public static List<Putovanje> listaPredlozenihPutovanjaBezIzleta = new List<Putovanje>();
       
       /* public static void DodajPredlozenoPutovanjeBezIzleta()
        {
            Putovanje _putovanje1 = new PutovanjaBezIzleta ("Maldivi", 1350.0, DateTime.Now, DateTime.Now, 15, 30, PrevoznoSredstvo.avion, PutnoOsiguranje.ASAOsiguranje, 22);
            Putovanje _putovanje2 = new PutovanjaBezIzleta ("Pariz", 500.0, DateTime.Now, DateTime.Now, 10, 50, PrevoznoSredstvo.autobus, PutnoOsiguranje.ASAOsiguranje, 33);
            listaPredlozenihPutovanjaBezIzleta.Add(_putovanje1);
            listaPredlozenihPutovanjaBezIzleta.Add(_putovanje2);
        }
        */

        public static int DajMiNaredniID()
        {
            return listaPutovanjaBezIzleta.Count + 1;
        }
        public static void ObrisiPutovanje(int id)
        {
            listaPutovanjaBezIzleta.RemoveAt(id-1);
        }

        public static int dajNaredniIdPredlozeno()
        {
            return listaPredlozenihPutovanjaBezIzleta.Count + 1;
        }
        public static void ObrisiPredlozenoPutovanje(int id)
        {
           listaPredlozenihPutovanjaBezIzleta.RemoveAt(id);
        }

    }
}

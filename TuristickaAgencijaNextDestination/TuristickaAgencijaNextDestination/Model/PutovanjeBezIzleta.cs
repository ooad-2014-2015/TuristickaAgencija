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

           /* Putovanje putovanje1 = new Putovanje(2, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
            Putovanje putovanje2 = new Putovanje(3, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
            Putovanje putovanje3 = new Putovanje(4, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
            Putovanje putovanje4 = new Putovanje(5, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
            Putovanje putovanje5 = new Putovanje(6, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);

            listaPutovanjaBezIzleta.Add(putovanje1);
            listaPutovanjaBezIzleta.Add(putovanje2);
            listaPutovanjaBezIzleta.Add(putovanje3);
            listaPutovanjaBezIzleta.Add(putovanje4);
            listaPutovanjaBezIzleta.Add(putovanje5);*/

        }
        public static int DajMiNaredniID()
        {
            return listaPutovanjaBezIzleta.Count + 1;
        }
        public static void ObrisiPutovanje(int id)
        {
            listaPutovanjaBezIzleta.RemoveAt(id-1);
        }
        public static void ObrisiPredlozenoPutovanje(int id)
        {
           // listaPredlozenihPutovanjaBezIzleta.RemoveAt(id);
        }

    }
}

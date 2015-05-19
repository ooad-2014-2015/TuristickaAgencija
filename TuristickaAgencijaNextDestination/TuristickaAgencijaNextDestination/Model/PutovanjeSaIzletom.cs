using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
   public class PutovanjeSaIzletom:Putovanje
    {
        string izlet;

        public string Izlet
        {
            get { return izlet; }
            set { izlet = value; }
        }
        //static zato da ogu koristiti liste u drugim klasama i to kao PUtovanjaSaIZletom.listaPutovanja
        public static List<Putovanje> listaPutovanja = new List<Putovanje>();

        //public static List<Izleti> listaIzleta = new List<Izleti>();
   
         
       public static void DodajPutovanjaUListu()
         {
             
             Putovanje putovanje1 = new Putovanje(2, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje2 = new Putovanje(3, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje3 = new Putovanje(4, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje4 = new Putovanje(5, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje5 = new Putovanje(6, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             
             listaPutovanja.Add(putovanje1); 
             listaPutovanja.Add(putovanje2);
             listaPutovanja.Add(putovanje3);
             listaPutovanja.Add(putovanje4);
             listaPutovanja.Add(putovanje5);

         }
       public static int DajMiNaredniID()
       {
           return listaPutovanja.Count + 1;
       }
    }
}

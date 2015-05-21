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
        public PutovanjeSaIzletom() { }

       //OVDJE ZELIM DA NAPRAVIM LISTU SA IZLETOM
        public static List<PutovanjeSaIzletom> listaPutovanja = new List<PutovanjeSaIzletom>();
        public static List<PutovanjeSaIzletom> listaOdabranihPutovanja = new List<PutovanjeSaIzletom>();
        //public static List<Izleti> listaIzleta = new List<Izleti>();
   

         
       public static void DodajPutovanjaUListu()
         {
           //OVO JE BILO ZA LISTU BEZ IZLETA 
             
             PutovanjeSaIzletom putovanje1 = new PutovanjeSaIzletom();

            /* Putovanje putovanje2 = new Putovanje(3, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje3 = new Putovanje(4, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje4 = new Putovanje(5, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             Putovanje putovanje5 = new Putovanje(6, "Bosna", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje);
             
             listaPutovanja.Add(putovanje1); 
             listaPutovanja.Add(putovanje2);
             listaPutovanja.Add(putovanje3);
             listaPutovanja.Add(putovanje4);
             listaPutovanja.Add(putovanje5);*/
         //listaPutovanja.Add(new PutovanjeSaIzletom(1,


         }

       //Ramiza : dodala sam ovaj konstruktor jer mi je trebao
       
          public PutovanjeSaIzletom(string destinacija, double cijena, DateTime datumPolaska, DateTime datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id, string izlet)
               : base(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id)
         {
            this.izlet = izlet;
       }

       public static List<Putovanje> _listaPredlozenihPutovanjaSaIzletom = new List<Putovanje>();

  /*     public static void dodajPredlozenoPutovanjeSaIzletom()
       {
           Putovanje _putovanje1 = new PutovanjeSaIzletom("Rim", 500.0, DateTime.Now, DateTime.Now, 10, 50, PrevoznoSredstvo.autobus, PutnoOsiguranje.ASAOsiguranje, 22, "Coloseum");
           Putovanje _putovanje2 = new PutovanjeSaIzletom("Pariz", 600.0, DateTime.Now, DateTime.Now, 10, 50, PrevoznoSredstvo.autobus, PutnoOsiguranje.SarajevoOsiguranje, 23, "Versaj");

           _listaPredlozenihPutovanjaSaIzletom.Add(_putovanje1);
           _listaPredlozenihPutovanjaSaIzletom.Add(_putovanje2);
       }
       */
       public static int DajMiNaredniID()
       {
           return listaPutovanja.Count + 1;
       }
       public static void ObrisiPutovanjeSaIzletom(int id)
       {
           listaPutovanja.RemoveAt(id-1);
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija
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
             
             PutovanjeSaIzletom putovanje10 = new PutovanjeSaIzletom();

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

             PutovanjeSaIzletom p = new PutovanjeSaIzletom("Turska", 200, DateTime.Now, DateTime.Now, 12, 40, PrevoznoSredstvo.avion, PutnoOsiguranje.SarajevoOsiguranje, 1, "Izlet");
             PutovanjeSaIzletom putovanje1 = new PutovanjeSaIzletom("Egipat", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 2, "Izlet");
             PutovanjeSaIzletom putovanje2 = new PutovanjeSaIzletom("Bugarska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 3, "Izlet");
             PutovanjeSaIzletom putovanje3 = new PutovanjeSaIzletom("Njemacka", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 4, "Izlet");
             PutovanjeSaIzletom putovanje4 = new PutovanjeSaIzletom("Svedska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 5, "Izlet");
             PutovanjeSaIzletom putovanje5 = new PutovanjeSaIzletom("Spanija", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 5, "Izlet");
             listaPutovanja.Add(p);
             listaPutovanja.Add(putovanje1);
             listaPutovanja.Add(putovanje2);
             listaPutovanja.Add(putovanje3);
             listaPutovanja.Add(putovanje4);
             listaPutovanja.Add(putovanje5);


         }

       public static string Printaj(int i)
       {
           return listaPutovanja[i].Destinacija + " " + listaPutovanja[i].izlet + " " + listaPutovanja[i].DatumPolaska.Date.ToString("MM/dd/yyyy") + " " + listaPutovanja[i].DatumDolaska.Date.ToString("MM/dd/yyyy") + " " + listaPutovanja[i].Cijena + Environment.NewLine;
       }

       //Ramiza : dodala sam ovaj konstruktor jer mi je trebao
       
          public PutovanjeSaIzletom(string destinacija, double cijena, DateTime datumPolaska, DateTime datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id, string izlet)
               : base(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id)
         {
            this.izlet = izlet;
       }

       public static List<Putovanje> _listaPredlozenihPutovanjaSaIzletom = new List<Putovanje>();

       public static int dajNaredniIdPredlozeno()
       {
           return _listaPredlozenihPutovanjaSaIzletom.Count + 1;
       }

       public static void ObrisiPredlozenoPutovanjeSaIzletom(PutovanjeSaIzletom p)
       {
           for (int i = 0; i < _listaPredlozenihPutovanjaSaIzletom.Count(); i++)
           {
               if (_listaPredlozenihPutovanjaSaIzletom[i].Id == p.Id)
               {
                   _listaPredlozenihPutovanjaSaIzletom.RemoveAt(i);
                   break;
               }
           }
              
       }

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
       public static void ObrisiPutovanjeSaIzletom(PutovanjeSaIzletom p)
       {
           for (int i = 0; i < listaPutovanja.Count(); i++)
           {
               if (p.Id == listaPutovanja[i].Id)
               {
                   listaPutovanja.RemoveAt(i);
                   break;
               }
           }
       }
    }
}

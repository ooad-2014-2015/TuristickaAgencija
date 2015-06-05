using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TuristickaAgencijaNextDestination.Model
{
   public class PutovanjeSaIzletom:Putovanje
    {
        public int id { get; set; }

        string izlet;

        public string Izlet
        {
            get { return izlet; }
            set { izlet = value; }
        }
        //static zato da ogu koristiti liste u drugim klasama i to kao PUtovanjaSaIZletom.listaPutovanja
        public PutovanjeSaIzletom() { }

       //OVDJE ZELIM DA NAPRAVIM LISTU SA IZLETOM
        public static List<PutovanjeSaIzletom> listaPutovanjaSaIzletom = new List<PutovanjeSaIzletom>();
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

       public PutovanjeSaIzletom(string _destinacija, double _cijena, string _datumPolaska, string _datumDolaska, int _trajanjePutovanja, int _brojSlobodnihMjesta, string _prevoznoSredstvo, string _putnoOsiguranje, int _id, string _izlet)
        {
            Destinacija = _destinacija;
            Cijena = _cijena;
            DatumDolaska = Convert.ToDateTime(_datumDolaska);
            DatumPolaska = Convert.ToDateTime(_datumPolaska);
            TrajanjePutovanja = _trajanjePutovanja;
            BrojSlobodnihMjesta = _brojSlobodnihMjesta;
            if (_prevoznoSredstvo == "avion") PrevoznoSredstvo = PrevoznoSredstvo.avion;
            else if (_prevoznoSredstvo == "brod") PrevoznoSredstvo = PrevoznoSredstvo.brod;
            else if (_prevoznoSredstvo == "autobus") PrevoznoSredstvo = PrevoznoSredstvo.autobus;
            else PrevoznoSredstvo = PrevoznoSredstvo.voz;

            if (_putnoOsiguranje == "SarajevoOsiguranje") PutnoOsiguranje = PutnoOsiguranje.SarajevoOsiguranje;
            else if (_putnoOsiguranje == "TriglavOsiguranje") PutnoOsiguranje = PutnoOsiguranje.TriglavOsiguranje;
            else if (_putnoOsiguranje == "SunceOsiguranje") PutnoOsiguranje = PutnoOsiguranje.SunceOsiguranje;
            else PutnoOsiguranje = PutnoOsiguranje.ASAOsiguranje;

            id = _id;
            izlet = _izlet;

        }

       // unos putovanja sa izletom u bazu
       public static void upisPutovanjaSaIzletomUBazu(string destinacija, double cijena, string datumPolaska, string datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id, string izlet)
       {
           string username = "root";
           string password = "";
           string db = "turistickaagencija";

           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection msc = new MySqlConnection(connectionString);
           msc.Open();

           MySqlCommand insertUpit = new MySqlCommand("insert into putovanjasaizletom(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id, izlet) values ('" + destinacija + "','" + cijena + "','" + datumPolaska + "','" + datumDolaska + "','" + trajanjePutovanja + "','" + brojSlobodnihMjesta + "','" + prevoznoSredstvo.ToString() + "','" + putnoOsiguranje.ToString() + "','" + id + "','" + izlet + "')", msc);

           insertUpit.ExecuteNonQuery();

           msc.Close();

       }

       public static void ucitajPutovanjaSaIzletomUListu()
       {
           Model.PutovanjeSaIzletom.listaPutovanjaSaIzletom.Clear();

           string username = "root";
           string password = "";
           string db = "turistickaagencija";
           //Konekcija na bazu 
           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection con = new MySqlConnection(connectionString);
           con.Open();

           MySqlCommand upitKomanda = new MySqlCommand("select * from putovanjasaizletom", con);
           MySqlDataReader r = upitKomanda.ExecuteReader();
           while (r.Read())
           {
               Model.PutovanjeSaIzletom.listaPutovanjaSaIzletom.Add(new PutovanjeSaIzletom(r.GetString("destinacija"),
                   r.GetDouble("cijena"), r.GetString("datumPolaska"), r.GetString("datumDolaska"),
                   r.GetInt32("trajanjePutovanja"), r.GetInt32("brojSlobodnihMjesta"),
                   r.GetString("prevoznoSredstvo"), r.GetString("putnoOsiguranje"), 
                   r.GetInt32("id"), r.GetString("izlet")));
           }
           con.Close();
       }

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
           return listaPutovanjaSaIzletom.Count + 1;
       }
       public static void ObrisiPutovanjeSaIzletom(PutovanjeSaIzletom p)
       {
           for (int i = 0; i < listaPutovanjaSaIzletom.Count(); i++)
           {
               if (p.Id == listaPutovanjaSaIzletom[i].Id)
               {
                   listaPutovanjaSaIzletom.RemoveAt(i);
                   break;
               }
           }
           Model.PutovanjeSaIzletom.obrisiPutovanjeSaIzletomIzBaze(p.Destinacija);

       }

       // rad sa bazom za predlozena putovanja sa izletom
       public static void upisPredlozenogPutovanjaSaIzletomUBazu(string destinacija, double cijena,
           string datumPolaska, string datumDolaska, int trajanjePutovanja,
           int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo,
           PutnoOsiguranje putnoOsiguranje, int id, string izlet)
       {
           string username = "root";
           string password = "";
           string db = "turistickaagencija";

           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection msc = new MySqlConnection(connectionString);
           msc.Open();

           MySqlCommand insertUpit = new MySqlCommand("insert into predlozenaputovanjasaizletom(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id, izlet) values ('"
               + destinacija + "','" + cijena + "','" + datumPolaska + "','" + datumDolaska + "','"
               + trajanjePutovanja + "','" + brojSlobodnihMjesta + "','" + prevoznoSredstvo.ToString()
               + "','" + putnoOsiguranje.ToString() + "','" + id + "','" + izlet + "')", msc);

           insertUpit.ExecuteNonQuery();

           msc.Close();

       }

       public static void ucitajPredlozenoPutovanjeSaIzletomUListu()
       {
           Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom.Clear();

           string username = "root";
           string password = "";
           string db = "turistickaagencija";
           //Konekcija na bazu 
           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection con = new MySqlConnection(connectionString);
           con.Open();

           MySqlCommand upitKomanda = new MySqlCommand("select * from predlozenaputovanjasaizletom", con);
           MySqlDataReader r = upitKomanda.ExecuteReader();
           while (r.Read())
           {
               Model.PutovanjeSaIzletom._listaPredlozenihPutovanjaSaIzletom.Add(new PutovanjeSaIzletom(r.GetString("destinacija"),
                   r.GetDouble("cijena"), r.GetString("datumPolaska"), r.GetString("datumDolaska"),
                   r.GetInt32("trajanjePutovanja"), r.GetInt32("brojSlobodnihMjesta"),
                   r.GetString("prevoznoSredstvo"), r.GetString("putnoOsiguranje"), r.GetInt32("id"),
                   r.GetString("izlet")));
           }
           con.Close();
       }

       public static void obrisiPredlozenoPutovanjeSaIzletomIzBaze(string _destinacija)
       {
           string username = "root";
           string password = "";
           string db = "turistickaagencija";
           //Konekcija na bazu 
           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection con = new MySqlConnection(connectionString);
           con.Open();

           MySqlCommand upitKomanda = new MySqlCommand("delete from predlozenaputovanjasaizletom where destinacija=" + _destinacija, con);
           MySqlDataReader r = upitKomanda.ExecuteReader();

           con.Close();
       }

       public static void obrisiPutovanjeSaIzletomIzBaze(string _destinacija)
       {
           string username = "root";
           string password = "";
           string db = "turistickaagencija";
           //Konekcija na bazu 
           string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
           MySqlConnection con = new MySqlConnection(connectionString);
           con.Open();

           MySqlCommand upitKomanda = new MySqlCommand("delete from predlozenaputovanjabezizleta where destinacija=" + _destinacija.ToString(), con);

           MySqlDataReader r = upitKomanda.ExecuteReader();

           con.Close();
       }

    }
}

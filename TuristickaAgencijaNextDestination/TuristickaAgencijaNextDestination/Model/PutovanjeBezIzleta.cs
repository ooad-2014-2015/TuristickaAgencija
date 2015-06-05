using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public static List<Putovanje> listaPredlozenihPutovanjaBezIzleta = new List<Putovanje>();


        public static void DodajPutovanjeBezIzleta()
        {
            // kad nije bilo baze
            //Putovanje p = new Putovanje("Turska", 200, DateTime.Now, DateTime.Now, 12, 40, PrevoznoSredstvo.avion, PutnoOsiguranje.SarajevoOsiguranje, 1);
            // Putovanje putovanje1 = new Putovanje("Egipat", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,2);
            // Putovanje putovanje2 = new Putovanje("Bugarska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,3);
            // Putovanje putovanje3 = new Putovanje("Njemacka", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,4);
            // Putovanje putovanje4 = new Putovanje("Svedska", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,5);
            // Putovanje putovanje5 = new Putovanje("Spanija", 10, DateTime.Now, DateTime.Now, 2, 4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje,5);
            // listaPutovanjaBezIzleta.Add(p);
            // listaPutovanjaBezIzleta.Add(putovanje1);
            // listaPutovanjaBezIzleta.Add(putovanje2);
            // listaPutovanjaBezIzleta.Add(putovanje3);
            // listaPutovanjaBezIzleta.Add(putovanje4);
            // listaPutovanjaBezIzleta.Add(putovanje5);

            DateTime date1 = new DateTime(2015, 6, 1);
            DateTime date2 = new DateTime(2015, 7, 1);
            DateTime date3 = new DateTime(2015, 9, 1);
            DateTime date4 = new DateTime(2015, 9, 15);
            DateTime date5 = new DateTime(2015, 10, 11);
            DateTime date6 = new DateTime(2015, 10, 21);
            DateTime date7 = new DateTime(2015, 10, 5);
            DateTime date8 = new DateTime(2015, 10, 10);
            DateTime date9 = new DateTime(2015, 12, 11);
            DateTime date10 = new DateTime(2015, 12, 14);
            DateTime date11 = new DateTime(2015, 8, 11);
            DateTime date12 = new DateTime(2015, 8, 20);

            upisPutovanjaBezIzletaUBazu("Turska", 200, date1.ToString(), date2.ToString(), 
                Convert.ToInt32((date2 - date1).TotalDays), 40, PrevoznoSredstvo.avion, 
                PutnoOsiguranje.SarajevoOsiguranje, 1);

            upisPutovanjaBezIzletaUBazu("Egipat", 10, date3.ToString(), date4.ToString(),
                Convert.ToInt32((date4 - date3).TotalDays), 
                4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 2);

            upisPutovanjaBezIzletaUBazu("Bugarska", 10, date5.ToString(), date6.ToString(),
                Convert.ToInt32((date6 - date5).TotalDays), 
                4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 3);

            upisPutovanjaBezIzletaUBazu("Njemacka", 10, date7.ToString(), date8.ToString(),
                Convert.ToInt32((date8 - date7).TotalDays),
                4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 4);

            upisPutovanjaBezIzletaUBazu("Svedska", 10, date9.ToString(), date10.ToString(),
                Convert.ToInt32((date10 - date9).TotalDays), 
                4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 5);

            upisPutovanjaBezIzletaUBazu("Spanija", 10, date11.ToString(), date12.ToString(),
                Convert.ToInt32((date12 - date11).TotalDays), 
                4, PrevoznoSredstvo.autobus, PutnoOsiguranje.TriglavOsiguranje, 5);

        }

        public PutovanjaBezIzleta(string _destinacija, double _cijena, DateTime _datumPolaska, DateTime _datumDolaska, int _trajanjePutovanja, int _brojSlobodnihMjesta, string _prevoznoSredstvo, string _putnoOsiguranje, int _id)
        {
            Destinacija = _destinacija;
            Cijena = _cijena;
            DatumDolaska = _datumDolaska;
            DatumPolaska = _datumPolaska;
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

        }

        public PutovanjaBezIzleta(string _destinacija, double _cijena, string _datumPolaska, string _datumDolaska, int _trajanjePutovanja, int _brojSlobodnihMjesta, string _prevoznoSredstvo, string _putnoOsiguranje, int _id)
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

        }

        // unos putovanja bez izleta u bazu
        public static void upisPutovanjaBezIzletaUBazu(string destinacija, double cijena, string datumPolaska, string datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id)
        {
            string username = "root";
            string password = "";
            string db = "turistickaagencija";

            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            MySqlConnection msc = new MySqlConnection(connectionString);
            msc.Open();

            MySqlCommand insertUpit = new MySqlCommand("insert into putovanjabezizleta(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id) values ('" + destinacija + "','" + cijena + "','" + datumPolaska + "','" + datumDolaska + "','" + trajanjePutovanja + "','" + brojSlobodnihMjesta + "','" + prevoznoSredstvo.ToString() + "','" + putnoOsiguranje.ToString() + "','" + id +"')", msc);

            insertUpit.ExecuteNonQuery();

            msc.Close();

        }

        public static void ucitajPutovanjaBezIzletaUListu()
        {
            Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Clear();

            string username = "root";
            string password = "";
            string db = "turistickaagencija";
            //Konekcija na bazu 
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand upitKomanda = new MySqlCommand("select * from putovanjabezizleta", con);
            MySqlDataReader r = upitKomanda.ExecuteReader();
            while (r.Read())
            {
                Model.PutovanjaBezIzleta.listaPutovanjaBezIzleta.Add(new PutovanjaBezIzleta(r.GetString("destinacija"), 
                    r.GetDouble("cijena"), r.GetString("datumPolaska"), r.GetString("datumDolaska"),
                    r.GetInt32("trajanjePutovanja"), r.GetInt32("brojSlobodnihMjesta"), 
                    r.GetString("prevoznoSredstvo"), r.GetString("putnoOsiguranje"), r.GetInt32("id")));
            }
            con.Close();
        }
        
        //Ramiza : dodala sam ovaj konstruktor jer mi je tako trebalo 

        public PutovanjaBezIzleta(string destinacija, double cijena, DateTime datumPolaska, DateTime datumDolaska, int trajanjePutovanja, int brojSlobodnihMjesta, PrevoznoSredstvo prevoznoSredstvo, PutnoOsiguranje putnoOsiguranje, int id)
            : base(destinacija, cijena, datumPolaska, datumDolaska, trajanjePutovanja, brojSlobodnihMjesta, prevoznoSredstvo, putnoOsiguranje, id) { }
      
       
       
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
        public static void ObrisiPutovanje(PutovanjaBezIzleta pbi)
        {
            
            for (int i = 0; i < listaPutovanjaBezIzleta.Count(); i++)
            {
                if (pbi.id == listaPutovanjaBezIzleta[i].Id)
                {
                    listaPutovanjaBezIzleta.RemoveAt(i);
                    break;
                }
            }     
        }

        public static int dajNaredniIdPredlozeno()
        {
            return listaPredlozenihPutovanjaBezIzleta.Count + 1;
        }
        public static void ObrisiPredlozenoPutovanje(PutovanjaBezIzleta p)
        {
            for (int i = 0; i < listaPredlozenihPutovanjaBezIzleta.Count(); i++)
            {
                if (listaPredlozenihPutovanjaBezIzleta[i].Id == p.id)
                {
                    listaPredlozenihPutovanjaBezIzleta.RemoveAt(i);
                    break;
                }
            }
               
        }
        public static void ObrisiPutovanje1(Putovanje p)
        {
            for(int i=0;i<listaPutovanjaBezIzleta.Count();i++)
            {
                if(p.Id==listaPutovanjaBezIzleta[i].Id)
                {
                    listaPutovanjaBezIzleta.RemoveAt(i);
                    break;
                }
            }
        }

    }
}

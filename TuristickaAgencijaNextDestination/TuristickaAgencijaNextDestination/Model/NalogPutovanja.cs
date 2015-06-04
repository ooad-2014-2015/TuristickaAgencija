using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    class NalogPutovanja : iRacun
    {
        private int _id;
        private Klijent _klijent;
        private decimal _cijena;
        private Putovanje _putovanje;
        public  static decimal _popust = 0.2M;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Klijent Klijent
        {
            get { return _klijent; }
            set { _klijent = value; }
        }

        public decimal Cijena
        {
            get { return _cijena; }
            set { _cijena = value; }
        }


        public Putovanje Putovanje
        {
            get { return _putovanje; }
            set { _putovanje = value; }
        }


        public NalogPutovanja(int id, decimal cijena, decimal popust)
        {
            _id = id;
            _cijena = cijena;
            _popust = popust;
            
        }

       // public override decimal generisiRacun()


        public static double ObracunajPopust(double cijena)
        {
            if (Convert.ToBoolean(StatusKlijenta.student) == true || Convert.ToBoolean(StatusKlijenta.penzioner) == true)
            {
                return (cijena = cijena + cijena * 0.1);
            }
            else
                return cijena;
        }
    }
}

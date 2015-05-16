using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    class NalogPutovanja : iRacun
    {
        public int _id { get; set; }

        public Klijent _klijent { get; set; }

        public decimal _cijena { get; set; }

        public Putovanje _putovanje { get; set; }

        public decimal _popust { get; set; }

        public NalogPutovanja(int id, decimal cijena, decimal popust)
        {
            _id = id;
            _cijena = cijena;
            _popust = popust;
        }

        //public decimal obracunajPopust(); 

       // public override decimal generisiRacun()

      //  public string posaljiObavijest();

      //  public Boolean otkaziPutovanje();

    }
}

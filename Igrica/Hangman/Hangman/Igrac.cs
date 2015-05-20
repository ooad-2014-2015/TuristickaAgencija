using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Igrac
    {
        public String ime { get; set; }
        public int brojBodova { get; set; }
        public int brojGresaka { get; set; }

        public Igrac()
        {
                
        }

        public Igrac(String _ime, int _brojGresaka)
        {
            ime = _ime;
            brojGresaka = _brojGresaka;
            brojBodova = izracunajBrojBodova(_brojGresaka);
        }

        public int izracunajBrojBodova(int brojGreski)
        {
            return 30-brojGreski*5;
        }

        public override string ToString()
        {
            return ime + "                              " + brojBodova.ToString();
        }

    }
}

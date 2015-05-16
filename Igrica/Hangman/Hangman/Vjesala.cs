using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Vjesala
    {
        private IOblast oblast;
        private ITezinaIgre tezinaIgre;
        public Igrac igrac { get; set; }
        public int brojacNepogodjenihSlova { get; set; }

        public Vjesala()
        {

        }

        public Vjesala(IOblast _oblast, ITezinaIgre _tezinaIgre)
        {
            oblast = _oblast;
            tezinaIgre = _tezinaIgre;
            brojacNepogodjenihSlova = 0;
        }

        public void Oblast(string _oblast)
        {
            oblast.Oblast(_oblast);
        }

        public void TezinaIgre(string _tezina)
        {
            tezinaIgre.TezinaIgre(_tezina);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    class Noppa
    {
        
        public static Random SatunnainenLuku = new Random();
        public double Lukema { get; set; } // Nopan tulos 1-6
        public int HeittoLkm { get; set; } // Heittojen määrä
        public Noppa(int heittolkm = 0) // Konstruktori
        {
            HeittoLkm = heittolkm;

        }

        public double Heita() // Arpoo luvun Lukemalle, kasvattaa heittojen määrää yhdellä. Palauttaa Lukema arvon
        {
            Lukema = SatunnainenLuku.Next(1, 7);
            HeittoLkm = HeittoLkm + 1;
            return Lukema;
        }

    }
}

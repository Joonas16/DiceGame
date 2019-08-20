using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    class Pelaaja : INimi
    {
        private string _nimi;
        public string Nimi { get; set; }
        public int Pisteet { get; set; }
        public Pelaaja(string nimi)
        {
            _nimi = nimi;
            Pisteet = 0;
        }
        public string getNimi()
        {
            return _nimi;
        }
        public override string ToString()
        {
            return $"{Nimi}";
        }
    }
}

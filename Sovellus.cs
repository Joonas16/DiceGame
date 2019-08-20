using System;
using static System.Console;

namespace NoppaPeli
{
    public static class Sovellus
    {
        public static int VOITONPISTERAJA = 3;
        public static void Aja()
        {
            WriteLine("Noppa-peli");

            Pelaaja yksi = new Pelaaja(Helpers.Syote.Merkkijono("Pelaajan 1 nimi: "));
            Pelaaja kaksi = new Pelaaja(Helpers.Syote.Merkkijono("Pelaajan 2 nimi: "));

            Noppa eka = new Noppa();
            Noppa toka = new Noppa();

            int heittokierros = 1;
            double pelaaja1tulos;
            double pelaaja2tulos;

            do
            {
                WriteLine($"Heittokierros {heittokierros}");
                WriteLine($"{yksi.getNimi()}: {eka.Heita()} + {toka.Heita()} = {eka.Lukema + toka.Lukema}");
                pelaaja1tulos = eka.Lukema + toka.Lukema;
                WriteLine($"{kaksi.getNimi()}: {eka.Heita()} + {toka.Heita()} = {eka.Lukema + toka.Lukema}");
                pelaaja2tulos = eka.Lukema + toka.Lukema;
                heittokierros++;
                ReadKey();

                if (pelaaja1tulos == pelaaja2tulos)
                {
                    yksi.Pisteet = yksi.Pisteet;
                    kaksi.Pisteet = kaksi.Pisteet;
                }
                else if (pelaaja1tulos > pelaaja2tulos)
                {
                    yksi.Pisteet++;
                    kaksi.Pisteet = 0;
                }
                else
                {
                    kaksi.Pisteet++;
                    yksi.Pisteet = 0;
                }

            } while (VOITONPISTERAJA > yksi.Pisteet && VOITONPISTERAJA > kaksi.Pisteet);


            WriteLine();
            if (yksi.Pisteet > kaksi.Pisteet)
            {
                WriteLine($"Pelin voittaja on {yksi.getNimi()} ja noppia heitettiin {eka.HeittoLkm / 2} kertaa!");
            }
            else
            {
                WriteLine($"Pelin voittaja on {kaksi.getNimi()} ja noppia heitettiin {toka.HeittoLkm / 2} kertaa!");
            }


        }
    }
}

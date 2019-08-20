using System;
using static System.Console;

namespace NoppaPeli
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Sovellus.Aja();
            }
            catch (Exception e)
            {

                WriteLine("Ohjelman suoritus päätty virheeseen");
                WriteLine($"Virhe: {e.Message}");
            }
            finally
            {
                WriteLine();
                Write("Paina Enter lopettaaksesi...");
                ReadLine();
            }

        }
    }
}

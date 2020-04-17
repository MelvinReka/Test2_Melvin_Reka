using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// konvertierung in Zahlensysteme
namespace Test2_Melvin_Reka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Titel("Dies ist ein Test",ConsoleColor.Red);
            string binzahl = Binaerzahleinlesen();
            Console.ReadKey();
        }
        static void Titel(string titel, ConsoleColor textfarbe)
        {
            
            int breite = Console.WindowWidth;
            int textlen = titel.Length;
            ConsoleColor aktTextFarbe = Console.ForegroundColor;

            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (breite-textlen/2); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            
        }
        /// <summary>
        /// Einlesen einer Binärzahl
        /// </summary>
        /// <returns>String mit nur Nullen und Einsen</returns>
        static string Binaerzahleinlesen()
        {
            Console.WriteLine("Bitte Binärzahl eingeben (0/1): ");
            string input = Console.ReadLine();
            return input;
        }
    }
}

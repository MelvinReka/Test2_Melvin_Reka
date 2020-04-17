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
            Titel("Dies ist ein Test");
            Menu();
            Console.ReadKey();
        }

        static void Titel(string titel)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
        /// <summary>
        /// Ausgabe eines Auswahmenüs
        /// </summary>
        static void Menu()
        {
            Console.WriteLine("1) 10->2");
            Console.WriteLine("2) 10-> Hex");
            Console.WriteLine("\n Bitte einen Menüpunkt auswählen");
        }
    }
}

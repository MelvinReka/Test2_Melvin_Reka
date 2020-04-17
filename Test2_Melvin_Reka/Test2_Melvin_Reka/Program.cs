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
    }
}

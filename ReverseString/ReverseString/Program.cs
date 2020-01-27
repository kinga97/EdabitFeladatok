using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse the Order of a String
            Console.Write("Kérem a sztringet: ");
            string bemeno = Console.ReadLine();
            Szoveg szov = new Szoveg(bemeno);

            Console.WriteLine($"A megfordított sztring: {Megfordit(bemeno)}");
            Console.WriteLine($"A megfordított sztring: {szov.Megfordit()}");

            Console.ReadKey(true);
        }

        static string Megfordit(string bemeno)
        {
            string kimeno = "";

            for (int i = bemeno.Length - 1; i >= 0; i--)
            {
                kimeno = String.Concat(kimeno, bemeno[i]);
            }
            return kimeno;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phone Number Formatting

            Random rnd = new Random();
            int[] tomb = new int[10];
            // Telefonszam tel = new Telefonszam(tomb); - itt is működik!
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(10);
            }

            Telefonszam tel = new Telefonszam(tomb);
            Console.WriteLine($"A véletlen telefonszám: {Telefonszam(tomb)}");
            Console.WriteLine($"A véletlen telefonszám: {tel.TelefonszamSzamito()}");

            Console.ReadKey(true);
        }

        static string Telefonszam(int[] tomb)
        {
            string kimeno = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                kimeno = String.Concat(kimeno, tomb[i]);
            }

            kimeno = String.Concat("(", kimeno.Substring(0, 3), ") ", kimeno.Substring(3, 3), "-", kimeno.Substring(6));

            return kimeno;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove the First and Last Characters

            Console.Write("Kérem a sztringet: ");
            string bemeno = Console.ReadLine();
            Szoveg szoveg = new Szoveg(bemeno);
            Console.WriteLine($"A csonkolt sztring: {Remove_1(bemeno)}");
            Console.WriteLine($"A csonkolt sztring: {Remove_2(bemeno)}");
            Console.WriteLine($"A csonkolt sztring: {szoveg.Remove_1()}");
            Console.WriteLine($"A csonkolt sztring: {szoveg.Remove_2()}");



            Console.ReadKey(true);
        }

        static string Remove_1(string bemeno)
        {
            if (bemeno.Length <= 2)
            {
                return bemeno;
            }
            else
            {
                return bemeno.Remove(bemeno.Length - 1, 1).Remove(0, 1);
                //return bemeno.Remove(0, 1).Remove(bemeno.Length - 2, 1);
            }
        }

        static string Remove_2(string bemeno)
        {
            if (bemeno.Length <= 2)
            {
                return bemeno;
            }
            else
            {
                return bemeno.Substring(1, bemeno.Length - 2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
        }

        public string Megfordit()
        {
            string kimeno = "";

            for (int i = this.Bemeno.Length - 1; i >= 0; i--)
            {
                kimeno = String.Concat(kimeno, this.Bemeno[i]);
            }
            return kimeno;
        }
    }
}

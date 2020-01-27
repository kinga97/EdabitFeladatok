using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimes
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public int Hanyszor { get; set; }

        public Szoveg(string bemeno, int hanyszor)
        {
            this.Bemeno = bemeno;
            this.Hanyszor = hanyszor;
        }

        public string Ismetel()
        {
            string kimeno = "";
            if (this.Bemeno.Length <= 0)
            {
                return kimeno = "Üres sztringgel nem tudok dolgozni.";
            }
            else
            {
                for (int i = 0; i < this.Bemeno.Length; i++)
                {
                    for (int j = 0; j < this.Hanyszor; j++)
                    {
                        kimeno = String.Concat(kimeno, this.Bemeno[i]);
                    }
                }
                return kimeno;
            }
        }

    }
}

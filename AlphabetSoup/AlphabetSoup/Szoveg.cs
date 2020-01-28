using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSoup
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
        }

        public string Sorrendbe_2()
        {
            string kimeno = "ß";

            for (int i = 0; i < this.Bemeno.Length; i++)
            {
                Betuk be;
                Enum.TryParse(this.Bemeno[i].ToString(), true, out be);
                for (int j = 0; j < kimeno.Length; j++)
                {
                    Betuk ki;
                    Enum.TryParse(kimeno[j].ToString(), true, out ki);
                    if ((int)be < (int)ki)
                    {
                        kimeno = String.Concat(kimeno.Substring(0, j), this.Bemeno[i], kimeno.Substring(j));
                        break;
                    }

                }
            }

            return kimeno.Substring(0, this.Bemeno.Length);
        }

    }
}

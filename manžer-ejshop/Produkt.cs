using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manžer_ejshop
{
    internal class Produkt
    {
        public double cena {  get; set; }
        public string nazev { get; set; }
        public int mnozstvi { get; set; }

        public Produkt(double cena, string nazev, int mnozstvi)
        {
            this.cena = cena;
            this.nazev = nazev;
            this.mnozstvi = mnozstvi;
        }

    }
}

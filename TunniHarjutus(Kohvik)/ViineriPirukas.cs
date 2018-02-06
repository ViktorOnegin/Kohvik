using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class ViineriPirukas : Söögid
    {
        public ViineriPirukas()
        {
            Name = "ViineriPirukas";
            Price = 0.94f;
            PriceName = "eurot";
        }

        public float Buy(float Money)
        {
            Console.WriteLine(" Sina ostsid viineripiruka ");
            Console.WriteLine(" See maksis " + Price + PriceName);
            var yourMoney = Money - Price;
            Console.WriteLine(" Sul on alles " + yourMoney + PriceName);
            return Money - Price;
        }
    }
}

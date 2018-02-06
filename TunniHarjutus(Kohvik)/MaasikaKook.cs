using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class MaasikaKook : Söögid
    {
        public MaasikaKook()
        {
            Name = "MaasikaKook";
            Price = 1.40f;
            PriceName = "eurot";
        }

        public float Buy(float Money)
        {
            Console.WriteLine(" Sina ostsid maasikakooki ");
            Console.WriteLine(" See maksis " + Price + PriceName);
            var yourMoney = Money - Price;
            Console.WriteLine(" Sul on alles " + yourMoney + PriceName);
            return Money - Price;
        }
    }
}

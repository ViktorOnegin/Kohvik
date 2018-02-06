using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class Latte : Joogid
    {
        public Latte()
        {
            Name = "Latte";
            Price1 = 2.25f;
            Size1 = "S";

            Price2 = 3.12f;
            Size2 = "M";

            Price3 = 4.98f;
            Size3 = "L";

            PriceName = "eurot";
        }

        public float Buy1(float Money)
        {
            Console.WriteLine(" Sina ostsid latte suuruses " + Size1);
            Console.WriteLine(" See maksis " + Price1 + PriceName);
            var yourMoney = Money - Price1;
            Console.WriteLine(" Sul on alles " + yourMoney + PriceName);
            return Money - Price1;
        }

        public float Buy2(float Money)
        {
            Console.WriteLine(" Sina ostsid latte suuruses " + Size2);
            Console.WriteLine(" See maksis " + Price2 + PriceName);
            var yourMoney = Money - Price2;
            Console.WriteLine(" Sul on alles " + yourMoney + PriceName);
            return Money - Price2;
        }

        public float Buy3(float Money)
        {
            Console.WriteLine(" Sina ostsid latte suuruses " + Size3);
            Console.WriteLine(" See maksis " + Price3 + PriceName);
            var yourMoney = Money - Price3;
            Console.WriteLine(" Sul on alles " + yourMoney + PriceName);
            return Money - Price3;
        }
    }
}

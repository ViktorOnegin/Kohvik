using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunniHarjutus_Kohvik_
{
    class Program 
    {
        static void Main(string[] args)
        {
            var Money = 20.0f;

            Console.WriteLine(" There tulemast kohvikusse 'Red Rocked'! ");
            Console.WriteLine(" Mida te tahate osta ? ");

            Console.WriteLine(" 1 = mustkohv ");
            Console.WriteLine(" 2 = latte ");
            Console.WriteLine(" 3 = viineripirukas ");
            Console.WriteLine(" 4 = maasikakook ");
            Console.WriteLine(" 5 = Ostu lõpetamine");

            Algus: 
            
            String input = Console.ReadLine();
            int Valikud;
            if (int.TryParse(input, out Valikud))
            {
                switch (Valikud)
                {
                    case 1:
                        goto Suurused1;


                    case 2:
                        goto Suurused2;


                    case 3:
                        var Pirukas = new ViineriPirukas();
                        Money = Pirukas.Buy(Money);
                        Console.WriteLine("Kas te soovite midagi veel?");
                        goto Algus;


                    case 4:
                        var kook = new MaasikaKook();
                        Money = kook.Buy(Money);
                        Console.WriteLine("Kas te soovite midagi veel?");
                        goto Algus;


                    case 5:
                        goto Lõpp;

                    default:
                        Console.WriteLine("Vale number ,Proovige uuesti!");
                        goto Algus;
                }

                Suurused1:

                Console.WriteLine("Mis suurust te tahate");
                Console.WriteLine("1 = S");
                Console.WriteLine("2 = M");
                Console.WriteLine("3 = L");

                String input1 = Console.ReadLine();
                int Suurused1;
                if (int.TryParse(input1, out Suurused1))
                {
                    switch (Suurused1)
                    {
                        case 1:
                            var Kohv1 = new MustKohv();
                            Money = Kohv1.Buy1(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        case 2:
                            var Kohv2 = new MustKohv();
                            Money = Kohv2.Buy2(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        case 3:
                            var Kohv3 = new MustKohv();
                            Money = Kohv3.Buy3(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        default:
                            Console.WriteLine("Vale number ,Proovige uuesti!");
                            goto Suurused1;
                    }
                }

                Suurused2:

                Console.WriteLine("Mis suurust te tahate");
                Console.WriteLine("1 = S");
                Console.WriteLine("2 = M");
                Console.WriteLine("3 = L");

                String input2 = Console.ReadLine();
                int Suurused2;
                if (int.TryParse(input2, out Suurused2))
                {
                    switch (Suurused2)
                    {
                        case 1:
                            var kohv1 = new Latte();
                            Money = kohv1.Buy1(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        case 2:
                            var kohv2 = new Latte();
                            Money = kohv2.Buy2(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        case 3:
                            var kohv3 = new Latte();
                            Money = kohv3.Buy3(Money);
                            Console.WriteLine("Kas te soovite midagi veel?");
                            goto Algus;

                        default:
                            Console.WriteLine("Vale number ,Proovige uuesti!");
                            goto Suurused2;

                    }
                }

                Lõpp:

                Console.WriteLine("Täname teid ostu eest");
                Console.ReadLine();
            }  
        }
    }
}

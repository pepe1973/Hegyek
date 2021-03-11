using System;
using System.Collections.Generic;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class HatodikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            Console.Write("6. Feladat: Kérek egy magasságot: ");
            int bekertMagassag = Convert.ToInt32(Console.ReadLine());
            bool vanE = false;

            foreach (Hegy elem in lista)
            {
                if (elem.Hegyseg == "Börzsöny" && elem.Magassag > bekertMagassag)
                {
                    vanE = true;
                    break;
                }
            }

            if (vanE)
            {
                Console.WriteLine($"\tVan {bekertMagassag}m-nél magasabb hegycsúcs a Börzsönyben.");
            }
            else
            {
                Console.WriteLine($"\tNincs {bekertMagassag}m-nél magasabb hegycsúcs a Börzsönyben.");
            }
        }
    }
}

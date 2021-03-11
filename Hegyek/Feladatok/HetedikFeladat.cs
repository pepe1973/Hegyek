using System;
using System.Collections.Generic;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class HetedikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            int darab = 0;
            double haromEzer = 3000 / 3.280839895;

            foreach (Hegy elem in lista)
            {
                if (elem.Magassag > haromEzer)
                {
                    darab++;
                }
            }

            Console.WriteLine($"7. Feladat: 3000 lábnál magasabb hegycsúcsok száma: {darab}");
        }
    }
}

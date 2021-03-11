using System;
using System.Collections.Generic;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class NyolcadikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            Dictionary<string, int> konyvtar = new Dictionary<string, int>();
            
            foreach (Hegy elem in lista)
            {
                bool vanE = true;

                foreach (KeyValuePair<string, int> item in konyvtar)
                {
                    if (elem.Hegyseg == item.Key)
                    {
                        vanE = false;
                        int adat = item.Value;
                        konyvtar.Remove(item.Key);
                        konyvtar.Add(elem.Hegyseg, ++adat);
                        break;
                    }
                }

                if (vanE)
                {
                    konyvtar.Add(elem.Hegyseg, 1);
                }
            }

            Console.WriteLine("8. Feladat: Hegység statisztika");

            foreach (KeyValuePair<string, int> elem in konyvtar)
            {
                Console.WriteLine($"\t{elem.Key} - {elem.Value} db");
            }
        }
    }
}

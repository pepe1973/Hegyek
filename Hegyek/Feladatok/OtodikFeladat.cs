using System;
using System.Collections.Generic;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class OtodikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            Hegy legmagasabbHegy = new Hegy();
            int legmagasabb = 0;

            foreach (Hegy elem in lista)
            {
                if (elem.Magassag > legmagasabb)
                {
                    legmagasabb = elem.Magassag;
                    legmagasabbHegy = elem;
                }
            }

            Console.WriteLine($"5. Feladat: A legmagasabb hegycsúcs adatai:");
            Console.WriteLine($"\tNév: {legmagasabbHegy.HegycsucsNeve}");
            Console.WriteLine($"\tHegység: {legmagasabbHegy.Hegyseg}");
            Console.WriteLine($"\tMagasság: {legmagasabbHegy.Magassag}");
        }
    }
}

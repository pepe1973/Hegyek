using System;
using System.Collections.Generic;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class NegyedikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            int osszMagassag = 0;

            foreach (Hegy elem in lista)
            {
                osszMagassag += elem.Magassag;
            }

            double atlag = (double)osszMagassag / lista.Count;

            Console.WriteLine($"4. Feladat: Hegycsúcsok átlagos magassága: {atlag:F2} m");
        }
    }
}

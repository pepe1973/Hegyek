using System;
using System.Collections.Generic;
using Hegyek.Objektumok;
using Hegyek.FileKezeles;

namespace Hegyek.Feladatok
{
    class KilencedikFeladat
    {
        static public void Megoldas(List<Hegy> lista)
        {
            Console.WriteLine("9. Feladat: bukk-videk.txt");

            string kiir = "Hegycsúcs neve;Magasság láb";

            foreach (Hegy elem in lista)
            {
                if (elem.Hegyseg == "Bükk-vidék")
                {
                    kiir += $"\n{elem.HegycsucsNeve};";
                    double magassag = elem.Magassag * 3.280839895;
                    kiir += $"{magassag.ToString("F1").Replace(",",".").Replace(".0","")}";
                }
            }

            FileKiiras kiiras = new FileKiiras("bukk-videk.txt");
            kiiras.Kiiras(kiir);
        }
    }
}

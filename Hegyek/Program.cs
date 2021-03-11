using System;
using Hegyek.FileKezeles;
using Hegyek.Objektumok;
using Hegyek.Feladatok;

namespace Hegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            FileBeolvas beolvas = new FileBeolvas("hegyekMo.txt"); 
            HarmadikFeladat.Megoldas(Hegy.HegyListaLetrehozas(beolvas.Beolvas(';')));
            NegyedikFeladat.Megoldas(Hegy.HegyListaLetrehozas(beolvas.Beolvas(';')));
            OtodikFeladat.Megoldas(Hegy.HegyListaLetrehozas(beolvas.Beolvas(';')));
            HatodikFeladat.Megoldas(Hegy.HegyListaLetrehozas(beolvas.Beolvas(';')));

            Console.ReadKey(true);
        }
    }
}

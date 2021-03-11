using System;
using System.Collections.Generic;
using Hegyek.FileKezeles;
using Hegyek.Objektumok;

namespace Hegyek.Feladatok
{
    class Megoldas
    {
        static public void FeladatMegoldas()
        {
            FileBeolvas beolvas = new FileBeolvas("hegyekMo.txt");
            List<Hegy> hegyLista = Hegy.HegyListaLetrehozas(beolvas.Beolvas(';'));
            HarmadikFeladat.Megoldas(hegyLista);
            NegyedikFeladat.Megoldas(hegyLista);
            OtodikFeladat.Megoldas(hegyLista);
            HatodikFeladat.Megoldas(hegyLista);
            HetedikFeladat.Megoldas(hegyLista);
            NyolcadikFeladat.Megoldas(hegyLista);
            KilencedikFeladat.Megoldas(hegyLista);

            Console.ReadKey(true);
        }
    }
}

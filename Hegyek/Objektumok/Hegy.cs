using System;
using System.Collections.Generic;

namespace Hegyek.Objektumok
{
    class Hegy
    {
        public string HegycsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegy()
        {

        }

        public Hegy(string hegycsucsNeve, string hegyseg, string magassag)
        {
            this.HegycsucsNeve = hegycsucsNeve;
            this.Hegyseg = hegyseg;
            this.Magassag = Int32.Parse(magassag);
        }

        static public List<Hegy> HegyListaLetrehozas(List<string[]> lista)
        {
            List<Hegy> hegyLista = new List<Hegy>();

            foreach (string[] elem in lista)
            {
                Hegy hegy = new Hegy(elem[0], elem[1], elem[2]);
                hegyLista.Add(hegy);
            }

            return hegyLista;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyKlinika
{
    abstract class Ordinacija
    {
        List<Pacijent> lista_cekanja = new List<Pacijent>();

      /*  public Lista<Pacijent> Liste
        {
            get { return lista_cekanja; }
        }

         public void  DodajOrdinacija(ref Pacijent a)
        {
            lista_cekanja.Add(a);
        }*/
    }

    class Kardiologija : Ordinacija { }
    class Stomatologija : Ordinacija { }
    class Dermatologija : Ordinacija { }
    class Oftamologija : Ordinacija { }
    class Opsta_Medicina : Ordinacija { }
    class Ortopedija : Ordinacija { }
    class Interna_Medicina : Ordinacija { }
    class Hirurgija : Ordinacija { };
    class Otorinolaringologija : Ordinacija { };
    class Laboratorijska_Medicina : Ordinacija { };
}

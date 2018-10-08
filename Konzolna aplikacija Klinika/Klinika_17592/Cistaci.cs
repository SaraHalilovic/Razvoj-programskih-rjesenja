using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class Cistaci:Uposlenici
    {
        public Cistaci(int plata, String ime, String prezime, String adresa, String jmbg, DateTime datum_rodjenja) : base ( ime, prezime,adresa, jmbg, datum_rodjenja,plata){

        }
    }
}

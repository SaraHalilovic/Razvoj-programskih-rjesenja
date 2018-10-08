using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    interface IMetode
    {
        int broj_pregleda_2017(Klinika nasaMalaKlinika);
        double postotak_pacijenata_hitna_pomoc(Klinika nasaMalaKlinika);
        double maxPlataDoktora(Klinika nasaMalaKlinika);

    }
}

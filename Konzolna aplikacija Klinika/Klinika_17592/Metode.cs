using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class Metode:IMetode
    {
        public double postotak_pacijenata_hitna_pomoc(Klinika nasaMalaKlinika)
        {
            ///Vraca postotak prezivjelih pacijenata nakon sto su primljeni u hitnu pomoc
            int ukupno;
            ukupno = nasaMalaKlinika.Broj();
            ukupno = ukupno + nasaMalaKlinika.Umrlih();
            double postotak;
            postotak = (nasaMalaKlinika.Broj() / ukupno) * 100;
            return postotak;
        }

        public double maxPlataDoktora(Klinika nasaMalaKlinika) //dodatak na platu
        {
            int d = nasaMalaKlinika.BrojDok();
            double max = 0;
            for (int i = 0; i < d; i++)
            {
                if (nasaMalaKlinika.listaDoktora_17592[i].DodatakNaPlatu > max) max = nasaMalaKlinika.listaDoktora_17592[i].DodatakNaPlatu;

            }
            return max;

        }
        public int broj_pregleda_2017(Klinika nasaMalaKlinika)
        {
            int t = nasaMalaKlinika.pacijenti_2017();
            return t;
        }
    }
}

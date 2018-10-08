using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyKlinika
{
    public class Doktor : Uposlenik
    {
        private Odjel odjel_doktora17592;
        private double dodatakNaPlatu_doktora17592;
        private int brojPacijenata_doktora17592;

        


        public Doktor(int plata, String ime, String prezime, String adresa, String jmbg, DateTime datum_rodjenja, double dodatak, int pac) : base(ime, prezime, adresa, jmbg, datum_rodjenja, plata)
        {
            dodatakNaPlatu_doktora17592 = dodatak;
            brojPacijenata_doktora17592 = pac;
        }
        public Odjel Odjel_Doktora
        {
            get { return odjel_doktora17592; }
            set { odjel_doktora17592 = value; }
        }

        public double DodatakNaPlatu
        {
            get { return dodatakNaPlatu_doktora17592; }
            set { dodatakNaPlatu_doktora17592 = value; }

        }
        public int BrojPacijenata
        {
            get { return brojPacijenata_doktora17592; }
            set { brojPacijenata_doktora17592 = value; }

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyKlinika
{
    public class Pregled
    {
        private Odjel doktor_pacijenta17592 = Odjel.Stomatologija;
        private DateTime datumPregleda_pacijenta17592;
        private TimeSpan vrijemePregleda_pacijenta17592;
        private bool obavljenPregled_pacijenta17592 = false;
        private string jmbg_zapregled_pacijenta17592;

        public Pregled() { }
        public Pregled(Odjel od, DateTime dpregleda, TimeSpan vpregleda, bool ob, string jmbgg)
        {
            doktor_pacijenta17592 = od;
            datumPregleda_pacijenta17592 = dpregleda;
            vrijemePregleda_pacijenta17592 = vpregleda;
            obavljenPregled_pacijenta17592 = ob;
            jmbg_zapregled_pacijenta17592 = jmbgg;
            datumPregleda_pacijenta17592 = datumPregleda_pacijenta17592.Date + vrijemePregleda_pacijenta17592;
        }
        
        public TimeSpan Vrijeme
        {
            get { return vrijemePregleda_pacijenta17592; }
            set { vrijemePregleda_pacijenta17592 = value; }
        }
        public Odjel Doktor
        {
            get { return doktor_pacijenta17592; }
        }
        public bool ObavljenPregled
        {
            get { return obavljenPregled_pacijenta17592; }
            set { obavljenPregled_pacijenta17592 = value; }
        }
        public int VrijemePregledaH
        {
            get { return vrijemePregleda_pacijenta17592.Hours; }

        }
        public int VrijemePregledaM
        {
            get { return vrijemePregleda_pacijenta17592.Minutes; }

        }
        public DateTime DatumM { get { return datumPregleda_pacijenta17592; } }
        public int DatumPregledaD
        {
            get { return datumPregleda_pacijenta17592.Day; }

        }
        public int DatumPregledaM
        {
            get { return datumPregleda_pacijenta17592.Month; }

        }
        public int DatumPregledaY
        {
            get { return datumPregleda_pacijenta17592.Year; }

        }
        public string JMBGGG
        {
            get { return jmbg_zapregled_pacijenta17592; }
        }
    }
}

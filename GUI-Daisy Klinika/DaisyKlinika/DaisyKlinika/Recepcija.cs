﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyKlinika
{
    public class Recepcija : Uposlenik
    {
        public Recepcija(int plata, String ime, String prezime, String adresa, String jmbg, DateTime datum_rodjenja) : base(ime, prezime, adresa, jmbg, datum_rodjenja, plata)
        {

        }
    }
}

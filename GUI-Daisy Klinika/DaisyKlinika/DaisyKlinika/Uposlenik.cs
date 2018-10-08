using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DaisyKlinika
{
   public abstract class Uposlenik
    {
        private string ime_uposlenika17592 { get; set; }
        private string prezime_uposlenika17592 { get; set; }
        private string adresaStanovanja_uposlenika17592 { get; set; }
        private DateTime datumRodjenja_uposlenika17592 { get; set; }
        private string JMBG_uposlenika17592 { get; set; }
        private double plata_uposlenika17592;
       // private string Kime17592 = "Armin";
       //private string password17592="Armin123";
        private string Kime17592;
        private string password17592;

        public Uposlenik(string imeuposlenika, string prezimeUposlenika, string p_adresaStanovanja, string Jmbg_Uposlenika, DateTime datumRodjenjaU, int plata)
        {
            ime_uposlenika17592 = imeuposlenika;
            prezime_uposlenika17592 = prezimeUposlenika;
            adresaStanovanja_uposlenika17592 = p_adresaStanovanja;
            JMBG_uposlenika17592 = Jmbg_Uposlenika;
            datumRodjenja_uposlenika17592 = datumRodjenjaU;
            plata_uposlenika17592 = plata;
            Kime17592 = ime_uposlenika17592;
            password17592 = Jmbg_Uposlenika;
           // password17592 = generisiPassword(JMBG_uposlenika17592);
        }


        public string Sifrica
        {
            get { return password17592; }
            set { password17592 = value; }
        }
        public string Korisnicko_ime
        {
            get { return Kime17592; }
            set { Kime17592 = value; }
        }

        public String JMBG
        {
            get { return JMBG_uposlenika17592; }
            set { JMBG_uposlenika17592 = value; }
        }

        public string generisiPassword(String password)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(password)))
                {
                    builder.Append(b.ToString("x2").ToLower());
                }
                return builder.ToString();
            }
        }
    }
}


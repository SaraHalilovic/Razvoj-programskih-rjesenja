using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    public abstract class Uposlenici
    {
        private string ime_uposlenika17592 { get; set; }
        private string prezime_uposlenika17592 { get; set; }
        private string adresaStanovanja_uposlenika17592 { get; set; }
        private DateTime datumRodjenja_uposlenika17592 { get; set; }
        private string JMBG_uposlenika17592 { get; set; }
        private double plata_uposlenika17592;
        
        
        public Uposlenici(string imeuposlenika, string prezimeUposlenika, string p_adresaStanovanja, string Jmbg_Uposlenika,DateTime datumRodjenjaU,int plata)
        {
            ime_uposlenika17592 = imeuposlenika;
            prezime_uposlenika17592 = prezimeUposlenika;
            adresaStanovanja_uposlenika17592 = p_adresaStanovanja;
            JMBG_uposlenika17592 = Jmbg_Uposlenika;
            datumRodjenja_uposlenika17592=datumRodjenjaU;
            plata_uposlenika17592 = plata;
            
        }



        
    };
}

  /*  public class Doktor:Uposlenici //partial?
    {
        private static int brojacPacijenata;
        private float plata;
       // private Odjel odjelDoktora;
    }
}
*/
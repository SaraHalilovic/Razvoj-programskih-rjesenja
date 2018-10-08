using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class SmrtniKarton : Pacijent
    {
        private DateTime datumSmrti_17592;
        private TimeSpan vrijemeSmrti_17592;
        private string preliminarniUzrociSmrti_17592;
        private bool potrebnaObdukcija_17592;
        private TimeSpan vrijemeobd_17592;
        public SmrtniKarton()
        {
            potrebnaObdukcija_17592 = false;
        }
        public SmrtniKarton(string imePacijenta, string prezimePacijenta, string p_adresaStanovanja, string Jmbg_Pacijenta, Spol spol_pacijenta, bracnoStanje b_stanjePacijenta, DateTime datumrodjenjaP, DateTime datumprijemaP, string uzroksmrti, DateTime datsmrti, bool obd, TimeSpan vrijobd, TimeSpan vrijemesmrtii) : base(imePacijenta, prezimePacijenta, p_adresaStanovanja, Jmbg_Pacijenta, spol_pacijenta, b_stanjePacijenta, datumrodjenjaP, datumprijemaP)
        {
            datumSmrti_17592 = datsmrti;
            potrebnaObdukcija_17592 = obd;
            preliminarniUzrociSmrti_17592 = uzroksmrti;
            vrijemeobd_17592 = vrijobd;
            vrijemeSmrti_17592 = vrijemesmrtii;

        }

        public bool PotrebnaObdukcija { get { return potrebnaObdukcija_17592; } set { potrebnaObdukcija_17592 = value; } }
        public TimeSpan Vsmrti { get { return vrijemeSmrti_17592; } }
    }

}

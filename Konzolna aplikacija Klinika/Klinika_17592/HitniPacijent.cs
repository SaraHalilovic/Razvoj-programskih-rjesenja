using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class HitniPacijent : Pacijent
    {
        private string detaljiPrvePomoci_17592;
        private string razlogPruzanjaPrvePomoci_17592;

        public HitniPacijent() { }
        public HitniPacijent(string imePacijenta, string prezimePacijenta, string p_adresaStanovanja, string Jmbg_Pacijenta, Spol spol_pacijenta, bracnoStanje b_stanjePacijenta, DateTime datumrodjenjaP, DateTime datumprijemaP, string detalji, string razlog) : base(imePacijenta, prezimePacijenta, p_adresaStanovanja, Jmbg_Pacijenta, spol_pacijenta, b_stanjePacijenta, datumrodjenjaP, datumprijemaP)
        {
            detaljiPrvePomoci_17592 = detalji;
            razlogPruzanjaPrvePomoci_17592 = razlog;

        }

        public string DetaljiPrvePomoci { get { return detaljiPrvePomoci_17592; } set { detaljiPrvePomoci_17592 = value; } }
        public string RazlogPruzanjaPrvePomoci { get { return razlogPruzanjaPrvePomoci_17592; } set { razlogPruzanjaPrvePomoci_17592 = value; } }
    }
}

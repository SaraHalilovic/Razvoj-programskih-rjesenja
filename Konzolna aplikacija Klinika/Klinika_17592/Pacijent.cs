using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{

    enum Spol { Zena, Muskarac };
    enum bracnoStanje { Nevjencan, Vjencan };
    enum ZdravstvenoStanje { Zdravi, Bolesni };
    enum Odjel { Kardiologija, Hirurgija, Ortopedija, Dermatologija, Opsta_medicina, Interna_medicina, Otorinolaringologija, Oftamologija, Stomatologija, Laboratorijska_medicina };

   partial class Pacijent
    {
        


        public Pacijent() {  }

        public Pacijent(string imePacijenta, string prezimePacijenta, string p_adresaStanovanja, string Jmbg_Pacijenta, Spol spol_pacijenta, bracnoStanje b_stanjePacijenta, DateTime datumrodjenjaP, DateTime datumprijemaP)
        {
            ime_17592 = imePacijenta;
            prezime_17592 = prezimePacijenta;
            datumRodjenja_17592 = datumrodjenjaP;
            spol_Pacijenta_17592 = spol_pacijenta;
            bracnoStanje_Pacijenta_17592 = b_stanjePacijenta;
            adresaStanovanja_17592 = p_adresaStanovanja;
            JMBG_17592 = Jmbg_Pacijenta;
            pregledan_17592 = false;
            datumPrijema_17592 = datumprijemaP;
            ziv_17592 = true;
            posjedujeKarton_17592 = false;

        }
        public Pacijent(Pacijent a)
        {
            ime_17592 = a.Ime;
            prezime_17592 = a.Prezime;
            adresaStanovanja_17592 = a.adresaStanovanja_17592;
            JMBG_17592 = a.JMBG_17592;
            spol_Pacijenta_17592 = a.spol_Pacijenta_17592;
            bracnoStanje_Pacijenta_17592 = a.bracnoStanje_Pacijenta_17592;
            pregledan_17592 = a.Pregledan;
            ziv_17592 = a.Ziv;
            posjedujeKarton_17592 = a.PosjedujeKarton;
        }

        public Karton KartonPacijenta{
            get{ return kartonpacijenta_17592; }
            set { kartonpacijenta_17592 = value; }
         

        }

        
        public string Ime
        {
            get { return ime_17592; }
            set { ime_17592 = value; }
        }

        public string Prezime
        {
            get { return prezime_17592; }
            set { prezime_17592 = value; }
        }

        public string JMBGG
        {
            get { return JMBG_17592; }
            set { JMBG_17592 = value; }
        }
        public string AdresaStanovanja
        {
            get { return adresaStanovanja_17592; }
            set { adresaStanovanja_17592 = value; }
        }

        public bool Pregledan
        {
            get { return pregledan_17592; }
            set { pregledan_17592 = value; }
        }

        public bool Ziv
        {
            get { return ziv_17592; }
            set { ziv_17592 = value; }
        }

        public bool PosjedujeKarton
        {
            get { return posjedujeKarton_17592; }
            set { posjedujeKarton_17592 = value; }
        }

        public Spol Spoll
        {
            get { return spol_Pacijenta_17592; }
            set { spol_Pacijenta_17592 = value; }
        }

        public bracnoStanje Bracno_Stanje
        {
            get { return bracnoStanje_Pacijenta_17592; }
            set { bracnoStanje_Pacijenta_17592 = value; }
        }
    }


   
    

    

}

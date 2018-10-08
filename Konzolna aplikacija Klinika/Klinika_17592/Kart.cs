
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
    {
        class Karton
        {
        private string sadasnjaBolest_pacijenta17592;
        private string alergije_pacijenta17592;
        private string prijasnjeBolesti_pacijenta17592;
        private string bolestiUPorodici_pacijenta17592;
        private string zakljucak_pacijenta17592;
        int broj_pregleda_pacijenta17592;
        private List<Pregled> listapregleda_pacijenta17592 = new List<Pregled>();
        private List<Pregled> listaobavljenihpregleda_pacijenta17592 = new List<Pregled>();
        private double platiti_pacijenta17592;
        private int broj_posjeta_pacijenta17592;


        public Karton() { broj_pregleda_pacijenta17592 = 0; platiti_pacijenta17592 = 0; broj_posjeta_pacijenta17592 = 0; }
        public Karton(string sadasnja, string prijasnja, string alergije, string porodica, string zakljuc)
        {
         SadasnjaBolest = sadasnja;
         PrijasnjeBolesti = prijasnja;
         Alergije = alergije;
         PorodicnaBolest = bolestiUPorodici_pacijenta17592;
            zakljucak_pacijenta17592 = zakljuc;}
        
        public int  BrojPosejeta()
        {
            return broj_posjeta_pacijenta17592;
        }
        public void UnesiNoviPregled(ref Pregled preg) { listapregleda_pacijenta17592.Add(preg); broj_pregleda_pacijenta17592++; }
        public void Obrisipregled(ref Pregled preg){
            listaobavljenihpregleda_pacijenta17592.Add(preg);
          Prebaci(preg);}

        public void obrisi(DateTime a,Odjel o)
        {
            for (int i = 0; i < Broj_pregleda(); i++) {
                if (DajListuPregleda[i].DatumPregledaD == a.Day && DajListuPregleda[i].DatumPregledaM == a.Month && DajListuPregleda[i].DatumPregledaY == a.Year && DajListuPregleda[i].Doktor == o)
                {
                    DajListuPregleda.Remove(DajListuPregleda[i]);
                    broj_pregleda_pacijenta17592--;
                    platiti_pacijenta17592 = platiti_pacijenta17592 + 40; //svaki pregled kosta 40 KM
                    broj_posjeta_pacijenta17592++;
                }
            }
        }
        public double PLatiti
        {
            get { return platiti_pacijenta17592; }
            set { platiti_pacijenta17592 = value; }
        }
        public double Platio()
        {
            return platiti_pacijenta17592;
        }

        public void Prebaci(Pregled p){ listapregleda_pacijenta17592.RemoveAll(i => i == p);}

        public int Broj_pregleda()
        {
            return broj_pregleda_pacijenta17592;
        }
        public List<Pregled> DajListuPregleda
        {
            get { return listapregleda_pacijenta17592; }
        }

        public string Zakljucak
        { get { return zakljucak_pacijenta17592; }
          set { zakljucak_pacijenta17592 = value; }
        }

        public Karton(Karton a)
        {
            SadasnjaBolest = a.SadasnjaBolest;
            PrijasnjeBolesti = a.PrijasnjeBolesti;
            Alergije = a.Alergije;
            PorodicnaBolest = a.PorodicnaBolest;}

        public string SadasnjaBolest
        {
            get { return sadasnjaBolest_pacijenta17592; }
            set { sadasnjaBolest_pacijenta17592 = value; }
        }

        public string PrijasnjeBolesti
        {
            get { return prijasnjeBolesti_pacijenta17592; }
            set { prijasnjeBolesti_pacijenta17592 = value; }
        }
        public string Alergije
        {
            get { return alergije_pacijenta17592; }
            set { alergije_pacijenta17592 = value; }
        }
        public string PorodicnaBolest
        {
            get { return bolestiUPorodici_pacijenta17592; }
            set { bolestiUPorodici_pacijenta17592 = value; }
        }

    }
    }


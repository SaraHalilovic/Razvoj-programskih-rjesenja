using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class Klinika
    {
    
    private List<Pacijent> listaPacijenata_17592 = new List<Pacijent>();
    private List<Pregled> listaPregleda_17592 = new List<Pregled>();
    public List<Doktori> listaDoktora_17592 = new List<Doktori>();
    public int broj_pregleda_17592;
    public int broj_pacijenata_17592;
    private int broj2017__17592;
    public List<SmrtniKarton> listaUmrlihPacijenata_17592 = new List<SmrtniKarton>();
        public Klinika() { broj_pacijenata_17592 = 0; broj_pregleda_17592 = 0; broj2017__17592 = 0; }

        public int pacijenti_2017() { return broj2017__17592; }
    public int Umrlih()
        {
            return listaUmrlihPacijenata_17592.Count;
        }
    // public double N

        private int broj_umrlih;
    public void DodajUListuPacijenata(ref Pacijent a)
     {
            listaPacijenata_17592.Add(a);
            broj_pacijenata_17592++;}

    public void DodajUListuPacijenata(ref HitniPacijent a)
        {
            listaPacijenata_17592.Add(a);
            broj_pacijenata_17592++;}

        public int BrojDok()
        {
            return listaDoktora_17592.Count;
        }
        
    public int Broj(){return listaPacijenata_17592.Count;}
        public int BrojP() { return listaPregleda_17592.Count; }
        public void ObrisiPacijenta(string jedbroj) { listaPacijenata_17592.RemoveAll(i=>i.JMBGG==jedbroj); broj_pacijenata_17592--;}

    public bool DaLiPostoji(string d){
    int count = DajListu.Count(x => x.JMBGG == d);
    if (count == 0) return false;
         return true;}


    public List<Pacijent> DajListu { get { return listaPacijenata_17592; } }
        public List<Pregled> DajListuP { get { return listaPregleda_17592; } }

        public int NadjiKarton(string jednbroj)
     {
       int a = -1;
       for(int i = 0; i < Broj(); i++)
       if (listaPacijenata_17592[i].JMBGG == jednbroj) return i;
      return a;}

    public int NadjiPregled(Odjel o, DateTime t)
        {
            for(int i = 0; i < BrojP(); i++)
            {
                if (o == listaPregleda_17592[i].Doktor && t.Day == listaPregleda_17592[i].DatumPregledaD && t.Month == listaPregleda_17592[i].DatumPregledaM && listaPregleda_17592[i].DatumPregledaY == t.Year) return i;
            }
            return -1;
        }
        public void ObrisiPregled(int k)
        {
            listaPregleda_17592.Remove(listaPregleda_17592[k]);
        }
     public void DodajPregled( Pregled a)
        {
            listaPregleda_17592.Add(a);
            broj_pregleda_17592++;
            if(a.DatumPregledaD==2017) broj2017__17592++;
            //sortirati po datumu

        }
     
}
}

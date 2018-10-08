using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyKlinika
{
    public enum Spol { Zena, Muskarac };
     public class Klinika: IMetode
    {
        private List<Pacijent> listaPacijenata_17592 = new List<Pacijent>();
        private List<Karton> listaKartona_17592 = new List<Karton>();
        private List<Pregled> listaPregleda_17592 = new List<Pregled>();
        private List<Doktor> listaDoktora_17592 = new List<Doktor>();
        private int broj_pregleda_17592;
        private int broj_pacijenata_17592;
        private int broj2017__17592;
        private int broj_umrlih;
        private List<Uposlenik> listaosoblja_17592=new List<Uposlenik>();
        private List<Med_Tehnicar>lista_tehnicara=new List<Med_Tehnicar>();
        private List<SmrtniKarton> listaUmrlihPacijenata_17592 = new List<SmrtniKarton>();
        private List<Pregled> listacekanja_kardiologija = new List<Pregled>();
        private List<Pregled> listacekanja_dermatologija = new List<Pregled>();
        private List<Pregled> listacekanja_oftamologija = new List<Pregled>();
        private List<Pregled> listacekanja_stomatologija = new List<Pregled>();
        private List<Pregled> listacekanja_interna_medicina = new List<Pregled>();
        private List<Pregled> listacekanja_lab_med = new List<Pregled>();
        private List<Pregled> listacekanja_opsta_med = new List<Pregled>();
        private List<Pregled> listacekanja_ortopedija = new List<Pregled>();
        private List<Pregled> listacekanja_hirurgija = new List<Pregled>();
        private List<Pregled> listacekanja_otorinolaringologija = new List<Pregled>();
       // private List<Ordinacija> ordinacije_17592 = new List<Ordinacija>();
        


        public Klinika() {
            broj_pacijenata_17592 = 0; broj_pregleda_17592 = 0; broj2017__17592 = 0;
            Doktor Armin = new Doktor(2000,"Armin", "XXX", "A", "2610996177004", Convert.ToDateTime("26.10.1996"),2.5,5);
            Med_Tehnicar Merjem = new Med_Tehnicar(200,"Merjem", "Ajaz", "A", "0507996175000", Convert.ToDateTime("05.07.1996"));
            Pacijent Nadal = new Pacijent("Rafa", "Nadal", "A", "0306986177004", Spol.Muskarac, bracnoStanje.Neozenjen, Convert.ToDateTime("03.06.1986"), Convert.ToDateTime("12.12.2017"));
          //  Pacijent Saša = new Pacijent("Sasa", "Zverce", "A", "2004997177004", Spol.Muskarac, bracnoStanje.Neozenjen, Convert.ToDateTime("20.04.1997"), Convert.ToDateTime("12.12.2017"));
            
            this.DodajDoktora(ref Armin);
            this.DodajUListuPacijenata( ref Nadal);

            Karton Nadal_Karton = new Karton(Nadal,"Gripa","Gripa","Paradajz","Nema historije bolesti","OK");
            this.DodajKarton(ref Nadal_Karton);

            TimeSpan n=new TimeSpan(20,20,20);
            Pregled a = new Pregled(Odjel.Opsta_medicina,Convert.ToDateTime("28/04/2017"), n,false,Nadal.JMBGG);

            Nadal_Karton.UnesiNoviPregled(ref a );

            this.lista_tehnicara.Add(Merjem);

        }

        public int pacijenti_2017() { return broj2017__17592; }

        public List<Doktor> DoktoriLista
        {
            get { return listaDoktora_17592; }
        }

        public List<Uposlenik> OsobljeLista
        {
            get { return listaosoblja_17592; }
        }
        public List<Karton> KartoniLista
        {
            get { return listaKartona_17592; }
        }

        public void DodajKarton(ref Karton a)
        {
            this.KartoniLista.Add(a);
        }

        public void DodajDoktora(ref Doktor a)
        {
            this.listaDoktora_17592.Add(a);
        }

        public int Osoblje_trazi(string Kor_Ime,string sifrica)
        {
            foreach (Doktor i in listaDoktora_17592)
            {
                if (i.Sifrica == sifrica && i.Korisnicko_ime == Kor_Ime)
                    return 0;
            }

            foreach (Pacijent i in listaPacijenata_17592)
            {
                if (i.Sifrica == sifrica && i.Korisnicko_ime == Kor_Ime)
                    return 1;
            }
            foreach (Med_Tehnicar i in lista_tehnicara)
            {
                if (i.Sifrica == sifrica && i.Korisnicko_ime == Kor_Ime)
                    return 2;
            }

            return -1;
        }

        public int Umrlih()
        {
            return listaUmrlihPacijenata_17592.Count;
        }



        public void DodajUListuPacijenata(ref Pacijent a)
        {
            listaPacijenata_17592.Add(a);
            broj_pacijenata_17592++;
        }

        public void DodajUListuPacijenata(ref HitniPacijent a)
        {
            listaPacijenata_17592.Add(a);
            broj_pacijenata_17592++;
        }

        public int BrojDok()
        {
            return listaDoktora_17592.Count;
        }

        public int Broj() { return listaPacijenata_17592.Count; }
        public int BrojP() { return listaPregleda_17592.Count; }
        public void ObrisiPacijenta(string jedbroj) { listaPacijenata_17592.RemoveAll(i => i.JMBGG == jedbroj); broj_pacijenata_17592--; }

        public bool DaLiPostoji(string d)
        {
            int count = DajListu.Count(x => x.JMBGG == d);
            if (count == 0) return false;
            return true;
        }


        public List<Pacijent> DajListu { get { return listaPacijenata_17592; } }
        public List<Pregled> DajListuP { get { return listaPregleda_17592; } }

        public int NadjiKarton(string jednbroj)
        {
            int a = -1;
            for (int i = 0; i < Broj(); i++)
                if (listaPacijenata_17592[i].JMBGG == jednbroj) return i;
            return a;
        }

        public int NadjiPregled(Odjel o, DateTime t)
        {
            for (int i = 0; i < BrojP(); i++)
            {
                if (o == listaPregleda_17592[i].Doktor && t.Day == listaPregleda_17592[i].DatumPregledaD && t.Month == listaPregleda_17592[i].DatumPregledaM && listaPregleda_17592[i].DatumPregledaY == t.Year) return i;
            }
            return -1;
        }

        public void ObrisiPregled(int k)
        {
            listaPregleda_17592.Remove(listaPregleda_17592[k]);
        }

        public void DodajPregled(Pregled a)
        {
            listaPregleda_17592.Add(a);
            broj_pregleda_17592++;
            if (a.DatumPregledaY == 2017) broj2017__17592++;
            if (a.Doktor == Odjel.Dermatologija)
            {
                listacekanja_dermatologija.Add(a);
                listacekanja_dermatologija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Kardiologija)
            {
                listacekanja_kardiologija.Add(a);
                listacekanja_kardiologija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Stomatologija)
            {
                listacekanja_stomatologija.Add(a);
                listacekanja_stomatologija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Oftamologija)
            {
                listacekanja_oftamologija.Add(a);
                listacekanja_oftamologija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Otorinolaringologija)
            {
                listacekanja_otorinolaringologija.Add(a);
                listacekanja_otorinolaringologija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Ortopedija)
            {
                listacekanja_ortopedija.Add(a);
                listacekanja_ortopedija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Opsta_medicina)
            {
                listacekanja_opsta_med.Add(a);
                listacekanja_opsta_med.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Laboratorijska_medicina)
            {
                listacekanja_lab_med.Add(a);
                listacekanja_lab_med.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else if (a.Doktor == Odjel.Interna_medicina)
            {
                listacekanja_interna_medicina.Add(a);
                listacekanja_interna_medicina.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }

            else
            {
                listacekanja_hirurgija.Add(a);
                listacekanja_hirurgija.Sort((ps1, ps2) => DateTime.Compare(ps1.DatumM, ps2.DatumM));
            }
        }
            

        
            public List<Pregled> Lista_kardiologija
        {
            get { return listacekanja_kardiologija; }
        }
        public List<Pregled> Lista_dermatologija
        {
            get { return listacekanja_dermatologija; }
        }
        public List<Pregled> Lista_opsta
        {
            get { return listacekanja_opsta_med; }
        }

        public List<Pregled> Lista_interna
        {
            get { return listacekanja_interna_medicina; }
        }

        public List<Pregled> Lista_lab
        {
            get { return listacekanja_lab_med; }
        }

        public List<Pregled> Lista_hirurgija
        {
            get { return listacekanja_hirurgija; }
        }

        public List<Pregled> Lista_oftamologija
        {
            get { return listacekanja_oftamologija; }
        }

        public List<Pregled> Lista_stomatologija
        {
            get { return listacekanja_stomatologija; }
        }

        public List<Pregled> Lista_otorinolaringologija
        {
            get { return listacekanja_otorinolaringologija; }
        }

        public List<Pregled> Lista_ortopedija
        {
            get { return listacekanja_ortopedija; }
        }
        public double postotak_pacijenata_hitna_pomoc()
        {
            ///Vraca postotak prezivjelih pacijenata nakon sto su primljeni u hitnu pomoc
            int ukupno;
            ukupno = Broj();
            ukupno = ukupno +Umrlih();
            double postotak;
            postotak = (Broj() / ukupno) * 100;
            return postotak;
        }

        public double maxPlataDoktora() //dodatak na platu
        {
            int d = this.BrojDok();
            double max = 0;
            for (int i = 0; i < d; i++)
            {
                if (DoktoriLista[i].DodatakNaPlatu > max) max = DoktoriLista[i].DodatakNaPlatu;

            }
            return max;

        }
        public int broj_pregleda_2017()
        {
            int t = pacijenti_2017();
            return t;
        }
      /*  public double maxcijena()
        {
            int max = 0;
            foreach(Pacijent i in listaPacijenata_17592)
            {
                if (i.)
            }
        }*/
    }
    }


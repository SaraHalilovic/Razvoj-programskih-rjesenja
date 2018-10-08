using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_17592
{
    class Program
    {
        public delegate void MaliDelegat(String a, String b);
        static Klinika klinika_Sara = new Klinika();
        static Metode a=new Metode();

        static void Main(string[] args)


        {
            Odjel odj;
            int[] broj_dana = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool trebaa = false;
            DateTime pomocnidatum = new DateTime(2017, 1, 1);
            bool allCharactersInStringAreDigits;
            int Mjesec; int Dan; int Godina;
            Klinika klinika_Sara = new Klinika();
            int choice = 0;
            string imeP; string prezimeP; string adresaP; string JMBGp;
            Spol sP;
            string dat = ""; ;
            string god;
            //int d; int m; int g;
            bracnoStanje bP;
            
            

            while (choice != 8)
            {


                Console.WriteLine(" Dobro došli! Odaberite jednu od opcija: \n");
                Console.WriteLine("1. Registruj/Briši pacijenta\n" +
                    "2. Prikaži raspored pregleda pacijenta\n" +
                    "3. Kreiranje kartona pacijenta\n" +
                    "4. Pretraga kartona pacijenta\n" +
                    "5. Registruj novi pregled \n" +
                    "6. Analiza sadržaja\n" +
                    "7. Naplata \n8. Izlaz \n");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)//odabir reg/brisi
                {
                    do
                    {
                        Console.WriteLine(" Odaberite jednu od opcija: \n1.) Registracija pacijenta\n2.) Brisanje pacijenta\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice != 1 && choice != 2) Console.WriteLine(" Unijeli ste opciju koja nije validna! Molimo Vas unesite jednu od predlozenih opcija.\n");
                    } while (choice != 2 && choice != 1);

                    if (choice == 1)//odabir registruj
                    {
                        do
                        {
                            Console.WriteLine("Odabrali ste registraciju pacijenta.\nOdaberite sada vrstu registracije:\n1.)Regularna registracija\n2.)Hitan slučaj");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice != 1 && choice != 2) Console.WriteLine(" Unijeli ste opciju koja nije validna! Molimo Vas unesite jednu od predlozenih opcija.\n");
                        } while (choice != 2 && choice != 1);
                        if (choice == 1)
                        {
                            Console.WriteLine("Odabrana je regularna registracija pacijenta.");
                            Console.WriteLine("Unesite ime pacijenta:\n");
                            imeP = Console.ReadLine();
                            Console.WriteLine("Unesite prezime pacijenta:\n");
                            prezimeP = Console.ReadLine();
                            Console.WriteLine("Unesite adresu pacijenta:\n");
                            adresaP = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Datum rodjenja:\nDan:");
                                Dan = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMjesec:");
                                Mjesec = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nGodina:");
                                Godina = Convert.ToInt32(Console.ReadLine());
                                if (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                            } while (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                            DateTime datumRodjenja = new DateTime(Godina, Mjesec, Dan);
                            if (datumRodjenja.Day < 10) dat = "0";
                            dat += datumRodjenja.Day.ToString();
                            if (datumRodjenja.Month < 10) dat += "0";
                            dat += datumRodjenja.Month.ToString();
                            god = datumRodjenja.Year.ToString();
                            dat += god[1]; dat += god[2]; dat += god[3];
                            do
                            {
                                Console.WriteLine("Unesite JMBG pacijenta:\n");
                                JMBGp = Console.ReadLine();
                                allCharactersInStringAreDigits = JMBGp.All(char.IsDigit);
                                // if (dat == JMBGp.Substring(0, 7)) trebaa = true;
                                if (JMBGp.Length != 13 || allCharactersInStringAreDigits == false) Console.WriteLine("Neispravan JMBG! Ponovno unesite ispravan JMBG:\n");
                            } while (JMBGp.Length != 13 || (dat != JMBGp.Substring(0, 7)) || allCharactersInStringAreDigits == false);
                            do
                            {
                                Console.WriteLine("Izaberite spol pacijenta:\n1.)Zena\n2.)Muskarac");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                            } while (choice != 2 && choice != 1);
                            if (choice == 1) { sP = Spol.Zena; }
                            else { sP = Spol.Muskarac; }

                            do
                            {
                                Console.WriteLine("Izaberite bracno stanje pacijenta:\n1.)Vjencan\n2.)Nevjencan");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                            } while (choice != 2 && choice != 1);
                            if (choice == 1) bP = bracnoStanje.Vjencan;
                            else { bP = bracnoStanje.Nevjencan; }

                            do
                            {
                                Console.WriteLine("Datum prijema:\nDan:");
                                Dan = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMjesec:");
                                Mjesec = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nGodina:");
                                Godina = Convert.ToInt32(Console.ReadLine());
                                if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                            } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                            DateTime datumPrijemaa = new DateTime(Godina, Mjesec, Dan);

                            Pacijent a = new Pacijent(imeP, prezimeP, adresaP, JMBGp, sP, bP, datumRodjenja, datumPrijemaa);
                            klinika_Sara.DodajUListuPacijenata(ref a);

                            //                   U N E S I M O    A N A M N E Z U
                            // string al, pbolesti, sbolesti, bolestiup;

                            Console.WriteLine("Unesite detalje sadasnje bolesti:\n");
                            string sbol = Console.ReadLine();
                            Console.WriteLine("Unesite detalje prijasnjih bolesti:\n");
                            string pbol = Console.ReadLine();
                            Console.WriteLine("Unesite detalje bolesti u porodici:\n");
                            string pobol = Console.ReadLine();
                            Console.WriteLine("Unesite alergije pacijenta:\n");
                            string ale = Console.ReadLine();
                            Console.WriteLine("Unesite zakljucak anamneze:\n");
                            string zakljucak = Console.ReadLine();


                            //Kreirajmo karton
                            Karton Kart = new Karton(sbol, pbol, ale, pobol, zakljucak);
                            a.KartonPacijenta = Kart;
                            a.PosjedujeKarton = true;


                        }




                        else ///H I T A N S L U Č A J
                        {
                            /// U nosimo prvo informacije u kartone prve pomoci
                            Console.WriteLine("Pristupa se pruzanju prve pomoci pacijentu:\n Unesite detalje prve pomoci:\n");
                            string detalj;
                            detalj = Console.ReadLine();
                            string Uzrok;
                            Console.WriteLine("Unesite razlog pruzanja prve pomoci pacijentu:\n");
                            Uzrok = Console.ReadLine();
                            Console.WriteLine("Unesite ime pacijenta:\n");
                            imeP = Console.ReadLine();
                            Console.WriteLine("Unesite prezime pacijenta:\n");
                            prezimeP = Console.ReadLine();
                            Console.WriteLine("Unesite adresu pacijenta:\n");
                            adresaP = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Datum rodjenja:\nDan:");
                                Dan = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMjesec:");
                                Mjesec = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nGodina:");
                                Godina = Convert.ToInt32(Console.ReadLine());
                                if (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                            } while (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                            DateTime datumRodjenja = new DateTime(Godina, Mjesec, Dan);
                            if (datumRodjenja.Day < 10) dat = "0";
                            dat += datumRodjenja.Day.ToString();
                            if (datumRodjenja.Month < 10) dat += "0";
                            dat += datumRodjenja.Month.ToString();
                            god = datumRodjenja.Year.ToString();
                            dat += god[1]; dat += god[2]; dat += god[3];
                            do
                            {
                                Console.WriteLine("Unesite JMBG pacijenta:\n");
                                JMBGp = Console.ReadLine();
                                allCharactersInStringAreDigits = JMBGp.All(char.IsDigit);
                                if (dat == JMBGp.Substring(0, 7)) trebaa = true;
                                if (JMBGp.Length != 13 || allCharactersInStringAreDigits == false || trebaa == false) Console.WriteLine("Neispravan JMBG! Ponovno unesite ispravan JMBG:\n");
                            } while (JMBGp.Length != 13 || trebaa == false || allCharactersInStringAreDigits == false);

                            do
                            {
                                Console.WriteLine("Izaberite spol pacijenta:\n1.)Zena\n2.)Muskarac");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                            } while (choice != 2 && choice != 1);
                            if (choice == 1) { sP = Spol.Zena; }
                            else { sP = Spol.Muskarac; }
                            do
                            {
                                Console.WriteLine("Izaberite bracno stanje pacijenta:\n1.)Vjencan\n2.)Nevjencan");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                            } while (choice != 2 && choice != 1);
                            if (choice == 1) bP = bracnoStanje.Vjencan;
                            else { bP = bracnoStanje.Nevjencan; }


                            do
                            {
                                Console.WriteLine("Datum prijema:\nDan:");
                                Dan = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMjesec:");
                                Mjesec = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nGodina:");
                                Godina = Convert.ToInt32(Console.ReadLine());
                                if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                            } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                            DateTime datumPrijemaa = new DateTime(Godina, Mjesec, Dan);

                            // Ako je prezivio treba ga staviti u listu pacijenata i u listu kartona sa prvom pomoci, ukoliko nije dodati ga u listu umrlih
                            do
                            {
                                Console.WriteLine("Da li je pacijent prezivio:\n1.)Da\n2.)Ne\n");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                            } while (choice != 1 && choice != 2);
                            if (choice == 1)///pprezivio pacijent
                            {
                                /// Pacijent b = new Pacijent(imeP, prezimeP, adresaP, JMBGp, sP, bP, datumRodjenja, datumPrijemaa);
                                HitniPacijent k = new HitniPacijent(imeP, prezimeP, adresaP, JMBGp, sP, bP, datumRodjenja, datumPrijemaa, detalj, Uzrok);
                                k.Ziv = true;

                                klinika_Sara.DodajUListuPacijenata(ref k);

                                Console.WriteLine("Unesite detalje sadasnje bolesti:\n");
                                string sb = Console.ReadLine();
                                Console.WriteLine("Unesite detalje prijasnjih bolesti:\n");
                                string prijbol = Console.ReadLine();
                                Console.WriteLine("Unesite detalje bolesti u porodici:\n");
                                string porbol = Console.ReadLine();
                                Console.WriteLine("Unesite alergije pacijenta:\n");
                                string alergijice = Console.ReadLine();
                                Console.WriteLine("Unesite zakljucak anamneze:\n");
                                string zakljucci = Console.ReadLine();

                                //Kreirajmo karton
                                Karton Kart = new Karton(sb, prijbol, alergijice, porbol, zakljucci);
                                k.KartonPacijenta = Kart;
                                k.PosjedujeKarton = true;
                                choice = 888;
                            }
                            if (choice == 2)
                            {//preminuo
                                bool treba = false;
                                //Potrebno je kreirati smrtni karton
                                Console.WriteLine("Unesite preliminarni uzrok smrti pacijenta:");
                                string uzrrok;
                                uzrrok = Console.ReadLine();

                                do
                                {
                                    Console.WriteLine("Datum smrti:\nDan:");
                                    Dan = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nMjesec:");
                                    Mjesec = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nGodina:");
                                    Godina = Convert.ToInt32(Console.ReadLine());
                                    if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                                } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                                DateTime datumsmr = new DateTime(Godina, Mjesec, Dan);
                                int sati = 0;
                                int minute = 0;
                                int sekunde = 0;
                                do
                                {
                                    Console.WriteLine("Unesite vrijeme smrti:\n");

                                    Console.WriteLine("Sat: ");
                                    sati = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nMinut: ");
                                    minute = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nSekunde: ");
                                    sekunde = Convert.ToInt32(Console.ReadLine());
                                    if (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0) Console.WriteLine("Unijeli ste neispravno vrijeme. Ponovite unos:\n");
                                } while (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0);

                                TimeSpan vs = new TimeSpan(sati, minute, sekunde);

                                do
                                {
                                    Console.WriteLine("\nDa li je potrebno izvrsiti obdukciju pacijenta?\n1.)Da\n2.)Ne");
                                    choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1) { treba = true; }
                                    else if (choice == 2) { treba = false; }
                                    else { Console.WriteLine("\nIzbor opcije nije validan! Molimo Vas izaberite jednu od mogucih opcija.\n"); }
                                } while (choice != 1 && choice != 2);
                                minute = sekunde = sati = 0;
                                if (treba == true)
                                {

                                    do
                                    {
                                        Console.WriteLine("Unesite vrijeme obdukcije:\n");

                                        Console.WriteLine("Sat: ");
                                        sati = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("\nMinut: ");
                                        minute = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("\nSekunde: ");
                                        sekunde = Convert.ToInt32(Console.ReadLine());
                                        if (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0) Console.WriteLine("Unijeli ste neispravno vrijeme. Ponovite unos:\n");
                                    } while (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0);
                                }
                                TimeSpan vo = new TimeSpan(sati, minute, sekunde);

                                SmrtniKarton g = new SmrtniKarton(imeP, prezimeP, adresaP, JMBGp, sP, bP, datumRodjenja, datumPrijemaa, uzrrok, datumsmr, treba, vo, vs);
                                klinika_Sara.listaUmrlihPacijenata_17592.Add(g);

                            }
                        }


                    }

                    else
                    {

                        Console.WriteLine("Izabrali ste brisanje pacijenta. Unesite JMBG pacijenta kojeg zelite obrisati:");
                        JMBGp = Console.ReadLine();
                        trebaa = klinika_Sara.DaLiPostoji(JMBGp);
                        if (trebaa) klinika_Sara.ObrisiPacijenta(JMBGp);
                        else { Console.WriteLine("JMBG ne postoji u listi pacijenata\n"); }


                    }


                }


                else if (choice == 3)
                { //Kreiranje kartona( prvo provjerimo da li pacijent ima vec kreiran karton, ukoliko ne pristupa se proceduri registracije)


                    Console.WriteLine("Unesite JMBG pacijenta za kojeg se kreira karton:\n");
                    JMBGp = Console.ReadLine();
                    if (klinika_Sara.DaLiPostoji(JMBGp)) Console.WriteLine("Pacijent vec ima kreiran karton!");

                    else
                    {
                        Console.WriteLine("Unesite ime pacijenta:\n");
                        imeP = Console.ReadLine();
                        Console.WriteLine("Unesite prezime pacijenta:\n");
                        prezimeP = Console.ReadLine();
                        Console.WriteLine("Unesite adresu pacijenta:\n");
                        adresaP = Console.ReadLine();
                        dat = "";
                        do
                        {
                            Console.WriteLine("Datum rodjenja:\nDan:");
                            Dan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nMjesec:");
                            Mjesec = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nGodina:");
                            Godina = Convert.ToInt32(Console.ReadLine());
                            if (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                        } while (Godina < 1900 || Godina > pomocnidatum.Year || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                        DateTime datumRodjenja = new DateTime(Godina, Mjesec, Dan);
                        if (datumRodjenja.Day < 10) dat = "0";
                        dat += datumRodjenja.Day.ToString();
                        if (datumRodjenja.Month < 10) dat += "0";
                        dat += datumRodjenja.Month.ToString();
                        god = datumRodjenja.Year.ToString();
                        dat += god[1]; dat += god[2]; dat += god[3];
                        do
                        {
                            Console.WriteLine("Unesite JMBG pacijenta:\n");
                            JMBGp = Console.ReadLine();
                            allCharactersInStringAreDigits = JMBGp.All(char.IsDigit);
                            if (dat == JMBGp.Substring(0, 7)) trebaa = true;
                            if (JMBGp.Length != 13 || allCharactersInStringAreDigits == false || trebaa == false) Console.WriteLine("Neispravan JMBG! Ponovno unesite ispravan JMBG:\n");
                        } while (JMBGp.Length != 13 || trebaa == false || allCharactersInStringAreDigits == false);
                        do
                        {
                            Console.WriteLine("Izaberite spol pacijenta:\n1.)Zena\n2.)Muskarac");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                        } while (choice != 2 && choice != 1);
                        if (choice == 1) { sP = Spol.Zena; }
                        else { sP = Spol.Muskarac; }

                        do
                        {
                            Console.WriteLine("Izaberite bracno stanje pacijenta:\n1.)Vjencan\n2.)Nevjencan");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice != 1 && choice != 2) Console.WriteLine("Unijeli ste opciju koja nije validna!Molimo Vas unesite jednu od predlozenih opcija.\n");
                        } while (choice != 2 && choice != 1);
                        if (choice == 1) bP = bracnoStanje.Vjencan;
                        else { bP = bracnoStanje.Nevjencan; }

                        do
                        {
                            Console.WriteLine("Datum prijema:\nDan:");
                            Dan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nMjesec:");
                            Mjesec = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nGodina:");
                            Godina = Convert.ToInt32(Console.ReadLine());
                            if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                        } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                        DateTime datumPrijemaa = new DateTime(Godina, Mjesec, Dan);

                        Pacijent a = new Pacijent(imeP, prezimeP, adresaP, JMBGp, sP, bP, datumRodjenja, datumPrijemaa);
                        klinika_Sara.DodajUListuPacijenata(ref a);

                        //                   U N E S I M O    A N A M N E Z U
                        // string al, pbolesti, sbolesti, bolestiup;

                        Console.WriteLine("Unesite detalje sadasnje bolesti:\n");
                        string sbol = Console.ReadLine();
                        Console.WriteLine("Unesite detalje prijasnjih bolesti:\n");
                        string pbol = Console.ReadLine();
                        Console.WriteLine("Unesite detalje bolesti u porodici:\n");
                        string pobol = Console.ReadLine();
                        Console.WriteLine("Unesite alergije pacijenta:\n");
                        string ale = Console.ReadLine();
                        Console.WriteLine("Unesite zakljucak anamneze:\n");
                        string zakljucak = Console.ReadLine();


                        //Kreirajmo karton
                        Karton Kart = new Karton(sbol, pbol, ale, pobol, zakljucak);
                        a.KartonPacijenta = Kart;
                        a.PosjedujeKarton = true;

                    }

                }

                else if (choice == 4)//pretraga kartona
                {
                    Console.WriteLine("Unesite JMBG pacijenta za kojeg se vrsi pretraga kartona:\n");
                    JMBGp = Console.ReadLine();
                    if (klinika_Sara.DaLiPostoji(JMBGp) == false) { Console.WriteLine("Pacijent sa unesenim JMBG ne postoji!\n"); }
                    else
                    {
                        int indeks = klinika_Sara.NadjiKarton(JMBGp);
                        MaliDelegat delegat = (s1, s2) =>
                        {
                            Console.WriteLine("Ime i prezime: {0} {1}", s1, s2);
                        };
                   
                        delegat(klinika_Sara.DajListu[indeks].Ime, klinika_Sara.DajListu[indeks].Prezime);
                        // Console.WriteLine("Ime: {0}\n", klinika_Sara.DajListu[indeks].Ime);
                        //Console.WriteLine("Prezime: {0}\n", klinika_Sara.DajListu[indeks].Prezime);
                        Console.WriteLine("JMBG: {0}\n", klinika_Sara.DajListu[indeks].JMBGG);
                        Console.WriteLine("Spol: {0}\n", klinika_Sara.DajListu[indeks].Spoll);
                        Console.WriteLine("Bracno stanje: {0}\n", klinika_Sara.DajListu[indeks].Bracno_Stanje);
                        Console.WriteLine("Adresa stanovanja: {0}\n", klinika_Sara.DajListu[indeks].AdresaStanovanja);
                        Console.WriteLine("Sadasnja bolest: {0}\n", klinika_Sara.DajListu[indeks].KartonPacijenta.SadasnjaBolest);
                        Console.WriteLine("Prijasnje bolesti: {0}\n", klinika_Sara.DajListu[indeks].KartonPacijenta.PrijasnjeBolesti);
                        Console.WriteLine("Alergije: {0}\n", klinika_Sara.DajListu[indeks].KartonPacijenta.Alergije);


                    }
                }
                else if (choice == 2)// Prikazi raspored pacijenta
                {
                    Console.WriteLine("Unesite JMBG pacijenta za kojeg se trazi raspored:\n");
                    JMBGp = Console.ReadLine();
                    int ind = klinika_Sara.NadjiKarton(JMBGp);

                    if (klinika_Sara.DaLiPostoji(JMBGp) == false) { Console.WriteLine("Pacijent nema kreiran karton!"); }

                    else
                    {
                        Console.WriteLine("Raspored pregleda:\n");
                        for (int i = 0; i < klinika_Sara.DajListu[ind].KartonPacijenta.Broj_pregleda(); i++)
                        {
                            Console.WriteLine("Pregled:");
                            Console.WriteLine("Datum pregleda: {0}.{1}.{2}\n", klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].DatumPregledaD, klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].DatumPregledaM, klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].DatumPregledaY);
                            Console.WriteLine("Vrijeme pregleda: {0}:{1}\n", klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].VrijemePregledaH, klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].VrijemePregledaM);
                            Console.WriteLine("Odjel: {0}\n\n", klinika_Sara.DajListu[ind].KartonPacijenta.DajListuPregleda[i].Doktor);
                            Console.WriteLine("{0}", klinika_Sara.DajListu[ind].KartonPacijenta.PLatiti);
                        }

                    }

                }
                else if (choice == 5)//Registrovanje pregleda
                {
                    do
                    {
                        Console.WriteLine("Izaberite jednu od opcija:\n1.) Registrovati novi pregled\n2.)Izvrsiti pregled");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice != 1 && choice != 2) Console.WriteLine("Molimo odaberite jednu od ponudjenih opcija!\n");
                    } while (choice != 1 && choice != 2);

                    if (choice == 1) //Zakazati novi pregled
                    {
                        Console.WriteLine("Unesite JMBG pacijenta kojem zelite zakazati pregled!\n");
                        JMBGp = Console.ReadLine();
                        //Provjera da li pacijent postoji
                        if (klinika_Sara.DaLiPostoji(JMBGp) == true)
                        {
                            int ind = klinika_Sara.NadjiKarton(JMBGp);
                            //////////////////////////
                            do
                            {
                                Console.WriteLine("Unesite datum pregleda:\nDan:");
                                Dan = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMjesec:");
                                Mjesec = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nGodina:");
                                Godina = Convert.ToInt32(Console.ReadLine());
                                if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                            } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                            DateTime datumPregleda = new DateTime(Godina, Mjesec, Dan);
                            //////////////////////////////////////////
                            int minute, sati, sekunde;
                            do
                            {
                                Console.WriteLine("Unesite vrijeme pregleda:\n");

                                Console.WriteLine("Sat: ");
                                sati = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nMinut: ");
                                minute = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nSekunde: ");
                                sekunde = Convert.ToInt32(Console.ReadLine());
                                if (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0) Console.WriteLine("Unijeli ste neispravno vrijeme. Ponovite unos:\n");
                            } while (sati < 0 || sati > 23 || minute > 59 || minute < 0 || sekunde > 59 || sekunde < 0);

                            TimeSpan vp = new TimeSpan(sati, minute, sekunde);
                            ///////////////////////////////////////////
                            do
                            {
                                Console.WriteLine("Molimo izaberite odjel:\n1.)Kardiologija\n2.)Hirurgija\n3.)Ortopedija\n4.)Dermatologija\n5.)Opsta_medicina\n6.)Interna_medicina\n7.)Otorinolaringologija\n8.)Oftamologija\n9.)Stomatologija\n10.)Laboratorijska_medicina\n");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1) { odj = Odjel.Kardiologija; }
                                else if (choice == 2) { odj = Odjel.Hirurgija; }
                                else if (choice == 3) { odj = Odjel.Ortopedija; }
                                else if (choice == 4) { odj = Odjel.Dermatologija; }
                                else if (choice == 5) { odj = Odjel.Opsta_medicina; }
                                else if (choice == 6) { odj = Odjel.Interna_medicina; }
                                else if (choice == 7) { odj = Odjel.Otorinolaringologija; }
                                else if (choice == 8) { odj = Odjel.Oftamologija; }
                                else if (choice == 9) { odj = Odjel.Stomatologija; }
                                else if (choice == 10) { odj = Odjel.Laboratorijska_medicina; }
                                else { Console.WriteLine("Nevalidana opcija! Unesite ponovo jednu od ponudjenjih opcija:\n "); odj = Odjel.Kardiologija; }
                            } while (choice > 10 || choice < 1);
                            choice = 0;

                            Pregled novi = new Pregled(odj, datumPregleda, vp, false,JMBGp);

                            klinika_Sara.DajListu[ind].KartonPacijenta.UnesiNoviPregled(ref novi);
                            klinika_Sara.DodajPregled(novi);

                        }
                        else { Console.WriteLine("Pacijent sa unesenim JMBG ne postoji u listi pacijenata!\n"); }
                    }

                    else//vrsenje pregleda
                    {
                        do
                        {
                            Console.WriteLine("Unesite datum pregleda:\nDan:");
                            Dan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nMjesec:");
                            Mjesec = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nGodina:");
                            Godina = Convert.ToInt32(Console.ReadLine());
                            if (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]) Console.WriteLine("Neispravan datum! Ponovno unesite ispravan datum:\n");
                        } while (Godina < 2017 || Dan < 1 || Mjesec < 1 || Mjesec > 12 || Dan > broj_dana[Mjesec - 1]);
                        DateTime datumPregleda = new DateTime(Godina, Mjesec, Dan);
                        do
                        {
                            Console.WriteLine("Molimo izaberite odjel:\n1.)Kardiologija\n2.)Hirurgija\n3.)Ortopedija\n4.)Dermatologija\n5.)Opsta_medicina\n6.)Interna_medicina\n7.)Otorinolaringologija\n8.)Oftamologija\n9.)Stomatologija\n10.)Laboratorijska_medicina\n");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1) { odj = Odjel.Kardiologija; }
                            else if (choice == 2) { odj = Odjel.Hirurgija; }
                            else if (choice == 3) { odj = Odjel.Ortopedija; }
                            else if (choice == 4) { odj = Odjel.Dermatologija; }
                            else if (choice == 5) { odj = Odjel.Opsta_medicina; }
                            else if (choice == 6) { odj = Odjel.Interna_medicina; }
                            else if (choice == 7) { odj = Odjel.Otorinolaringologija; }
                            else if (choice == 8) { odj = Odjel.Oftamologija; }
                            else if (choice == 9) { odj = Odjel.Stomatologija; }
                            else if (choice == 10) { odj = Odjel.Laboratorijska_medicina; }
                            else { Console.WriteLine("Nevalidana opcija! Unesite ponovo jednu od ponudjenjih opcija:\n "); odj = Odjel.Kardiologija; }
                        } while (choice > 10 || choice < 1);

                        int j = 0;//indeks pregleda u listipregleda
                        j = klinika_Sara.NadjiPregled(odj,datumPregleda);
                        string jedinstvenibroj = klinika_Sara.DajListuP[j].JMBGGG;
                        klinika_Sara.ObrisiPregled(j);
                        Console.WriteLine("Unesite misljenje doktora:");
                        string misljenje = Console.ReadLine();
                        Console.WriteLine("Unesite terapiju:");
                        misljenje = Console.ReadLine();
                        //nadjes pacijenta u listi pacijenata, obrises mu pregled ovaj i za platiti povecas
                        int pac = klinika_Sara.NadjiKarton(jedinstvenibroj);
                        klinika_Sara.DajListu[pac].KartonPacijenta.obrisi(datumPregleda,odj);
                       // Console.WriteLine("Platiti {0}\n", klinika_Sara.DajListu[pac].KartonPacijenta.Platio());

                    }
                }

                else if(choice==7)//Uplatiti

                {
                    double racun = 0;
                    int rata = 0;
                    double prva_rata=0;
                    double preostalo = 0;
                    //double racunRate = 0;
                    int brPosjeta = 0;
                    Console.WriteLine("Unesite JMBG pacijenta kojem izdajete racun: ");
                    JMBGp = Console.ReadLine();
                    if (klinika_Sara.DaLiPostoji(JMBGp))//Ako postoji
                    {
                        int ind = klinika_Sara.NadjiKarton(JMBGp);
                        do
                        {
                            Console.WriteLine("Unesite nacin placanja:\n1.)Placanje gotovinom\n2.)Placanje na rate\n)");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice != 2 && choice != 1) Console.WriteLine("Molimo unesite jednu od ponudjenih opcija!\n");
                        } while (choice != 2 && choice != 1);   

                        if(choice==1)//gotovina
                        {
                            brPosjeta=klinika_Sara.DajListu[ind].KartonPacijenta.BrojPosejeta();
                            if (brPosjeta > 3)//redovan pacijent
                            {
                                double x = klinika_Sara.DajListu[ind].KartonPacijenta.Platio();
                                racun = x * 0.9;
                                klinika_Sara.DajListu[ind].KartonPacijenta.PLatiti = 0;
                                Console.WriteLine("Racun za obavljene preglede iznosi: {0}\n", racun);
                            }

                            else
                            {//novi pacijent


                                double x = klinika_Sara.DajListu[ind].KartonPacijenta.Platio();
                                racun = x;
                                klinika_Sara.DajListu[ind].KartonPacijenta.PLatiti = 0;
                                Console.WriteLine("Racun za obavljene preglede iznosi: {0}\n", racun);

                            }

                        }
                        else//rate
                        {
                            Console.WriteLine("Unesite broj rata:\n");
                            rata = Convert.ToInt32(Console.ReadLine());
                            if (brPosjeta > 3)//redovan pacijent
                            {
                                double x = klinika_Sara.DajListu[ind].KartonPacijenta.Platio();
                                racun = x;
                                klinika_Sara.DajListu[ind].KartonPacijenta.PLatiti = 0;
                                Console.WriteLine("Racun za obavljene preglede iznosi: {0}\n", racun);
                                prva_rata = racun / rata;
                                Console.WriteLine("Uplata prve rate: {0}\n", prva_rata);
                                preostalo = racun - prva_rata;
                                Console.WriteLine("Preostali dug za obavljene preglede iznosi: {0}\n", preostalo);
                            }
                            else
                            {
                                double x = klinika_Sara.DajListu[ind].KartonPacijenta.Platio();
                                racun = x+x*0.15;
                                klinika_Sara.DajListu[ind].KartonPacijenta.PLatiti = 0;
                                Console.WriteLine("Racun za obavljene preglede iznosi: {0}\n", racun);
                                prva_rata = racun / rata;
                                Console.WriteLine("Uplata prve rate: {0}\n", prva_rata);
                                preostalo = racun - prva_rata;
                                Console.WriteLine("Preostali dug za obavljene preglede iznosi: {0}\n", preostalo);
                            }
                        }


                    }
                    else { Console.WriteLine("Ne postoji pacijent sa unesenim JMBG!"); }
                }

                else if (choice == 7)
                {
                    double x = a.postotak_pacijenata_hitna_pomoc(klinika_Sara);
                    Console.WriteLine("Postotak pacijenata koji su prezivjeli (hitni slucaj): {0}%\n", x);
                    double y = a.maxPlataDoktora(klinika_Sara);
                    Console.WriteLine("Maxsimalan dodatak na platu doktora iznosi: {0}\n", y);
                    int p = a.broj_pregleda_2017(klinika_Sara);
                    Console.WriteLine("Broj zakazanih pregleda u 2017: \n", p);
                }
                
               
            }
            Console.ReadKey();
        }
    }
}




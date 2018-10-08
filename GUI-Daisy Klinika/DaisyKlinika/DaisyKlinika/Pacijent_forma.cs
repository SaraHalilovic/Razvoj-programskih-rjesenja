using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DaisyKlinika
{
    public partial class Pacijent_forma : Form
    {
        Klinika Sarita = new Klinika();
        int koji;
        public Pacijent_forma(ref Klinika a, string pass)
        {
            InitializeComponent();
            Sarita = a;
             koji = 0;
            foreach(Pacijent i in Sarita.DajListu)
            {
                if (i.Sifrica == pass) { /*pictureBoxPac = i.Slikica;*/ break; }
                koji++;
            }
            textBoxIm.Text = Sarita.DajListu[koji].Ime;
            textBoxPrez.Text = Sarita.DajListu[koji].Prezime;
            textBoxJMBG.Text = Sarita.DajListu[koji].JMBGG;
            textBoxAdresa.Text = Sarita.DajListu[koji].AdresaStanovanja;
            textBoxDatum.Text = Sarita.DajListu[koji].Rodjenje.ToShortDateString();
            textBoxAlergije.Text = Sarita.KartoniLista[koji].Alergije;
            textBoxPrijasnje.Text = Sarita.KartoniLista[koji].SadasnjaBolest;
            textBoxPrija.Text = Sarita.KartoniLista[koji].PrijasnjeBolesti;
            textBoxPordo.Text = Sarita.KartoniLista[koji].PorodicnaBolest;
            richTextBoxTerapija.Text = Sarita.KartoniLista[koji].Terapija;
            richTextBox1.Text = "Vrijeme:" + "             " + "Datum: " + "        " + "Odjel:\n\n";
            foreach (Pregled d in Sarita.KartoniLista[koji].DajListuPregleda)
                richTextBox1.Text += d.Vrijeme.ToString() + "           " +d.DatumM.ToShortDateString()+"     " +d.Doktor.ToString() + "\n";

            richTextBoxJu.Text = "Vrijeme:" + "             " + "Datum: " + "        " + "Odjel:\n\n";
            foreach (Pregled d in Sarita.KartoniLista[koji].DajListuPregledaP)
                richTextBoxJu.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

           
        }

       

        





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIme_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelAdres_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDat_Click(object sender, EventArgs e)
        {

        }

        private void labelPrezime_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAlergije_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAlergije_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrijasnje_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxPac_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPregledi_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelObavljeni_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        

       
    }
}

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
    public partial class Pretraga_Kartona : Form
    {
        int broj = 0;
        Klinika Sarita = new Klinika();
        public Pretraga_Kartona(ref Klinika Daisy)
        {
            InitializeComponent();
            Sarita = Daisy;
            sakrijElementeForme();
            
            
        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            Boolean postoji = false;

            Karton prikazi = new Karton();
            Pacijent pacijent = new Pacijent();
            foreach (Karton k in Sarita.KartoniLista)
            {
                 broj = 0;
               
                if (k.Jedinstveni == textBoxJJ.Text)
                {
                    postoji = true;
                    prikazi = k;
                    break;
                }
                broj++;
            }
           

            if (postoji)
            {
                prikaziElementeForme();


                richTextBoxTrenutna.Text = prikazi.SadasnjaBolest;

                richTextBoxMisljenje.Show();
               
                
                textBoxAlergija.Text = prikazi.Alergije;
                
                textBoxImee.Text = prikazi.DajPacijenta.Ime;
                
                textBoxJMBG.Text = prikazi.DajPacijenta.JMBGG;
                
                textBoxPorodica.Text = prikazi.PorodicnaBolest;
                
                textBoxPrez.Text = prikazi.DajPacijenta.Prezime;
                
                textBoxPrijasnje.Text = prikazi.PrijasnjeBolesti;
                
                textBox2.Text = prikazi.DajPacijenta.AdresaStanovanja;
                

            }
            else if (textBoxJJ.Text.Length.Equals(0))
            {
                toolStripStatusLabel1.Text = "Unesite JMBG!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Visible = true;
            }

            else
            {

                toolStripStatusLabel1.Text = "Ne postoji pacijent sa trazenim JMBG!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void textBoxImee_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBoxPrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlergija_TextChanged(object sender, EventArgs e)
        {

            Sarita.KartoniLista[broj].Alergije = textBoxAlergija.Text;
        }

        private void textBoxSadasnja_TextChanged(object sender, EventArgs e)
        {

            Sarita.KartoniLista[broj].SadasnjaBolest = textBoxSadasnja.Text;
        }

        private void textBoxPrijasnje_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[broj].PrijasnjeBolesti = textBoxPrijasnje.Text;
        }

        private void textBoxPorodica_TextChanged(object sender, EventArgs e)
        {

            Sarita.KartoniLista[broj].PorodicnaBolest = textBoxPorodica.Text;
        }

        private void richTextBoxTrenutna_TextChanged(object sender, EventArgs e)
        {

            Sarita.KartoniLista[broj].SadasnjaBolest = richTextBoxTrenutna.Text;
        }

        private void richTextBoxMisljenje_TextChanged(object sender, EventArgs e)
        {

            Sarita.KartoniLista[broj].Terapija = richTextBoxMisljenje.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelIme_Click(object sender, EventArgs e)
        {

        }

        private void labelPrez_Click(object sender, EventArgs e)
        {

        }

        private void labelJMBG_Click(object sender, EventArgs e)
        {

        }

        private void labelAdresa_Click(object sender, EventArgs e)
        {

        }

        private void labelterapija_Click(object sender, EventArgs e)
        {

        }

        private void labelMisljenje_Click(object sender, EventArgs e)
        {

        }

        private void labelAlergije_Click(object sender, EventArgs e)
        {

        }

        private void label3Sad_Click(object sender, EventArgs e)
        {

        }

        private void label2Prijasnje_Click(object sender, EventArgs e)
        {

        }

        private void labelPorodicnininin_Click(object sender, EventArgs e)
        {

        }

        public void sakrijElementeForme()
        {
            richTextBoxTrenutna.Hide();
            richTextBoxMisljenje.Hide();
            textBoxAlergija.Hide();
            textBoxImee.Hide();
            textBoxJMBG.Hide();
            textBoxPorodica.Hide();
            textBoxPrez.Hide();
            textBoxPrijasnje.Hide();
            textBox2.Hide();
            textBoxSadasnja.Hide();
            labelIme.Hide();
            labelPrez.Hide();
            label2Prijasnje.Hide();
            label3Sad.Hide();
            labelAdresa.Hide();
            labelAlergije.Hide();
            labelJMBG.Hide();
            labelMisljenje.Hide();
            labelPorodicnininin.Hide();
            labelterapija.Hide();
        }

        public void prikaziElementeForme()
        {
            richTextBoxTrenutna.Show();
            richTextBoxMisljenje.Show();
            textBoxAlergija.Show();
            textBoxImee.Show();
            textBoxJMBG.Show();
            textBoxPorodica.Show();
            textBoxPrez.Show();
            textBoxSadasnja.Show();
            textBoxPrijasnje.Show();
            textBox2.Show();
            labelIme.Show();
            labelPrez.Show();
            label2Prijasnje.Show();
            label3Sad.Show();
            labelAdresa.Show();
            labelAlergije.Show();
            labelJMBG.Show();
            labelMisljenje.Show();
            labelPorodicnininin.Show();
            labelterapija.Show();
        }

        private void textBoxJJ_TextChanged(object sender, EventArgs e)
        {
            sakrijElementeForme();
        }
    }
}

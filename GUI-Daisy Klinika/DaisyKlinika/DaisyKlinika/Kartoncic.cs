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
    public partial class Kartoncic : Form
    {
        Klinika Sarita = new Klinika();
        string passwordic_17592;
        int koji;
        public Kartoncic(ref Klinika z,string JMBG)
        {
            InitializeComponent();
            Sarita = z;
            passwordic_17592 = JMBG;


            koji = 0;
            foreach (Pacijent i in Sarita.DajListu)
            {
                if (i.JMBGG == passwordic_17592) {  break; }
                koji++;
            }
            textBoxImee.Text = Sarita.DajListu[koji].Ime;
            textBoxPrez.Text = Sarita.DajListu[koji].Prezime;
            textBoxJMBG.Text = Sarita.DajListu[koji].JMBGG;
            textBox2.Text = Sarita.DajListu[koji].AdresaStanovanja;
            textBoxAlergija.Text = Sarita.KartoniLista[koji].Alergije;
            textBoxSadasnja.Text = Sarita.KartoniLista[koji].SadasnjaBolest;
            textBoxPrijasnje.Text = Sarita.KartoniLista[koji].PrijasnjeBolesti;
            textBoxPorodica.Text = Sarita.KartoniLista[koji].PorodicnaBolest;
            richTextBoxTrenutna.Text = Sarita.KartoniLista[koji].Terapija;

            //Spasiti promjene
           
        }

        private void Kartoncic_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelJMBG_Click(object sender, EventArgs e)
        {

        }

        private void labelAlergije_Click(object sender, EventArgs e)
        {

        }

        private void label2Prijasnje_Click(object sender, EventArgs e)
        {

        }

        private void labelterapija_Click(object sender, EventArgs e)
        {

        }

        private void label3Sad_Click(object sender, EventArgs e)
        {

        }

        private void labelPorodicnininin_Click(object sender, EventArgs e)
        {

        }

        private void labelMisljenje_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlergija_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[koji].Alergije = textBoxAlergija.Text;

        }

        private void textBoxImee_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSadasnja_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[koji].SadasnjaBolest = textBoxSadasnja.Text;
        }

        private void textBoxPorodica_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[koji].PorodicnaBolest = textBoxPorodica.Text;
        }

        private void richTextBoxTrenutna_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[koji].Terapija = richTextBoxTrenutna.Text;


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int b = 0;
            foreach (Karton i in Sarita.KartoniLista)
            {
                if (i.Jedinstveni == passwordic_17592) break;
                b++;
            }

            Sarita.KartoniLista[b].Alergije = textBoxAlergija.Text;
            Sarita.KartoniLista[b].SadasnjaBolest = textBoxSadasnja.Text;
            Sarita.KartoniLista[b].PrijasnjeBolesti = textBoxPrijasnje.Text;
            Sarita.KartoniLista[b].PorodicnaBolest = textBoxPorodica.Text;
            Sarita.KartoniLista[b].Terapija = richTextBoxTrenutna.Text;
            this.Close();
        }

        private void textBoxPrijasnje_TextChanged(object sender, EventArgs e)
        {
            Sarita.KartoniLista[koji].PrijasnjeBolesti = textBoxPrijasnje.Text;
        }
    }
}

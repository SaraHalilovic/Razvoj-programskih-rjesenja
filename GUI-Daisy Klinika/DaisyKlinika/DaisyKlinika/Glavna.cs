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
    public partial class Glavna : Form
        
    {
        Klinika Sara = new Klinika();
        public Glavna(ref Klinika a)
        {
            InitializeComponent();
            Sara = a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxjmbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //naci pacijenta sa tim jmbgom i onda naci karton
            bool postoji = false;
            foreach (Pacijent i in Sara.DajListu)
            {
                if (i.JMBGG == textBoxjmbg.Text) { postoji = true; break; }
               
            }
            if (postoji)
            {
                Kartoncic a = new Kartoncic(ref Sara, textBoxjmbg.Text);
                a.Show();
            }

            else
            {
                toolStripStatusLabel1.Text = "Ne postoji pacijent sa trazenim JMBG!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Visible = true;

            }
        }

        private void registrujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reg pacijenta
            RegistrujPacijenta tut = new RegistrujPacijenta(ref Sara);
            tut.Show();
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kartonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JMBGzaKart a = new JMBGzaKart(ref Sara);
            a.Show();
        }

        private void JMBG_Validating(object sender, CancelEventArgs e)
        {
            String porukica;
            if (!jeliispravanJMBG(textBoxjmbg, out porukica))
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
            errorProvider1.SetError(textBoxjmbg, porukica);
        }

        private bool jeliispravanJMBG(Control cont, out string poruka)
        {
            if (cont.Text.Length != 13 && cont.Text.Length != 0)
            {
                poruka = "Neispravan format JMBG!";
                return false;
            }
            if (cont.Text == String.Empty)
            {
                poruka = "Popunite polje!";
                return false;
            }
          
            poruka = "";
            return true;
        }

        private void pacijentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form1 obrisi_pacijenta = new Form1(ref Sara);
            obrisi_pacijenta.Show();


        }

        private void doktoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 obrisi_doktora = new Form3(ref Sara);
            obrisi_doktora.Show();
        }

        private void uposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

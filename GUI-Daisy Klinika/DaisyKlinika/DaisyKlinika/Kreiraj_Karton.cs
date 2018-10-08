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
    public partial class Kreiraj_Karton : Form
    {
        Klinika Sara = new Klinika();
        string h;
        public Kreiraj_Karton(ref Klinika a,string d)
        {
            InitializeComponent();
            Sara = a;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxAlergija_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSadasnja_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrijasnje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPorodica_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxTrenutna_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3Sad_Click(object sender, EventArgs e)
        {

        }

        private void labelAlergije_Click(object sender, EventArgs e)
        {

        }

        private void label2Prijasnje_Click(object sender, EventArgs e)
        {

        }

        private void labelPorodicnininin_Click(object sender, EventArgs e)
        {

        }

        private void labelterapija_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelIme_Click(object sender, EventArgs e)
        {

        }

        private void labelPrez_Click(object sender, EventArgs e)
        {

        }

        private void textBoxImee_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Karton a = new Karton(textBoxJMBG.Text,textBoxSadasnja.Text,textBoxPrijasnje.Text,textBoxAlergija.Text,textBoxPorodica.Text,h);
            Sara.KartoniLista.Add(a);
            this.Close();
        }
    }
}

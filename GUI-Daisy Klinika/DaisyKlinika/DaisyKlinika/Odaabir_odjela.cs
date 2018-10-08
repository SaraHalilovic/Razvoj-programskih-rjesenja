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
    public partial class Odaabir_odjela : Form
    {
        Klinika Sarita = new Klinika();
        string ordinacijaa;

        public Odaabir_odjela(ref Klinika a)
        {
            InitializeComponent();
            Sarita = a;

        }

        private void jmbgpac_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            Close();
           

            /*
            ordinacijaa = comboBox1.Text;
            Lista_cekanja formica = new Lista_cekanja(ref Sarita,ordinacijaa);
            formica.Show();*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            richTextBox11.Text = "Vrijeme:" + "           " + "Datum: " + "       " + "Odjel:\n\n";

            if (listBox1.SelectedItem.ToString().Equals("Dermatologija"))
            {
                foreach (Pregled d in Sarita.Lista_dermatologija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }
           else  if (listBox1.SelectedItem.ToString().Equals("Hirurgija"))
            {
                foreach (Pregled d in Sarita.Lista_hirurgija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }

            if (listBox1.SelectedItem.ToString().Equals("Stomatologija"))
            {
                foreach (Pregled d in Sarita.Lista_stomatologija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }

            if (listBox1.SelectedItem.ToString().Equals("Hirurgija"))
            {
                foreach (Pregled d in Sarita.Lista_hirurgija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }

            if (listBox1.SelectedItem.ToString().Equals("Kardiologija"))
            {
                foreach (Pregled d in Sarita.Lista_kardiologija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }

            if (listBox1.SelectedItem.ToString().Equals("Otorinolaringologija"))
            {
                foreach (Pregled d in Sarita.Lista_otorinolaringologija)
                    richTextBox11.Text += d.Vrijeme.ToString() + "           " + d.DatumM.ToShortDateString() + "     " + d.Doktor.ToString() + "\n";

            }

        }
    }
}

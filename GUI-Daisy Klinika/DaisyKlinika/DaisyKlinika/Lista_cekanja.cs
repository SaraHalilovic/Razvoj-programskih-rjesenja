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
    public partial class Lista_cekanja : Form
    {
        Klinika Sarita = new Klinika();
        string ordinacija;
        public Lista_cekanja(ref Klinika a,string ord)
        {
            InitializeComponent();
            Sarita = a;
            ordinacija = ord;
            textBox1.Text = ordinacija;
            richTextBox1.Text = "Vrijeme, Datum, JMBG:\n\n";
            if (ordinacija == "Kardiologija") {
                foreach (Pregled p in Sarita.Lista_kardiologija)
                {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Dermatologija")
            {
                foreach (Pregled p in Sarita.Lista_dermatologija) {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Hirurgija")
            {
                foreach (Pregled p in Sarita.Lista_hirurgija) {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }

            else if (ordinacija == "Interna medicina")
            {
                foreach (Pregled p in Sarita.Lista_interna)
                {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
                    }
            else if (ordinacija == "Laboratorijska medicina")
            {
                foreach (Pregled p in Sarita.Lista_lab) {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Oftamologija")
            {
                foreach (Pregled p in Sarita.Lista_oftamologija) {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Opšta medicina")
            {
                foreach (Pregled p in Sarita.Lista_opsta)
                {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Ortopedija")
            {
                foreach (Pregled p in Sarita.Lista_ortopedija)
                {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else if (ordinacija == "Otorinolaringologija")
            {
                foreach (Pregled p in Sarita.Lista_otorinolaringologija)
                {
                    richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                }
            }
            else {
                {
                    foreach (Pregled p in Sarita.Lista_stomatologija)
                    {
                        richTextBox1.Text += p.Vrijeme.ToString() + ", " + p.DatumM.ToLongTimeString() + ", " + p.JMBGGG + "\n";
                    }
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

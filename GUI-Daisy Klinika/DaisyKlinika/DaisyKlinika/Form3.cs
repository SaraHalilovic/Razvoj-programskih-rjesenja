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
    public partial class Form3 : Form
    {
        Klinika Daisy = new Klinika();
        public Form3(ref Klinika Sara)
        {
            InitializeComponent();
            Daisy = Sara;
        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            Boolean postoji = false;
            int broj = 0;
            foreach (Doktor d in Daisy.DoktoriLista)
            {
                if (d.JMBG== textBoxJJ.Text)
                {
                   
                    postoji = true;

                    break;
                }
                broj++;
            }

            if (postoji)
            {
                //forma obrisi doktora ili samo pop poruka
                Daisy.DoktoriLista.RemoveAt(broj);

                foreach (Uposlenik d in Daisy.OsobljeLista)
                {
                    int brojac = 0;
                    if (d.JMBG == textBoxJJ.Text)
                    {
                        Daisy.OsobljeLista.RemoveAt(brojac);
                    }
                    brojac++;
                }

                //pop poruka

                MessageBox.Show("Doktor je uspjesno obrisan!", "Obavjestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                toolStripStatusLabel1.Visible = false;
            }
            else
            {
                toolStripStatusLabel1.Text = "Ne postoji osoblje sa unesenim JMBG";
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void textBoxJJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void Jmbg_Validating(object sender, CancelEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void jmbgpac_Click(object sender, EventArgs e)
        {

        }
    }
}

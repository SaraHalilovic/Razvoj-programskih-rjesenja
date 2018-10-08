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
    public partial class Form4 : Form
    {
        Klinika Daisy = new Klinika();
        public Form4( ref Klinika Sara)
        {
            InitializeComponent();
            Daisy = Sara;

        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            Boolean postoji = false;
            int broj = 0;
            foreach (Uposlenik d in Daisy.OsobljeLista)
            {
                if (d.JMBG == textBoxJJ.Text)
                {

                    postoji = true;

                    break;
                }
                broj++;
            }

            if (postoji)
            {
                Daisy.OsobljeLista.RemoveAt(broj);

                MessageBox.Show("Uposlenik je uspjesno obrisan!", "Obavjestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

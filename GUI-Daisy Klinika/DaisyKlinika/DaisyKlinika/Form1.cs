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
    public partial class Form1 : Form
    {
        private Klinika Sarita = new Klinika();
        private string maticni;
        
        public Form1(ref Klinika a)
        {
            InitializeComponent();
            Sarita = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxJJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void jmbgpac_Click(object sender, EventArgs e)
        {

        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {

            Boolean postoji = false;
            int broj = 0;
            foreach(Karton k in Sarita.KartoniLista)
            {
                if (k.Jedinstveni== textBoxJJ.Text)
                {
                    maticni = k.Jedinstveni;
                    postoji = true;
                    
                    break;
                }
                broj++;
            }

            if (postoji)
            {
                //forma obrisi pacijenta ili samo pop poruka
                Sarita.DajListu.RemoveAt(broj);
                Sarita.KartoniLista.RemoveAt(broj);

                //pop poruka

                MessageBox.Show("Pacijent je uspjesno obrisan!", "Obavjestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                toolStripStatusLabel1.Visible = false;
            }
            else
            {
                toolStripStatusLabel1.Text = "Ne postoji pacijent sa unesenim JMBG";
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
            }

            //otvara formu Karton ^.^
          /*  Kartoncic karton = new Kartoncic(ref Sarita,maticni);
            karton.Show();
            this.Close();*/
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

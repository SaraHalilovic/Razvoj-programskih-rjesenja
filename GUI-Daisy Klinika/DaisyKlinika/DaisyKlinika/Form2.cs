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
    public partial class Form2 : Form
    {
        Klinika Sarita = new Klinika();
        string maticni;
        int a = 0;

        public Form2(ref Klinika a)
        {
            InitializeComponent();
            Sarita = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void jmbgpac_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            foreach (Karton k in Sarita.KartoniLista)
            {
                if (k.Jedinstveni == textBoxJJ.Text)
                {
                    maticni = k.Jedinstveni;
                    break;
                }
               
               /// u neku formu poslati maticni i kliniku
              
            }
            Unos_preg formica = new Unos_preg(ref Sarita, maticni);
            formica.Show();
            this.Close();




        }
    }
}

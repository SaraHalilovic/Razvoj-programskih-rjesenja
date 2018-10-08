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
    public partial class JMBGzaKart : Form
    {
        Klinika Sara = new Klinika();
        string jmmbg;
        public JMBGzaKart(ref Klinika a)
        {
            InitializeComponent();
            Sara = a;
            
            
        }

        private void jmbgpac_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonokicici_Click(object sender, EventArgs e)
        {
            jmmbg = textBoxJJ.Text;
            Kreiraj_Karton z = new Kreiraj_Karton(ref Sara, jmmbg);
            this.Close();
        }
    }
}

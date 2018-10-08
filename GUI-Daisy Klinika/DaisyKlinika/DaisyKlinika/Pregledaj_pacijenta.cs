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
    public partial class Pregledaj_pacijenta : Form
    {
        Klinika Sara = new Klinika();
        public Pregledaj_pacijenta(ref Klinika a)
        {
            InitializeComponent();
            Sara = a;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kardiologija") Sara.Lista_kardiologija.RemoveAt(0);
            else if (comboBox1.Text == "Dermatologija") Sara.Lista_dermatologija.RemoveAt(0);
            else if (comboBox1.Text == "Hirurgija") Sara.Lista_hirurgija.RemoveAt(0);
            else if (comboBox1.Text == "Interna medicina") Sara.Lista_interna.RemoveAt(0);
            else if (comboBox1.Text == "Laboratorijska medicina") Sara.Lista_lab.RemoveAt(0);
            else if (comboBox1.Text == "Oftamologija") Sara.Lista_oftamologija.RemoveAt(0);
            else if (comboBox1.Text == "Opšta medicina") Sara.Lista_opsta.RemoveAt(0);
            else if (comboBox1.Text == "Ortopedija") Sara.Lista_ortopedija.RemoveAt(0);
            else if (comboBox1.Text == "Otorinolaringologija") Sara.Lista_otorinolaringologija.RemoveAt(0);
            else { Sara.Lista_stomatologija.RemoveAt(0); }
            this.Close();

        }
    }
}

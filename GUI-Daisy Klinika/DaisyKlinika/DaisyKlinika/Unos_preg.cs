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
    public partial class Unos_preg : Form
    {
        Klinika Sarita = new Klinika();
        string maticni;
        public Unos_preg(ref Klinika a,string maticnii)
        {
            InitializeComponent();
            Sarita = a;
            maticni = maticnii;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelUnesi_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxSatt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinutice_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1ok_Click(object sender, EventArgs e)
        {
            int p = 0;
            //dodati u karton pacijenta i u listu svih pregleda klinike
            foreach(Karton i in Sarita.KartoniLista)
            {
                if (maticni == i.Jedinstveni) break;
                p++;
            }
         
            int x = Convert.ToInt32(textBoxSatt.Text);
            int y = Convert.ToInt32(textBoxMinutice.Text);
            TimeSpan a = new TimeSpan(x,y,0);
            DateTime dat = new DateTime();
            dat = dateTimePicker1.Value.Date;
            Odjel o=Odjel.Hirurgija;
            if (comboBox1.Text == "Kardiologija") o = Odjel.Kardiologija;
            else if (comboBox1.Text == "Dermatologija") o = Odjel.Dermatologija;
            else if (comboBox1.Text == "Hirurgija") o = Odjel.Hirurgija;
            else if (comboBox1.Text == "Interna medicina") o = Odjel.Interna_medicina;
            else if (comboBox1.Text == "Laboratorijska medicina") o = Odjel.Laboratorijska_medicina;
            else if (comboBox1.Text == "Oftamologija") o = Odjel.Oftamologija;
            else if (comboBox1.Text == "Opšta medicina") o = Odjel.Opsta_medicina;
            else if (comboBox1.Text == "Ortopedija") o = Odjel.Ortopedija;
            else if (comboBox1.Text == "Otorinolaringologija") o = Odjel.Otorinolaringologija;
            else { o = Odjel.Stomatologija; }

            Pregled d = new Pregled(o,dat,a,true,maticni);
            Sarita.KartoniLista[p].UnesiNoviPregled(ref d);
            Sarita.DajListuP.Add(d);
          //  if(dat.Year.ToString()=="2017") Sarita.D
            
            if (comboBox1.Text == "Kardiologija") Sarita.Lista_kardiologija.Add(d);
            else if (comboBox1.Text == "Dermatologija") Sarita.Lista_dermatologija.Add(d);
            else if (comboBox1.Text == "Hirurgija") Sarita.Lista_hirurgija.Add(d);
            else if (comboBox1.Text == "Interna_medicina") Sarita.Lista_interna.Add(d);
            else if (comboBox1.Text == "Laboratorijska_medicina") Sarita.Lista_lab.Add(d);
            else if (comboBox1.Text == "Oftamologija") Sarita.Lista_lab.Add(d);
            else if (comboBox1.Text == "Opsta_medicina") Sarita.Lista_opsta.Add(d);
            else if (comboBox1.Text == "Ortopedija") Sarita.Lista_ortopedija.Add(d);
            else if (comboBox1.Text == "Otorinolaringologija") Sarita.Lista_otorinolaringologija.Add(d);
            else { Sarita.Lista_stomatologija.Add(d); }
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class RegistrujPacijenta : Form
    {
        Klinika Daisy = new Klinika();
        public RegistrujPacijenta(ref Klinika a)
        {
            InitializeComponent();
            Daisy = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spol spol_pacijenta = Spol.Muskarac;
            bracnoStanje bracno_stanje = bracnoStanje.Ozenjen;

            if (RadioButtonZena.Checked)
                spol_pacijenta = Spol.Zena;
            else if (radioButtonMuskarac.Checked)
                spol_pacijenta = Spol.Muskarac;
            if (radioButtonSlobodan.Checked)
                bracno_stanje = bracnoStanje.Neozenjen;
            else if (radioButtonBrak.Checked)
                bracno_stanje = bracnoStanje.Ozenjen;


            if ((RadioButtonZena.Checked || radioButtonMuskarac.Checked) && (radioButtonSlobodan.Checked || radioButtonBrak.Checked))
            {
                Pacijent novi_pacijent = new Pacijent(Ime_pacijenta.Text, Prezime_pacijenta.Text, textBoxAdresa.Text, Jmbg_pacijenta.Text, spol_pacijenta, bracno_stanje, dateTimePicker2.Value, dateTimePicker1.Value);
                Daisy.DodajUListuPacijenata(ref novi_pacijent);
                Karton novi_karton = new Karton(novi_pacijent, "", "", "", "", "");
                Daisy.DodajKarton(ref novi_karton);
                //toolStripStatusLabel1.Text = "Pacijent je uspjesno dodan!";
                MessageBox.Show("Pacijent je uspjesno dodan!", "Obavjestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                toolStripStatusLabel1.Visible = false;
            }
            else {
                    toolStripStatusLabel1.Text = "Nijedno polje ne smije ostati prazno!";
                        toolStripStatusLabel1.ForeColor = Color.Red;
                        toolStripStatusLabel1.Visible = true;

            }

}
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegistrujPacijenta_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ime_pacijenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ime_pacijenta_Validating(object sender, CancelEventArgs e)
        {
            String porukica;
            if (!jelipravilanunos(Ime_pacijenta, out porukica))
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
            pravilnoime_prezime.SetError(Ime_pacijenta, porukica);
        }

            private void Ime_pacijenta_Validated(object sender, EventArgs e)
        {

        }


        private bool jeliispravanJMBG(Control cont, out string poruka)
        {
            if (cont.Text.Length != 13 && cont.Text.Length != 0)
            {
                poruka = "Neispravan format JMBG!";
                return false;
            }
            if (cont.Text == String.Empty)
            {
                poruka = "Popunite polje!";
                return false;
            }
            List<Pacijent> p = Daisy.DajListu;
            foreach (Pacijent p1 in p)
            {
                if (p1.JMBGG.Equals(cont.Text))
                {
                    poruka = "Pacijent sa tim JMBG vec postoji!";
                    return false;
                }
            }
            poruka = "";
            return true;
        }



        private bool DatumRodjenjaIJMBG(String jmbg, DateTimePicker datum, out string poruka)
        {

            String godina = datum.Value.Year.ToString();
            String mjesec = datum.Value.Month.ToString();
            String dan = datum.Value.Day.ToString();
            if ((jmbg[0].Equals(dan[0]) && jmbg[1].Equals(dan[1]) && jmbg[2].Equals(mjesec[0]) && jmbg[3].Equals(mjesec[1]) && jmbg[4].Equals(godina[1]) && jmbg[5].Equals(godina[2]) && jmbg[6].Equals(godina[3])))
            {
                poruka = "";
                return true;
            }
            poruka = "Datum rodjena i JMBG se ne poklapaju!";
            return false;
            
        }

        private void Jmbg_pacijenta_TextChanged(object sender, EventArgs e)
        {

        }

        private bool jelipravilanunos(Control cont, out string poruka)
        {

            if (cont.Text == String.Empty)
            {
                poruka = "Popuni polje!";
                return false;
            }
            else
            {
                for (int i = 0; i <= 9; ++i)
                {
                    if (cont.Text.Contains(i.ToString()))
                    {
                        poruka = "Neispravan format!";
                        return false;
                    }
                }

            }
            poruka = "";
            return true;
        }
        private void JMBG_pacijenta_Validating(object sender, CancelEventArgs e)
        {
            String porukica;
            if (!jeliispravanJMBG(Jmbg_pacijenta, out porukica))
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
            errorProvider1.SetError(Jmbg_pacijenta, porukica);
        }

        private void JMBG_pacijenta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(Jmbg_pacijenta,"");
        }

        private void prezime_pacijenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrezimePacijenta_Validating(object sender, CancelEventArgs e)
        {
           
                String porukica;
                if (!jelipravilanunos(Prezime_pacijenta, out porukica))
                {
                    {

                        e.Cancel = true;

                        this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                    }
                }
                pravilnoime_prezime.SetError(Prezime_pacijenta, porukica);
            }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            String porukica;
            if (!DatumRodjenjaIJMBG(Jmbg_pacijenta.Text, dateTimePicker2, out porukica))
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
           DatumRodjenja.SetError(dateTimePicker1, porukica);
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void bracnostanje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adresa_Validating(object sender, CancelEventArgs e)
        {
            String porukica;
            if (!jelipravilanunos(textBoxAdresa, out porukica))
            {
                {

                    e.Cancel = true;

                    this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                }
            }
            pravilnoime_prezime.SetError(textBoxAdresa, porukica);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }




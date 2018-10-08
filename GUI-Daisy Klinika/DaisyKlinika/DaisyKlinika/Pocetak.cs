using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace DaisyKlinika
{
    public partial class Pocetak : Form
    {
        static Klinika Sara_17592 = new Klinika();
        string passwordic_17592;
        string user_name17592;
        Pen olovka = new Pen(new SolidBrush(Color.White));
        Pen olovka1 = new Pen(new SolidBrush(Color.Yellow));
        GraphicsPath panel;
        SolidBrush olovkaA = new SolidBrush(Color.White);
        SolidBrush olovkaA1 = new SolidBrush(Color.Yellow);

        // Sara_17592.DodajUListuPacijenata()
        public Pocetak()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pocetak_Paint);

        }

        
        void Pocetak_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Graphics j = this.CreateGraphics();
            panel = new GraphicsPath();
            g.DrawEllipse(olovka,90, 10, 20, 100);
            g.FillEllipse(olovkaA,90,10,20,100);
            j.DrawEllipse(olovka, 50, 50, 100, 20);
            j.FillEllipse(olovkaA, 50, 50, 100, 20);
            g.RotateTransform(45.0F);
            g.DrawEllipse(olovka, 65, -40, 100, 20);
            g.FillEllipse(olovkaA, 65, -40, 100, 20);
            g.RotateTransform(-90.0F);
            g.DrawEllipse(olovka,-20,104,100,20);
            g.FillEllipse(olovkaA, -20, 104, 100, 20);
            j.DrawEllipse(olovka1, 90, 50, 20, 20);
            j.FillEllipse(olovkaA1, 90, 50, 20, 20);
        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void Pocetak_Load(object sender, EventArgs e)
        {

        }

        private void buttonKreni_Click(object sender, EventArgs e)
        {
            if(textKIme.Text.ToString().Length==0 || textPass.Text.ToString().Length == 0)
            {
                toolStripStatusLabel1.Text = "Molimo popunite sva polja!";
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
            else if (Sara_17592.Osoblje_trazi(user_name17592,passwordic_17592 )== 1)
            {
                Pacijent_forma pacijentic = new Pacijent_forma(ref Sara_17592,passwordic_17592);
               // this.Hide();
                pacijentic.Show();
            }
            else if (Sara_17592.Osoblje_trazi(user_name17592,passwordic_17592) == 0)
            {
                Doktor_forma doktorcic_17592 = new Doktor_forma(ref Sara_17592,passwordic_17592);
                doktorcic_17592.Show();
            }
           else if (Sara_17592.Osoblje_trazi(user_name17592, passwordic_17592) == 2)
            {
                Glavna formica = new Glavna(ref Sara_17592);
                formica.Show();
            }
            else
            {
                toolStripStatusLabel1.Text = "Ne postoji korisnik sa unesenim podacima";
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void textKIme_TextChanged(object sender, EventArgs e)
        {
            user_name17592 = textKIme.Text;
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            // passwordic_17592 = generisiPassword(textPass.Text);//textPass.Text;
            passwordic_17592 = textPass.Text;
        }

        private void labelKime_Click(object sender, EventArgs e)
        {

        }

        private void labelDaisy_Click(object sender, EventArgs e)
        {

        }

        //MD5 hashiranje->dovrsiti
        public string generisiPassword(String password)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(password)))
                {
                    builder.Append(b.ToString("x2").ToLower());
                }
                return builder.ToString();
            }
        }
    }
}

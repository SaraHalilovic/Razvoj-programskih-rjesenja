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
    public partial class Doktor_forma : Form
    {
        Klinika Sarita = new Klinika();
        string pass;
        public Doktor_forma(ref Klinika a, string pasw)
        {
            InitializeComponent();
            Sarita = a;

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Name =="UnesiKarton")
            {
                Pretraga_Kartona l = new Pretraga_Kartona(ref Sarita);
                l.Show();
               // return;
            }

             if (e.Node.Name == "Z") {
                //popravka
                Form2 m = new Form2(ref Sarita);
                m.Show();
               // return;
                
            }
            if (e.Node.Name == "Pregledaj")
            {

                Pregledaj_pacijenta t = new Pregledaj_pacijenta(ref Sarita);
                t.Show();
                // return;

            }
            if(e.Node.Name == "Node6")
            {

                Odaabir_odjela m = new Odaabir_odjela(ref Sarita);
                 m.Show();
                // return;

            }


        }

        private void buttonoki_Click(object sender, EventArgs e)
        {

        }
    }
}

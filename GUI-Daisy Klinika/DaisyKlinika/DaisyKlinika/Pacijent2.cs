using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace DaisyKlinika
{
    public partial class Pacijent
    {
        private string ime_17592;
        private string prezime_17592;
        private string adresaStanovanja_17592;
        private DateTime datumRodjenja_17592;
        private string JMBG_17592;
        private Spol spol_Pacijenta_17592;
        private bracnoStanje bracnoStanje_Pacijenta_17592;
        private DateTime datumPrijema_17592;
        private bool pregledan_17592;
        private bool ziv_17592;
        private bool posjedujeKarton_17592;
        private Karton kartonpacijenta_17592;
        private Image slikica_pacijent17592;


        public Image Slikica
        {
            get { return slikica_pacijent17592; }
            set { slikica_pacijent17592 = value; }
        }

        public string ispisi
        {
            get { return ime_17592 + " " + prezime_17592; }
        }
    }
   

}

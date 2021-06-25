using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EhliyetRandevuFacade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandevuAl_Click_1(object sender, EventArgs e)
        {
            EhliyetRandevuFacade ehliyetRandevu = new EhliyetRandevuFacade();
            ehliyetRandevu.EhliyetRandevusuAl(new Basvuran {Ad="Tamer",SoyAd="BULUT",TC="12345678901" });
        }
    }
}

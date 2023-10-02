using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2sayiyitoplama
{
    public partial class FORM1 : UserControl
    {
        public FORM1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sonuc = sayi1 + sayi2;

            lblSonuc.Text = sonuc.ToString();
            lblSonuc.Text = "iki sayıyı toplama: " + sonuc.ToString();
        }




    }
}
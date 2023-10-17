using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double adet, fiyat, tutar;
            adet = Convert.ToDouble(txtAdet.Text);
            fiyat = Convert.ToDouble(txtFiyat.Text);
            tutar = adet * fiyat;
            label3.Text = "Toplam Tutar: "+tutar+"₺";
        }
    }
}

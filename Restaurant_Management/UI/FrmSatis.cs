using BenımIsletmem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.UI
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }

        private void lblTabTitle_Click(object sender, EventArgs e)
        {

        }

        private void nmStok_ValueChanged(object sender, EventArgs e)
        {

        }
        
        public Musteri musteri { get; set; }
        public Urun mrun { get; set; }
        public Satis Satis { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz!");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            txtMusteri.Text = Musteri.ToString();
            txtUrun.Text = Urun.ToString();
        }
    }
}

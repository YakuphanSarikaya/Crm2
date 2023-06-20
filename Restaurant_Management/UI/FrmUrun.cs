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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            txtID.Text = Urun.ID.ToString();
            if (Güncelle)
            {
                txtUrun.Text = Urun.Ad;
                cbKategori.Text = Urun.Katagori;
                nmFiyat.Value = (decimal)Urun.Fiyat;
                nmStok.Value = (decimal)Urun.Stok;
                cbBirim.Text = Urun.Birim;
                txtDetay.Text = Urun.Detay;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public Urun Urun { get; set; }
        public bool Güncelle { get; set; } = false;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrun)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(cbBirim)) return;
            if (!ErrorControl(txtDetay)) return;

            Urun.Ad = txtUrun.Text;
            Urun.Katagori = cbKategori.Text;
            Urun.Fiyat = (double)nmFiyat.Value;
            Urun.Stok = (double)nmStok.Value;
            Urun.Birim = cbBirim.Text;
            Urun.Detay = txtDetay.Text;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0 )
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {

        }
    }
}

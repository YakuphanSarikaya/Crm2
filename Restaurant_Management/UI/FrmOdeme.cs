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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        public Odeme Odeme { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen tutar giriniz!");
                nmTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }

            if (cbOdeme.SelectedItem == null)
            {
                errorProvider1.SetError(cbOdeme, "Ödeme türü seçin!");
                cbOdeme.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbOdeme, "");

            }

            if (txtAciklama.Text == "")
            {
                errorProvider1.SetError(txtAciklama, "Lütfen açıklama giriniz!");
                txtAciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAciklama, "");

            }

            Odeme.Tur = cbOdeme.SelectedItem.ToString();
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Aciklama = txtAciklama.Text;
            Odeme.Tarih = dtTarih.Value;

            DialogResult = DialogResult.OK;
        }
    }
}

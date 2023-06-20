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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void lblTabTitle_Click(object sender, EventArgs e)
        {

        }

        public Musteri Musteri { get; set; }
        public bool Güncelle {get; set; } = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoy)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdr)) return;

            Musteri.Ad = txtAd.Text;
            Musteri.Soyad = txtSoy.Text;
            Musteri.Telefon = txtTel.Text;
            Musteri.Mail = txtMail.Text;
            Musteri.Adres = txtAdr.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");

                }
            }
            return true;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            txtID.Text = Musteri.ID.ToString();
            if (Güncelle)
            {
                 txtAd.Text = Musteri.Ad ;
                 txtSoy.Text = Musteri.Soyad ;
                 txtTel.Text = Musteri.Telefon ;
                  txtMail.Text = Musteri.Mail;
                 txtAdr.Text = Musteri.Adres  ;
            }
  
        }
    }
}

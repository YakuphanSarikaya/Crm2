using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenımIsletmem;
using Restaurant_Management.UI;
using Restaurant_Management.BL;

namespace Restaurant_Management
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };
            tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
               bool b = BLogic.MüşteriEkle(frmMusteri.Musteri);
                if (b)
                {   
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0]; 
                }
                else
                    goto tekrar;

            }
        
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                Güncelle = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Musteri);
                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Mail;
                    row.Cells[5].Value = frmMusteri.Musteri.Adres;
                }


            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(txtMusteriAra.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();
            

            var sonuc = MessageBox.Show("Seçili Kayıt silinsin mi?", "Silmeyi Onayla", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }


            }
        }
    }
}

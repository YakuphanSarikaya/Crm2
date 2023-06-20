using BenımIsletmem;
using Restaurant_Management.BL;
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
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun()
            {
                Text = "Müşteri Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frmUrun.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frmUrun.Urun);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView3.DataSource = ds2.Tables[0];
        }

        private void btnUrunDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            FrmUrun frmUrun = new FrmUrun()
            {
                Text = "Ürün Güncelle",
                Güncelle = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Katagori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = double.Parse(row.Cells[4].Value.ToString()),
                    Birim = row.Cells[5].Value.ToString(),
                    Detay = row.Cells[6].Value.ToString(),

                },
            };
            var sonuc = frmUrun.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGüncelle(frmUrun.Urun);
                if (b)
                {
                    row.Cells[1].Value = frmUrun.Urun.Ad;
                    row.Cells[2].Value = frmUrun.Urun.Katagori;
                    row.Cells[3].Value = frmUrun.Urun.Fiyat;
                    row.Cells[4].Value = frmUrun.Urun.Stok;
                    row.Cells[5].Value = frmUrun.Urun.Birim;
                    row.Cells[6].Value = frmUrun.Urun.Detay;
                }


            }
        }
    }
}

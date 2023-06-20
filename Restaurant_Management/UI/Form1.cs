using Restaurant_Management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            FormDashboard FrmDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }       
        
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
            btnCustomers.BackColor = btnColor;
            btnEmployees.BackColor = btnColor;
            btnMenuList.BackColor = btnColor;
            btnAnalytics.BackColor = btnColor;
            btnRestaurants.BackColor = btnColor;
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Panel";
            this.pnlContent.Controls.Clear();
            FormDashboard FrmDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnCustomers.Height;
            pnlNavIndicator.Top = btnCustomers.Top;
            pnlNavIndicator.Left = btnCustomers.Left;
            ButtonColorReset(btnCustomers);

            lblTabTitle.Text = "Müşteriler";
            this.pnlContent.Controls.Clear();
            FormCustomers FrmCustomer_Vrb = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }
        private void BtnRestaurants_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnRestaurants.Height;
            pnlNavIndicator.Top = btnRestaurants.Top;
            pnlNavIndicator.Left = btnRestaurants.Left;
            ButtonColorReset(btnRestaurants);

            lblTabTitle.Text = "İşletme";
            this.pnlContent.Controls.Clear();
            FormRestaurants FrmCustomer_Vrb = new FormRestaurants() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnEmployees.Height;
            pnlNavIndicator.Top = btnEmployees.Top;
            pnlNavIndicator.Left = btnEmployees.Left;
            ButtonColorReset(btnEmployees);

            lblTabTitle.Text = "Ürünler";
            this.pnlContent.Controls.Clear();
            FormUrunler frmMüsteri_Vrb = new FormUrunler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(frmMüsteri_Vrb);
            frmMüsteri_Vrb.Show();
        }

        private void btnMenuList_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnMenuList.Height;
            pnlNavIndicator.Top = btnMenuList.Top;
            pnlNavIndicator.Left = btnMenuList.Left;
            ButtonColorReset(btnMenuList);

            lblTabTitle.Text = "Ödemeler";
            this.pnlContent.Controls.Clear();
            FormOdemeler frmOdemeler_Vrb = new FormOdemeler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(frmOdemeler_Vrb);
            frmOdemeler_Vrb.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnAnalytics.Height;
            pnlNavIndicator.Top = btnAnalytics.Top;
            pnlNavIndicator.Left = btnAnalytics.Left;
            ButtonColorReset(btnAnalytics);

            lblTabTitle.Text = "Satışlar";
            this.pnlContent.Controls.Clear();
            FormSatislar frmSatislar_Vrb = new FormSatislar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(frmSatislar_Vrb);
            frmSatislar_Vrb.Show();
        }
    }
}

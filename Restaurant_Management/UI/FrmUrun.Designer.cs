namespace Restaurant_Management.UI
{
    partial class FrmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmStok = new System.Windows.Forms.NumericUpDown();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnCancel.Location = new System.Drawing.Point(196, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnOk.Location = new System.Drawing.Point(107, 449);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Tamam";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label6.Location = new System.Drawing.Point(27, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Detay";
            // 
            // txtDetay
            // 
            this.txtDetay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetay.Location = new System.Drawing.Point(114, 329);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetay.Size = new System.Drawing.Size(165, 91);
            this.txtDetay.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label5.Location = new System.Drawing.Point(27, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(27, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Katagori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün";
            // 
            // txtUrun
            // 
            this.txtUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrun.Location = new System.Drawing.Point(114, 128);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(165, 13);
            this.txtUrun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(114, 87);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(165, 13);
            this.txtID.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.lblTabTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 42);
            this.panel4.TabIndex = 9;
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.lblTabTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblTabTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(103, 24);
            this.lblTabTitle.TabIndex = 0;
            this.lblTabTitle.Text = "Yeni Ürün";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Beyaz Eşya",
            "Kozmetik",
            "Dondurulmuş Gıda",
            "Günlük Gıda",
            "Şarküteri",
            "Okul Eşyaları",
            "Atıştırmalık",
            "İçecek"});
            this.cbKategori.Location = new System.Drawing.Point(114, 161);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(165, 21);
            this.cbKategori.TabIndex = 2;
            // 
            // nmFiyat
            // 
            this.nmFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmFiyat.DecimalPlaces = 2;
            this.nmFiyat.Location = new System.Drawing.Point(114, 207);
            this.nmFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(165, 16);
            this.nmFiyat.TabIndex = 3;
            this.nmFiyat.ThousandsSeparator = true;
            // 
            // nmStok
            // 
            this.nmStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmStok.DecimalPlaces = 2;
            this.nmStok.Location = new System.Drawing.Point(114, 246);
            this.nmStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmStok.Name = "nmStok";
            this.nmStok.Size = new System.Drawing.Size(165, 16);
            this.nmStok.TabIndex = 4;
            this.nmStok.ThousandsSeparator = true;
            // 
            // cbBirim
            // 
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "Adet",
            "Metre",
            "Kg"});
            this.cbBirim.Location = new System.Drawing.Point(114, 285);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(165, 21);
            this.cbBirim.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label7.Location = new System.Drawing.Point(27, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Birim";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(298, 497);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmStok);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTabTitle;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.NumericUpDown nmStok;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
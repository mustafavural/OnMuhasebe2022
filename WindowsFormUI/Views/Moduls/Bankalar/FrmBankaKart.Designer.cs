namespace WindowsFormUI.Views.Moduls.Bankalar
{
    partial class FrmBankaKart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankaKart));
            this.dgvBankalar = new System.Windows.Forms.DataGridView();
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.uscBankalar = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblSubeAd = new System.Windows.Forms.Label();
            this.lblBankaAd = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtSubeAd = new System.Windows.Forms.TextBox();
            this.txtBankaAd = new System.Windows.Forms.TextBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankaSubeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankalar)).BeginInit();
            this.grpEkleGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBankalar
            // 
            this.dgvBankalar.AllowUserToAddRows = false;
            this.dgvBankalar.AllowUserToDeleteRows = false;
            this.dgvBankalar.AllowUserToResizeRows = false;
            this.dgvBankalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBankalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBankaAd,
            this.colBankaSubeAd,
            this.colHesapNo,
            this.colIBAN,
            this.colBakiye});
            this.dgvBankalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankalar.Location = new System.Drawing.Point(0, 190);
            this.dgvBankalar.MultiSelect = false;
            this.dgvBankalar.Name = "dgvBankalar";
            this.dgvBankalar.ReadOnly = true;
            this.dgvBankalar.RowHeadersVisible = false;
            this.dgvBankalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankalar.Size = new System.Drawing.Size(626, 171);
            this.dgvBankalar.TabIndex = 1;
            this.dgvBankalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankalar_CellDoubleClick);
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblStatusBar);
            this.grpEkleGuncelle.Controls.Add(this.uscBankalar);
            this.grpEkleGuncelle.Controls.Add(this.lblIBAN);
            this.grpEkleGuncelle.Controls.Add(this.lblHesapNo);
            this.grpEkleGuncelle.Controls.Add(this.lblSubeAd);
            this.grpEkleGuncelle.Controls.Add(this.lblBankaAd);
            this.grpEkleGuncelle.Controls.Add(this.txtIBAN);
            this.grpEkleGuncelle.Controls.Add(this.txtHesapNo);
            this.grpEkleGuncelle.Controls.Add(this.txtSubeAd);
            this.grpEkleGuncelle.Controls.Add(this.txtBankaAd);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(626, 190);
            this.grpEkleGuncelle.TabIndex = 0;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Banka Ekle Güncelle";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(12, 159);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 17);
            this.lblStatusBar.TabIndex = 9;
            // 
            // uscBankalar
            // 
            this.uscBankalar.BtnClear_Visible = true;
            this.uscBankalar.BtnDelete_Enable = true;
            this.uscBankalar.BtnDelete_Text = "Sil     ";
            this.uscBankalar.BtnSave_Enable = true;
            this.uscBankalar.BtnSave_Text = "Kaydet";
            this.uscBankalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscBankalar.LblStatus_Text = "";
            this.uscBankalar.Location = new System.Drawing.Point(3, 145);
            this.uscBankalar.Name = "uscBankalar";
            this.uscBankalar.Size = new System.Drawing.Size(620, 42);
            this.uscBankalar.TabIndex = 8;
            this.uscBankalar.ClickClear += new System.EventHandler(this.UscBankalar_ClickClear);
            this.uscBankalar.ClickSave += new System.EventHandler(this.UscBankalar_ClickSave);
            this.uscBankalar.ClickCancel += new System.EventHandler(this.UscBankalar_ClickCancel);
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(6, 118);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(41, 17);
            this.lblIBAN.TabIndex = 6;
            this.lblIBAN.Text = "IBAN";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(6, 88);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(61, 17);
            this.lblHesapNo.TabIndex = 4;
            this.lblHesapNo.Text = "Hesap No";
            // 
            // lblSubeAd
            // 
            this.lblSubeAd.AutoSize = true;
            this.lblSubeAd.Location = new System.Drawing.Point(6, 58);
            this.lblSubeAd.Name = "lblSubeAd";
            this.lblSubeAd.Size = new System.Drawing.Size(52, 17);
            this.lblSubeAd.TabIndex = 2;
            this.lblSubeAd.Text = "Şube Ad";
            // 
            // lblBankaAd
            // 
            this.lblBankaAd.AutoSize = true;
            this.lblBankaAd.Location = new System.Drawing.Point(6, 28);
            this.lblBankaAd.Name = "lblBankaAd";
            this.lblBankaAd.Size = new System.Drawing.Size(58, 17);
            this.lblBankaAd.TabIndex = 0;
            this.lblBankaAd.Text = "Banka Ad";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIBAN.Location = new System.Drawing.Point(66, 115);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(548, 24);
            this.txtIBAN.TabIndex = 7;
            this.txtIBAN.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapNo.Location = new System.Drawing.Point(66, 85);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(548, 24);
            this.txtHesapNo.TabIndex = 5;
            this.txtHesapNo.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // txtSubeAd
            // 
            this.txtSubeAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubeAd.Location = new System.Drawing.Point(66, 55);
            this.txtSubeAd.Name = "txtSubeAd";
            this.txtSubeAd.Size = new System.Drawing.Size(548, 24);
            this.txtSubeAd.TabIndex = 3;
            this.txtSubeAd.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // txtBankaAd
            // 
            this.txtBankaAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankaAd.Location = new System.Drawing.Point(66, 25);
            this.txtBankaAd.Name = "txtBankaAd";
            this.txtBankaAd.Size = new System.Drawing.Size(548, 24);
            this.txtBankaAd.TabIndex = 1;
            this.txtBankaAd.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colBankaAd
            // 
            this.colBankaAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankaAd.DataPropertyName = "BankaAd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.colBankaAd.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBankaAd.HeaderText = "Banka Adı";
            this.colBankaAd.Name = "colBankaAd";
            this.colBankaAd.ReadOnly = true;
            this.colBankaAd.Width = 87;
            // 
            // colBankaSubeAd
            // 
            this.colBankaSubeAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankaSubeAd.DataPropertyName = "BankaSubeAd";
            this.colBankaSubeAd.HeaderText = "Şube Adı";
            this.colBankaSubeAd.Name = "colBankaSubeAd";
            this.colBankaSubeAd.ReadOnly = true;
            this.colBankaSubeAd.Width = 81;
            // 
            // colHesapNo
            // 
            this.colHesapNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHesapNo.DataPropertyName = "HesapNo";
            dataGridViewCellStyle2.NullValue = null;
            this.colHesapNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colHesapNo.HeaderText = "Hesap Numarası";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.ReadOnly = true;
            this.colHesapNo.Width = 122;
            // 
            // colIBAN
            // 
            this.colIBAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIBAN.DataPropertyName = "IBAN";
            this.colIBAN.HeaderText = "IBAN";
            this.colIBAN.Name = "colIBAN";
            this.colIBAN.ReadOnly = true;
            this.colIBAN.Width = 66;
            // 
            // colBakiye
            // 
            this.colBakiye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBakiye.DataPropertyName = "Bakiye";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "---------";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colBakiye.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBakiye.HeaderText = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.ReadOnly = true;
            // 
            // FrmBankaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 361);
            this.Controls.Add(this.dgvBankalar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(642, 800);
            this.MinimumSize = new System.Drawing.Size(642, 400);
            this.Name = "FrmBankaKart";
            this.Text = "Banka Kartı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBankaKart_FormClosing);
            this.Load += new System.EventHandler(this.FrmBankaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankalar)).EndInit();
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankalar;
        private System.Windows.Forms.GroupBox grpEkleGuncelle;
        private System.Windows.Forms.Label lblStatusBar;
        private UserControls.UscFormButtons uscBankalar;
        private System.Windows.Forms.Label lblBankaAd;
        private System.Windows.Forms.TextBox txtBankaAd;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblSubeAd;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtSubeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankaSubeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBakiye;
    }
}
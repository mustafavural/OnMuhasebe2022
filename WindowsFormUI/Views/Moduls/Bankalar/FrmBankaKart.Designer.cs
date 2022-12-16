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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankaKart));
            this.dgvBankalar = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.uscBankalar = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblBankaAd = new System.Windows.Forms.Label();
            this.txtBankaAd = new System.Windows.Forms.TextBox();
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
            this.colAd});
            this.dgvBankalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankalar.Location = new System.Drawing.Point(0, 141);
            this.dgvBankalar.MultiSelect = false;
            this.dgvBankalar.Name = "dgvBankalar";
            this.dgvBankalar.ReadOnly = true;
            this.dgvBankalar.RowHeadersVisible = false;
            this.dgvBankalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankalar.Size = new System.Drawing.Size(318, 146);
            this.dgvBankalar.TabIndex = 1;
            this.dgvBankalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankalar_CellDoubleClick);
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
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.colAd.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAd.HeaderText = "Banka Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblStatusBar);
            this.grpEkleGuncelle.Controls.Add(this.uscBankalar);
            this.grpEkleGuncelle.Controls.Add(this.lblBankaAd);
            this.grpEkleGuncelle.Controls.Add(this.txtBankaAd);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(318, 141);
            this.grpEkleGuncelle.TabIndex = 0;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Banka Ekle Güncelle";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(6, 61);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 17);
            this.lblStatusBar.TabIndex = 2;
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
            this.uscBankalar.Location = new System.Drawing.Point(3, 77);
            this.uscBankalar.Name = "uscBankalar";
            this.uscBankalar.Size = new System.Drawing.Size(312, 61);
            this.uscBankalar.TabIndex = 3;
            this.uscBankalar.ClickClear += new System.EventHandler(this.UscBankalar_ClickClear);
            this.uscBankalar.ClickSave += new System.EventHandler(this.UscBankalar_ClickSave);
            this.uscBankalar.ClickCancel += new System.EventHandler(this.UscBankalar_ClickCancel);
            // 
            // lblBankaAd
            // 
            this.lblBankaAd.AutoSize = true;
            this.lblBankaAd.Location = new System.Drawing.Point(6, 28);
            this.lblBankaAd.Name = "lblBankaAd";
            this.lblBankaAd.Size = new System.Drawing.Size(51, 17);
            this.lblBankaAd.TabIndex = 0;
            this.lblBankaAd.Text = "Banka Ad";
            // 
            // txtBankaAd
            // 
            this.txtBankaAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankaAd.Location = new System.Drawing.Point(66, 25);
            this.txtBankaAd.Name = "txtBankaAd";
            this.txtBankaAd.Size = new System.Drawing.Size(240, 24);
            this.txtBankaAd.TabIndex = 1;
            this.txtBankaAd.TextChanged += new System.EventHandler(this.TxtBankaAd_TextChanged);
            // 
            // FrmBankaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 287);
            this.Controls.Add(this.dgvBankalar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
    }
}
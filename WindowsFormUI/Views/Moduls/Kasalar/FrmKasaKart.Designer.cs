namespace WindowsFormUI.Views.Moduls.Kasalar
{
    partial class FrmKasaKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaKart));
            this.dgvKasalar = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.uscKasalar = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblKasaAd = new System.Windows.Forms.Label();
            this.txtKasaAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasalar)).BeginInit();
            this.grpEkleGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKasalar
            // 
            this.dgvKasalar.AllowUserToAddRows = false;
            this.dgvKasalar.AllowUserToDeleteRows = false;
            this.dgvKasalar.AllowUserToResizeRows = false;
            this.dgvKasalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKasalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAd});
            this.dgvKasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKasalar.Location = new System.Drawing.Point(0, 141);
            this.dgvKasalar.MultiSelect = false;
            this.dgvKasalar.Name = "dgvKasalar";
            this.dgvKasalar.ReadOnly = true;
            this.dgvKasalar.RowHeadersVisible = false;
            this.dgvKasalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasalar.Size = new System.Drawing.Size(318, 146);
            this.dgvKasalar.TabIndex = 1;
            this.dgvKasalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKasalar_CellDoubleClick);
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
            this.colAd.HeaderText = "Kasa Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblStatusBar);
            this.grpEkleGuncelle.Controls.Add(this.uscKasalar);
            this.grpEkleGuncelle.Controls.Add(this.lblKasaAd);
            this.grpEkleGuncelle.Controls.Add(this.txtKasaAd);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(318, 141);
            this.grpEkleGuncelle.TabIndex = 0;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Kasa Ekle Güncelle";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(6, 61);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 17);
            this.lblStatusBar.TabIndex = 2;
            // 
            // uscKasalar
            // 
            this.uscKasalar.BtnClear_Visible = true;
            this.uscKasalar.BtnDelete_Enable = true;
            this.uscKasalar.BtnDelete_Text = "Sil     ";
            this.uscKasalar.BtnSave_Enable = true;
            this.uscKasalar.BtnSave_Text = "Kaydet";
            this.uscKasalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscKasalar.LblStatus_Text = "";
            this.uscKasalar.Location = new System.Drawing.Point(3, 77);
            this.uscKasalar.Name = "uscKasalar";
            this.uscKasalar.Size = new System.Drawing.Size(312, 61);
            this.uscKasalar.TabIndex = 3;
            this.uscKasalar.ClickClear += new System.EventHandler(this.UscKasalar_ClickClear);
            this.uscKasalar.ClickSave += new System.EventHandler(this.UscKasalar_ClickSave);
            this.uscKasalar.ClickCancel += new System.EventHandler(this.UscKasalar_ClickCancel);
            // 
            // lblKasaAd
            // 
            this.lblKasaAd.AutoSize = true;
            this.lblKasaAd.Location = new System.Drawing.Point(6, 28);
            this.lblKasaAd.Name = "lblKasaAd";
            this.lblKasaAd.Size = new System.Drawing.Size(51, 17);
            this.lblKasaAd.TabIndex = 0;
            this.lblKasaAd.Text = "Kasa Ad";
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaAd.Location = new System.Drawing.Point(66, 25);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(240, 24);
            this.txtKasaAd.TabIndex = 1;
            this.txtKasaAd.TextChanged += new System.EventHandler(this.TxtKasaAd_TextChanged);
            // 
            // FrmKasaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 287);
            this.Controls.Add(this.dgvKasalar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKasaKart";
            this.Text = "Kasa Kartı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKasaKart_FormClosing);
            this.Load += new System.EventHandler(this.FrmKasaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasalar)).EndInit();
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKasalar;
        private System.Windows.Forms.GroupBox grpEkleGuncelle;
        private System.Windows.Forms.Label lblStatusBar;
        private UserControls.UscFormButtons uscKasalar;
        private System.Windows.Forms.Label lblKasaAd;
        private System.Windows.Forms.TextBox txtKasaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
    }
}
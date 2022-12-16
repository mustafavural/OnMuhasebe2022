namespace WindowsFormUI.Views.Moduls.Bankalar
{
    partial class FrmBankaKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBankaHareketler = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBankaHareket = new System.Windows.Forms.GroupBox();
            this.dtpBankaTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.uscBankaButtons = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.btnEvrakBul = new System.Windows.Forms.Button();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblCariAd = new System.Windows.Forms.Label();
            this.btnBankaBul = new System.Windows.Forms.Button();
            this.txtBankaAd = new System.Windows.Forms.TextBox();
            this.lblBankaAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankaHareketler)).BeginInit();
            this.grpBankaHareket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBankaHareketler
            // 
            this.dgvBankaHareketler.AllowUserToAddRows = false;
            this.dgvBankaHareketler.AllowUserToDeleteRows = false;
            this.dgvBankaHareketler.AllowUserToResizeRows = false;
            this.dgvBankaHareketler.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankaHareketler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankaHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankaHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBankaId,
            this.colCariId,
            this.colBankaAd,
            this.colEvrakNo,
            this.colMiktar,
            this.colCariAd,
            this.colTarih,
            this.colAciklama});
            this.dgvBankaHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankaHareketler.Location = new System.Drawing.Point(0, 142);
            this.dgvBankaHareketler.MultiSelect = false;
            this.dgvBankaHareketler.Name = "dgvBankaHareketler";
            this.dgvBankaHareketler.ReadOnly = true;
            this.dgvBankaHareketler.RowHeadersVisible = false;
            this.dgvBankaHareketler.RowTemplate.Height = 25;
            this.dgvBankaHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankaHareketler.Size = new System.Drawing.Size(713, 185);
            this.dgvBankaHareketler.TabIndex = 1;
            this.dgvBankaHareketler.TabStop = false;
            this.dgvBankaHareketler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankaHareketler_CellContentDoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colBankaId
            // 
            this.colBankaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankaId.DataPropertyName = "BankaId";
            this.colBankaId.HeaderText = "Banka Id";
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.ReadOnly = true;
            this.colBankaId.Visible = false;
            // 
            // colCariId
            // 
            this.colCariId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCariId.DataPropertyName = "CariId";
            this.colCariId.HeaderText = "Cari Id";
            this.colCariId.Name = "colCariId";
            this.colCariId.ReadOnly = true;
            this.colCariId.Visible = false;
            // 
            // colBankaAd
            // 
            this.colBankaAd.DataPropertyName = "BankaAd";
            this.colBankaAd.HeaderText = "Banka Adı";
            this.colBankaAd.Name = "colBankaAd";
            this.colBankaAd.ReadOnly = true;
            this.colBankaAd.Visible = false;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEvrakNo.DataPropertyName = "EvrakNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colEvrakNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEvrakNo.HeaderText = "Evrak No";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.ReadOnly = true;
            this.colEvrakNo.Width = 85;
            // 
            // colMiktar
            // 
            this.colMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMiktar.DataPropertyName = "GirenCikanMiktar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "#,###.## TL";
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            this.colMiktar.Width = 71;
            // 
            // colCariAd
            // 
            this.colCariAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCariAd.DataPropertyName = "Unvan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colCariAd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCariAd.FillWeight = 310F;
            this.colCariAd.HeaderText = "Cari Adı";
            this.colCariAd.Name = "colCariAd";
            this.colCariAd.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colTarih.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            this.colTarih.Width = 63;
            // 
            // colAciklama
            // 
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAciklama.HeaderText = "Aciklama";
            this.colAciklama.MinimumWidth = 150;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            this.colAciklama.Width = 150;
            // 
            // grpBankaHareket
            // 
            this.grpBankaHareket.Controls.Add(this.dtpBankaTarih);
            this.grpBankaHareket.Controls.Add(this.txtCariKod);
            this.grpBankaHareket.Controls.Add(this.uscBankaButtons);
            this.grpBankaHareket.Controls.Add(this.btnCariBul);
            this.grpBankaHareket.Controls.Add(this.btnEvrakBul);
            this.grpBankaHareket.Controls.Add(this.lblCariKod);
            this.grpBankaHareket.Controls.Add(this.txtEvrakNo);
            this.grpBankaHareket.Controls.Add(this.txtAciklama);
            this.grpBankaHareket.Controls.Add(this.txtMiktar);
            this.grpBankaHareket.Controls.Add(this.lblTarih);
            this.grpBankaHareket.Controls.Add(this.lblEvrakNo);
            this.grpBankaHareket.Controls.Add(this.lblAciklama);
            this.grpBankaHareket.Controls.Add(this.lblMiktar);
            this.grpBankaHareket.Controls.Add(this.lblCariAd);
            this.grpBankaHareket.Controls.Add(this.btnBankaBul);
            this.grpBankaHareket.Controls.Add(this.txtBankaAd);
            this.grpBankaHareket.Controls.Add(this.lblBankaAd);
            this.grpBankaHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBankaHareket.Location = new System.Drawing.Point(0, 0);
            this.grpBankaHareket.Name = "grpBankaHareket";
            this.grpBankaHareket.Size = new System.Drawing.Size(713, 142);
            this.grpBankaHareket.TabIndex = 0;
            this.grpBankaHareket.TabStop = false;
            this.grpBankaHareket.Text = "İşlem Bilgileri";
            // 
            // dtpBankaTarih
            // 
            this.dtpBankaTarih.Enabled = false;
            this.dtpBankaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBankaTarih.Location = new System.Drawing.Point(73, 82);
            this.dtpBankaTarih.Name = "dtpBankaTarih";
            this.dtpBankaTarih.Size = new System.Drawing.Size(112, 24);
            this.dtpBankaTarih.TabIndex = 15;
            this.dtpBankaTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Enabled = false;
            this.txtCariKod.Location = new System.Drawing.Point(72, 49);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(112, 24);
            this.txtCariKod.TabIndex = 8;
            this.txtCariKod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // uscBankaButtons
            // 
            this.uscBankaButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscBankaButtons.BtnClear_Visible = false;
            this.uscBankaButtons.BtnDelete_Enable = false;
            this.uscBankaButtons.BtnDelete_Text = "Sil     ";
            this.uscBankaButtons.BtnSave_Enable = false;
            this.uscBankaButtons.BtnSave_Text = "Kaydet";
            this.uscBankaButtons.LblStatus_Text = "";
            this.uscBankaButtons.Location = new System.Drawing.Point(191, 82);
            this.uscBankaButtons.Name = "uscBankaButtons";
            this.uscBankaButtons.Size = new System.Drawing.Size(510, 53);
            this.uscBankaButtons.TabIndex = 16;
            this.uscBankaButtons.ClickClear += new System.EventHandler(this.UscBankaButtons_ClickClear);
            this.uscBankaButtons.ClickSave += new System.EventHandler(this.UscBankaButtons_ClickSave);
            this.uscBankaButtons.ClickCancel += new System.EventHandler(this.UscBankaButtons_ClickCancel);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.Enabled = false;
            this.btnCariBul.FlatAppearance.BorderSize = 0;
            this.btnCariBul.Location = new System.Drawing.Point(190, 47);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(24, 26);
            this.btnCariBul.TabIndex = 9;
            this.btnCariBul.TabStop = false;
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.BtnCariBul_Click);
            // 
            // btnEvrakBul
            // 
            this.btnEvrakBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Banka_Hareket32x32;
            this.btnEvrakBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvrakBul.Enabled = false;
            this.btnEvrakBul.FlatAppearance.BorderSize = 0;
            this.btnEvrakBul.Location = new System.Drawing.Point(400, 15);
            this.btnEvrakBul.Name = "btnEvrakBul";
            this.btnEvrakBul.Size = new System.Drawing.Size(24, 26);
            this.btnEvrakBul.TabIndex = 5;
            this.btnEvrakBul.TabStop = false;
            this.btnEvrakBul.UseVisualStyleBackColor = true;
            this.btnEvrakBul.Click += new System.EventHandler(this.BtnEvrakBul_Click);
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(12, 52);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(54, 17);
            this.lblCariKod.TabIndex = 7;
            this.lblCariKod.Text = "Cari Kod";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Enabled = false;
            this.txtEvrakNo.Location = new System.Drawing.Point(282, 17);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(112, 24);
            this.txtEvrakNo.TabIndex = 4;
            this.txtEvrakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtEvrakNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Enabled = false;
            this.txtAciklama.Location = new System.Drawing.Point(460, 49);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(241, 24);
            this.txtAciklama.TabIndex = 13;
            this.txtAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(282, 49);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(112, 24);
            this.txtMiktar.TabIndex = 11;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtMiktar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(12, 86);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 17);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Tarih";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(221, 20);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(60, 17);
            this.lblEvrakNo.TabIndex = 3;
            this.lblEvrakNo.Text = "Evrak No";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(400, 52);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 12;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(222, 52);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(46, 17);
            this.lblMiktar.TabIndex = 10;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblCariAd
            // 
            this.lblCariAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCariAd.Location = new System.Drawing.Point(430, 20);
            this.lblCariAd.Name = "lblCariAd";
            this.lblCariAd.Size = new System.Drawing.Size(271, 17);
            this.lblCariAd.TabIndex = 6;
            // 
            // btnBankaBul
            // 
            this.btnBankaBul.FlatAppearance.BorderSize = 0;
            this.btnBankaBul.Image = global::WindowsFormUI.Properties.Resources.Banka_Karti16x16;
            this.btnBankaBul.Location = new System.Drawing.Point(191, 17);
            this.btnBankaBul.Name = "btnBankaBul";
            this.btnBankaBul.Size = new System.Drawing.Size(24, 26);
            this.btnBankaBul.TabIndex = 2;
            this.btnBankaBul.TabStop = false;
            this.btnBankaBul.UseVisualStyleBackColor = true;
            this.btnBankaBul.Click += new System.EventHandler(this.BtnBankaBul_Click);
            // 
            // txtBankaAd
            // 
            this.txtBankaAd.Location = new System.Drawing.Point(73, 17);
            this.txtBankaAd.Name = "txtBankaAd";
            this.txtBankaAd.Size = new System.Drawing.Size(112, 24);
            this.txtBankaAd.TabIndex = 1;
            this.txtBankaAd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // lblBankaAd
            // 
            this.lblBankaAd.AutoSize = true;
            this.lblBankaAd.Location = new System.Drawing.Point(12, 20);
            this.lblBankaAd.Name = "lblBankaAd";
            this.lblBankaAd.Size = new System.Drawing.Size(55, 17);
            this.lblBankaAd.TabIndex = 0;
            this.lblBankaAd.Text = "Banka Adı";
            // 
            // FrmBankaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 327);
            this.Controls.Add(this.dgvBankaHareketler);
            this.Controls.Add(this.grpBankaHareket);
            this.MaximumSize = new System.Drawing.Size(729, 800);
            this.MinimumSize = new System.Drawing.Size(729, 366);
            this.Name = "FrmBankaKayit";
            this.Text = "Banka İşlemleri";
            this.Load += new System.EventHandler(this.FrmBankaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankaHareketler)).EndInit();
            this.grpBankaHareket.ResumeLayout(false);
            this.grpBankaHareket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankaHareketler;
        private System.Windows.Forms.GroupBox grpBankaHareket;
        private System.Windows.Forms.Button btnBankaBul;
        private System.Windows.Forms.TextBox txtBankaAd;
        private System.Windows.Forms.Label lblBankaAd;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.Button btnEvrakBul;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.Label lblCariAd;
        private System.Windows.Forms.DateTimePicker dtpBankaTarih;
        private UserControls.UscFormButtons uscBankaButtons;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
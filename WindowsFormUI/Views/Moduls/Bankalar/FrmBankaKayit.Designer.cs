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
            this.colEvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnHesapBul = new System.Windows.Forms.Button();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.lblHesapNo = new System.Windows.Forms.Label();
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
            this.colEvrakNo,
            this.colCariAd,
            this.colMiktar,
            this.colTarih,
            this.colAciklama});
            this.dgvBankaHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankaHareketler.Location = new System.Drawing.Point(0, 156);
            this.dgvBankaHareketler.MultiSelect = false;
            this.dgvBankaHareketler.Name = "dgvBankaHareketler";
            this.dgvBankaHareketler.ReadOnly = true;
            this.dgvBankaHareketler.RowHeadersVisible = false;
            this.dgvBankaHareketler.RowTemplate.Height = 25;
            this.dgvBankaHareketler.Size = new System.Drawing.Size(713, 171);
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
            // colCariAd
            // 
            this.colCariAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCariAd.DataPropertyName = "Unvan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colCariAd.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCariAd.FillWeight = 310F;
            this.colCariAd.HeaderText = "Cari Adı";
            this.colCariAd.Name = "colCariAd";
            this.colCariAd.ReadOnly = true;
            // 
            // colMiktar
            // 
            this.colMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMiktar.DataPropertyName = "GirenCikanMiktar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "#,###.## TL";
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            this.colMiktar.Width = 71;
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
            this.grpBankaHareket.Controls.Add(this.btnHesapBul);
            this.grpBankaHareket.Controls.Add(this.txtHesapNo);
            this.grpBankaHareket.Controls.Add(this.lblHesapNo);
            this.grpBankaHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBankaHareket.Location = new System.Drawing.Point(0, 0);
            this.grpBankaHareket.Name = "grpBankaHareket";
            this.grpBankaHareket.Size = new System.Drawing.Size(713, 156);
            this.grpBankaHareket.TabIndex = 0;
            this.grpBankaHareket.TabStop = false;
            this.grpBankaHareket.Text = "İşlem Bilgileri";
            // 
            // dtpBankaTarih
            // 
            this.dtpBankaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBankaTarih.Location = new System.Drawing.Point(474, 47);
            this.dtpBankaTarih.Name = "dtpBankaTarih";
            this.dtpBankaTarih.Size = new System.Drawing.Size(141, 24);
            this.dtpBankaTarih.TabIndex = 13;
            this.dtpBankaTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(282, 17);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(112, 24);
            this.txtCariKod.TabIndex = 4;
            this.txtCariKod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // uscBankaButtons
            // 
            this.uscBankaButtons.BtnClear_Visible = true;
            this.uscBankaButtons.BtnDelete_Enable = true;
            this.uscBankaButtons.BtnDelete_Text = "Sil     ";
            this.uscBankaButtons.BtnSave_Enable = true;
            this.uscBankaButtons.BtnSave_Text = "Kaydet";
            this.uscBankaButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscBankaButtons.LblStatus_Text = "";
            this.uscBankaButtons.Location = new System.Drawing.Point(3, 107);
            this.uscBankaButtons.Name = "uscBankaButtons";
            this.uscBankaButtons.Size = new System.Drawing.Size(707, 46);
            this.uscBankaButtons.TabIndex = 16;
            this.uscBankaButtons.TabStop = false;
            this.uscBankaButtons.ClickClear += new System.EventHandler(this.UscBankaButtons_ClickClear);
            this.uscBankaButtons.ClickSave += new System.EventHandler(this.UscBankaButtons_ClickSave);
            this.uscBankaButtons.ClickCancel += new System.EventHandler(this.UscBankaButtons_ClickCancel);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.FlatAppearance.BorderSize = 0;
            this.btnCariBul.Location = new System.Drawing.Point(400, 17);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(24, 24);
            this.btnCariBul.TabIndex = 5;
            this.btnCariBul.TabStop = false;
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.BtnCariBul_Click);
            // 
            // btnEvrakBul
            // 
            this.btnEvrakBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Banka_Hareket32x32;
            this.btnEvrakBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvrakBul.FlatAppearance.BorderSize = 0;
            this.btnEvrakBul.Location = new System.Drawing.Point(191, 47);
            this.btnEvrakBul.Name = "btnEvrakBul";
            this.btnEvrakBul.Size = new System.Drawing.Size(24, 24);
            this.btnEvrakBul.TabIndex = 9;
            this.btnEvrakBul.TabStop = false;
            this.btnEvrakBul.UseVisualStyleBackColor = true;
            this.btnEvrakBul.Click += new System.EventHandler(this.BtnEvrakBul_Click);
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(222, 20);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(54, 17);
            this.lblCariKod.TabIndex = 3;
            this.lblCariKod.Text = "Cari Kod";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(73, 47);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(112, 24);
            this.txtEvrakNo.TabIndex = 8;
            this.txtEvrakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtEvrakNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(73, 77);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(542, 24);
            this.txtAciklama.TabIndex = 15;
            this.txtAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(282, 47);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(142, 24);
            this.txtMiktar.TabIndex = 11;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtMiktar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(430, 50);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 17);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "Tarih";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(6, 50);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(60, 17);
            this.lblEvrakNo.TabIndex = 7;
            this.lblEvrakNo.Text = "Evrak No";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(6, 80);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 14;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(221, 50);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(46, 17);
            this.lblMiktar.TabIndex = 10;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblCariAd
            // 
            this.lblCariAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCariAd.Location = new System.Drawing.Point(430, 17);
            this.lblCariAd.Name = "lblCariAd";
            this.lblCariAd.Size = new System.Drawing.Size(277, 20);
            this.lblCariAd.TabIndex = 6;
            // 
            // btnHesapBul
            // 
            this.btnHesapBul.FlatAppearance.BorderSize = 0;
            this.btnHesapBul.Image = global::WindowsFormUI.Properties.Resources.Banka_Kartı16x16;
            this.btnHesapBul.Location = new System.Drawing.Point(191, 17);
            this.btnHesapBul.Name = "btnHesapBul";
            this.btnHesapBul.Size = new System.Drawing.Size(24, 24);
            this.btnHesapBul.TabIndex = 2;
            this.btnHesapBul.TabStop = false;
            this.btnHesapBul.UseVisualStyleBackColor = true;
            this.btnHesapBul.Click += new System.EventHandler(this.BtnHesapBul_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(73, 17);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(112, 24);
            this.txtHesapNo.TabIndex = 1;
            this.txtHesapNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(6, 20);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(61, 17);
            this.lblHesapNo.TabIndex = 0;
            this.lblHesapNo.Text = "Hesap No";
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
        private System.Windows.Forms.Button btnHesapBul;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label lblHesapNo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
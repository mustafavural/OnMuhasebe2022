namespace WindowsFormUI.Views.Moduls.Kasalar
{
    partial class FrmKasaKayit
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
            this.dgvKasaHareketler = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKasaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKasaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpKasaHareket = new System.Windows.Forms.GroupBox();
            this.dtpKasaTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.uscKasaButtons = new WindowsFormUI.Views.UserControls.UscFormButtons();
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
            this.btnKasaBul = new System.Windows.Forms.Button();
            this.txtKasaAd = new System.Windows.Forms.TextBox();
            this.lblKasaAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketler)).BeginInit();
            this.grpKasaHareket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKasaHareketler
            // 
            this.dgvKasaHareketler.AllowUserToAddRows = false;
            this.dgvKasaHareketler.AllowUserToDeleteRows = false;
            this.dgvKasaHareketler.AllowUserToResizeRows = false;
            this.dgvKasaHareketler.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKasaHareketler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKasaHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKasaId,
            this.colCariId,
            this.colKasaAd,
            this.colEvrakNo,
            this.colMiktar,
            this.colCariAd,
            this.colTarih,
            this.colAciklama});
            this.dgvKasaHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKasaHareketler.Location = new System.Drawing.Point(0, 142);
            this.dgvKasaHareketler.MultiSelect = false;
            this.dgvKasaHareketler.Name = "dgvKasaHareketler";
            this.dgvKasaHareketler.ReadOnly = true;
            this.dgvKasaHareketler.RowHeadersVisible = false;
            this.dgvKasaHareketler.RowTemplate.Height = 25;
            this.dgvKasaHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasaHareketler.Size = new System.Drawing.Size(713, 185);
            this.dgvKasaHareketler.TabIndex = 1;
            this.dgvKasaHareketler.TabStop = false;
            this.dgvKasaHareketler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKasaHareketler_CellContentDoubleClick);
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
            // colKasaId
            // 
            this.colKasaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKasaId.DataPropertyName = "KasaId";
            this.colKasaId.HeaderText = "Kasa Id";
            this.colKasaId.Name = "colKasaId";
            this.colKasaId.ReadOnly = true;
            this.colKasaId.Visible = false;
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
            // colKasaAd
            // 
            this.colKasaAd.DataPropertyName = "KasaAd";
            this.colKasaAd.HeaderText = "Kasa Adı";
            this.colKasaAd.Name = "colKasaAd";
            this.colKasaAd.ReadOnly = true;
            this.colKasaAd.Visible = false;
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
            // grpKasaHareket
            // 
            this.grpKasaHareket.Controls.Add(this.dtpKasaTarih);
            this.grpKasaHareket.Controls.Add(this.txtCariKod);
            this.grpKasaHareket.Controls.Add(this.uscKasaButtons);
            this.grpKasaHareket.Controls.Add(this.btnCariBul);
            this.grpKasaHareket.Controls.Add(this.btnEvrakBul);
            this.grpKasaHareket.Controls.Add(this.lblCariKod);
            this.grpKasaHareket.Controls.Add(this.txtEvrakNo);
            this.grpKasaHareket.Controls.Add(this.txtAciklama);
            this.grpKasaHareket.Controls.Add(this.txtMiktar);
            this.grpKasaHareket.Controls.Add(this.lblTarih);
            this.grpKasaHareket.Controls.Add(this.lblEvrakNo);
            this.grpKasaHareket.Controls.Add(this.lblAciklama);
            this.grpKasaHareket.Controls.Add(this.lblMiktar);
            this.grpKasaHareket.Controls.Add(this.lblCariAd);
            this.grpKasaHareket.Controls.Add(this.btnKasaBul);
            this.grpKasaHareket.Controls.Add(this.txtKasaAd);
            this.grpKasaHareket.Controls.Add(this.lblKasaAd);
            this.grpKasaHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.grpKasaHareket.Name = "grpKasaHareket";
            this.grpKasaHareket.Size = new System.Drawing.Size(713, 142);
            this.grpKasaHareket.TabIndex = 0;
            this.grpKasaHareket.TabStop = false;
            this.grpKasaHareket.Text = "İşlem Bilgileri";
            // 
            // dtpKasaTarih
            // 
            this.dtpKasaTarih.Enabled = false;
            this.dtpKasaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKasaTarih.Location = new System.Drawing.Point(73, 82);
            this.dtpKasaTarih.Name = "dtpKasaTarih";
            this.dtpKasaTarih.Size = new System.Drawing.Size(112, 24);
            this.dtpKasaTarih.TabIndex = 15;
            this.dtpKasaTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
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
            // uscKasaButtons
            // 
            this.uscKasaButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscKasaButtons.BtnClear_Visible = false;
            this.uscKasaButtons.BtnDelete_Enable = false;
            this.uscKasaButtons.BtnDelete_Text = "Sil     ";
            this.uscKasaButtons.BtnSave_Enable = false;
            this.uscKasaButtons.BtnSave_Text = "Kaydet";
            this.uscKasaButtons.LblStatus_Text = "";
            this.uscKasaButtons.Location = new System.Drawing.Point(191, 82);
            this.uscKasaButtons.Name = "uscKasaButtons";
            this.uscKasaButtons.Size = new System.Drawing.Size(510, 53);
            this.uscKasaButtons.TabIndex = 16;
            this.uscKasaButtons.ClickClear += new System.EventHandler(this.UscKasaButtons_ClickClear);
            this.uscKasaButtons.ClickSave += new System.EventHandler(this.UscKasaButtons_ClickSave);
            this.uscKasaButtons.ClickCancel += new System.EventHandler(this.UscKasaButtons_ClickCancel);
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
            this.btnEvrakBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Kasa_Hareket32x32;
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
            // btnKasaBul
            // 
            this.btnKasaBul.FlatAppearance.BorderSize = 0;
            this.btnKasaBul.Image = global::WindowsFormUI.Properties.Resources.Kasa_Karti16x16;
            this.btnKasaBul.Location = new System.Drawing.Point(191, 17);
            this.btnKasaBul.Name = "btnKasaBul";
            this.btnKasaBul.Size = new System.Drawing.Size(24, 26);
            this.btnKasaBul.TabIndex = 2;
            this.btnKasaBul.TabStop = false;
            this.btnKasaBul.UseVisualStyleBackColor = true;
            this.btnKasaBul.Click += new System.EventHandler(this.BtnKasaBul_Click);
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Location = new System.Drawing.Point(73, 17);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(112, 24);
            this.txtKasaAd.TabIndex = 1;
            this.txtKasaAd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ThrowLeaveOnlyWithTabKey);
            // 
            // lblKasaAd
            // 
            this.lblKasaAd.AutoSize = true;
            this.lblKasaAd.Location = new System.Drawing.Point(12, 20);
            this.lblKasaAd.Name = "lblKasaAd";
            this.lblKasaAd.Size = new System.Drawing.Size(55, 17);
            this.lblKasaAd.TabIndex = 0;
            this.lblKasaAd.Text = "Kasa Adı";
            // 
            // FrmKasaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 327);
            this.Controls.Add(this.dgvKasaHareketler);
            this.Controls.Add(this.grpKasaHareket);
            this.MaximumSize = new System.Drawing.Size(729, 800);
            this.MinimumSize = new System.Drawing.Size(729, 366);
            this.Name = "FrmKasaKayit";
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.FrmKasaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketler)).EndInit();
            this.grpKasaHareket.ResumeLayout(false);
            this.grpKasaHareket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKasaHareketler;
        private System.Windows.Forms.GroupBox grpKasaHareket;
        private System.Windows.Forms.Button btnKasaBul;
        private System.Windows.Forms.TextBox txtKasaAd;
        private System.Windows.Forms.Label lblKasaAd;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.Button btnEvrakBul;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.Label lblCariAd;
        private System.Windows.Forms.DateTimePicker dtpKasaTarih;
        private UserControls.UscFormButtons uscKasaButtons;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKasaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKasaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
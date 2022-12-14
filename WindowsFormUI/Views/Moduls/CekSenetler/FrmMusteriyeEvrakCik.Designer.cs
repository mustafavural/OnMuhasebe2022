namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmMusteriyeEvrakCik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriyeEvrakCik));
            this.dgvMusteridenEvrakAl = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsilBorclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUstBilgiler = new System.Windows.Forms.Panel();
            this.grpEvrakBilgiler = new System.Windows.Forms.GroupBox();
            this.uscEvrakEkleGuncelleSil = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.btnEvrakBul = new System.Windows.Forms.Button();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.grpBordroBilgiler = new System.Windows.Forms.GroupBox();
            this.lblBordroKod = new System.Windows.Forms.Label();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.dtpAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.btnBordroNoBul = new System.Windows.Forms.Button();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.txtBordroAciklama = new System.Windows.Forms.TextBox();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.lblCikisTarih = new System.Windows.Forms.Label();
            this.lblBordroAciklama = new System.Windows.Forms.Label();
            this.uscMusteriyeEvrakCik = new WindowsFormUI.Views.UserControls.UscFormButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteridenEvrakAl)).BeginInit();
            this.pnlUstBilgiler.SuspendLayout();
            this.grpEvrakBilgiler.SuspendLayout();
            this.grpBordroBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteridenEvrakAl
            // 
            this.dgvMusteridenEvrakAl.AllowUserToAddRows = false;
            this.dgvMusteridenEvrakAl.AllowUserToDeleteRows = false;
            this.dgvMusteridenEvrakAl.AllowUserToResizeRows = false;
            this.dgvMusteridenEvrakAl.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteridenEvrakAl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteridenEvrakAl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteridenEvrakAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMusteridenEvrakAl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNo,
            this.colVade,
            this.colTutar,
            this.colAsilBorclu,
            this.colAciklama});
            this.dgvMusteridenEvrakAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteridenEvrakAl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMusteridenEvrakAl.EnableHeadersVisualStyles = false;
            this.dgvMusteridenEvrakAl.Location = new System.Drawing.Point(0, 175);
            this.dgvMusteridenEvrakAl.MultiSelect = false;
            this.dgvMusteridenEvrakAl.Name = "dgvMusteridenEvrakAl";
            this.dgvMusteridenEvrakAl.ReadOnly = true;
            this.dgvMusteridenEvrakAl.RowHeadersVisible = false;
            this.dgvMusteridenEvrakAl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMusteridenEvrakAl.RowTemplate.Height = 25;
            this.dgvMusteridenEvrakAl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteridenEvrakAl.Size = new System.Drawing.Size(757, 288);
            this.dgvMusteridenEvrakAl.TabIndex = 1;
            this.dgvMusteridenEvrakAl.TabStop = false;
            this.dgvMusteridenEvrakAl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMusteridenEvrakAl_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colVade
            // 
            this.colVade.DataPropertyName = "Vade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colVade.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVade.HeaderText = "Vadesi";
            this.colVade.Name = "colVade";
            this.colVade.ReadOnly = true;
            // 
            // colTutar
            // 
            this.colTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "#,###.## TL";
            dataGridViewCellStyle4.NullValue = null;
            this.colTutar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTutar.HeaderText = "Tutarı";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.DataPropertyName = "AsilBorclu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colAsilBorclu.DefaultCellStyle = dataGridViewCellStyle5;
            this.colAsilBorclu.HeaderText = "Asıl Borçlu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.ReadOnly = true;
            this.colAsilBorclu.Width = 200;
            // 
            // colAciklama
            // 
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // pnlUstBilgiler
            // 
            this.pnlUstBilgiler.Controls.Add(this.grpEvrakBilgiler);
            this.pnlUstBilgiler.Controls.Add(this.grpBordroBilgiler);
            this.pnlUstBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBilgiler.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBilgiler.Name = "pnlUstBilgiler";
            this.pnlUstBilgiler.Size = new System.Drawing.Size(757, 175);
            this.pnlUstBilgiler.TabIndex = 0;
            // 
            // grpEvrakBilgiler
            // 
            this.grpEvrakBilgiler.Controls.Add(this.uscEvrakEkleGuncelleSil);
            this.grpEvrakBilgiler.Controls.Add(this.btnEvrakBul);
            this.grpEvrakBilgiler.Controls.Add(this.txtEvrakNo);
            this.grpEvrakBilgiler.Controls.Add(this.lblEvrakNo);
            this.grpEvrakBilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEvrakBilgiler.Location = new System.Drawing.Point(0, 107);
            this.grpEvrakBilgiler.Name = "grpEvrakBilgiler";
            this.grpEvrakBilgiler.Size = new System.Drawing.Size(757, 68);
            this.grpEvrakBilgiler.TabIndex = 11;
            this.grpEvrakBilgiler.TabStop = false;
            this.grpEvrakBilgiler.Text = "Evrak Bilgileri";
            // 
            // uscEvrakEkleGuncelleSil
            // 
            this.uscEvrakEkleGuncelleSil.BtnClear_Visible = false;
            this.uscEvrakEkleGuncelleSil.BtnDelete_Enable = false;
            this.uscEvrakEkleGuncelleSil.BtnDelete_Text = "Sil     ";
            this.uscEvrakEkleGuncelleSil.BtnSave_Enable = false;
            this.uscEvrakEkleGuncelleSil.BtnSave_Text = "Ekle   ";
            this.uscEvrakEkleGuncelleSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.uscEvrakEkleGuncelleSil.LblStatus_Text = "";
            this.uscEvrakEkleGuncelleSil.Location = new System.Drawing.Point(170, 20);
            this.uscEvrakEkleGuncelleSil.Name = "uscEvrakEkleGuncelleSil";
            this.uscEvrakEkleGuncelleSil.Size = new System.Drawing.Size(584, 45);
            this.uscEvrakEkleGuncelleSil.TabIndex = 3;
            this.uscEvrakEkleGuncelleSil.TabStop = false;
            this.uscEvrakEkleGuncelleSil.ClickClear += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickClear);
            this.uscEvrakEkleGuncelleSil.ClickCancel += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickCancel);
            // 
            // btnEvrakBul
            // 
            this.btnEvrakBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEvrakBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_BordroLst32x32;
            this.btnEvrakBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvrakBul.Location = new System.Drawing.Point(120, 18);
            this.btnEvrakBul.Name = "btnEvrakBul";
            this.btnEvrakBul.Size = new System.Drawing.Size(44, 44);
            this.btnEvrakBul.TabIndex = 2;
            this.btnEvrakBul.TabStop = false;
            this.btnEvrakBul.UseVisualStyleBackColor = true;
            this.btnEvrakBul.Click += new System.EventHandler(this.BtnEvrakBul_Click);
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEvrakNo.Location = new System.Drawing.Point(3, 38);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(111, 24);
            this.txtEvrakNo.TabIndex = 1;
            this.txtEvrakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.txtEvrakNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(12, 18);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(69, 17);
            this.lblEvrakNo.TabIndex = 0;
            this.lblEvrakNo.Text = "Evrak Kodu";
            // 
            // grpBordroBilgiler
            // 
            this.grpBordroBilgiler.Controls.Add(this.lblBordroKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariKod);
            this.grpBordroBilgiler.Controls.Add(this.dtpAlisTarih);
            this.grpBordroBilgiler.Controls.Add(this.btnBordroNoBul);
            this.grpBordroBilgiler.Controls.Add(this.btnCariBul);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroAciklama);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroNo);
            this.grpBordroBilgiler.Controls.Add(this.txtCariKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariUnvan);
            this.grpBordroBilgiler.Controls.Add(this.lblCikisTarih);
            this.grpBordroBilgiler.Controls.Add(this.lblBordroAciklama);
            this.grpBordroBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBordroBilgiler.Location = new System.Drawing.Point(0, 0);
            this.grpBordroBilgiler.Name = "grpBordroBilgiler";
            this.grpBordroBilgiler.Size = new System.Drawing.Size(757, 107);
            this.grpBordroBilgiler.TabIndex = 0;
            this.grpBordroBilgiler.TabStop = false;
            this.grpBordroBilgiler.Text = "Bordro Bilgileri";
            // 
            // lblBordroKod
            // 
            this.lblBordroKod.AutoSize = true;
            this.lblBordroKod.Location = new System.Drawing.Point(12, 21);
            this.lblBordroKod.Name = "lblBordroKod";
            this.lblBordroKod.Size = new System.Drawing.Size(66, 17);
            this.lblBordroKod.TabIndex = 0;
            this.lblBordroKod.Text = "Bordro No";
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(182, 21);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(60, 17);
            this.lblCariKod.TabIndex = 3;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // dtpAlisTarih
            // 
            this.dtpAlisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlisTarih.Location = new System.Drawing.Point(349, 42);
            this.dtpAlisTarih.Name = "dtpAlisTarih";
            this.dtpAlisTarih.Size = new System.Drawing.Size(111, 24);
            this.dtpAlisTarih.TabIndex = 8;
            this.dtpAlisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpInputEngelle);
            this.dtpAlisTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // btnBordroNoBul
            // 
            this.btnBordroNoBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.btnBordroNoBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBordroNoBul.Location = new System.Drawing.Point(120, 22);
            this.btnBordroNoBul.Name = "btnBordroNoBul";
            this.btnBordroNoBul.Size = new System.Drawing.Size(44, 44);
            this.btnBordroNoBul.TabIndex = 2;
            this.btnBordroNoBul.TabStop = false;
            this.btnBordroNoBul.UseVisualStyleBackColor = true;
            this.btnBordroNoBul.Click += new System.EventHandler(this.BtnBordroNoBul_Click);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.Location = new System.Drawing.Point(299, 22);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(44, 44);
            this.btnCariBul.TabIndex = 5;
            this.btnCariBul.TabStop = false;
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.BtnCariBul_Click);
            // 
            // txtBordroAciklama
            // 
            this.txtBordroAciklama.Location = new System.Drawing.Point(469, 42);
            this.txtBordroAciklama.Name = "txtBordroAciklama";
            this.txtBordroAciklama.Size = new System.Drawing.Size(276, 24);
            this.txtBordroAciklama.TabIndex = 10;
            this.txtBordroAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Location = new System.Drawing.Point(3, 42);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Size = new System.Drawing.Size(111, 24);
            this.txtBordroNo.TabIndex = 1;
            this.txtBordroNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.txtBordroNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(182, 42);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(111, 24);
            this.txtCariKod.TabIndex = 4;
            this.txtCariKod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCariUnvan.Location = new System.Drawing.Point(3, 77);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(751, 27);
            this.lblCariUnvan.TabIndex = 6;
            this.lblCariUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCikisTarih
            // 
            this.lblCikisTarih.AutoSize = true;
            this.lblCikisTarih.Location = new System.Drawing.Point(349, 21);
            this.lblCikisTarih.Name = "lblCikisTarih";
            this.lblCikisTarih.Size = new System.Drawing.Size(73, 17);
            this.lblCikisTarih.TabIndex = 7;
            this.lblCikisTarih.Text = "Cikis Tarihi";
            // 
            // lblBordroAciklama
            // 
            this.lblBordroAciklama.AutoSize = true;
            this.lblBordroAciklama.Location = new System.Drawing.Point(469, 22);
            this.lblBordroAciklama.Name = "lblBordroAciklama";
            this.lblBordroAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblBordroAciklama.TabIndex = 9;
            this.lblBordroAciklama.Text = "Açıklama";
            // 
            // uscMusteriyeEvrakCik
            // 
            this.uscMusteriyeEvrakCik.BtnClear_Visible = true;
            this.uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            this.uscMusteriyeEvrakCik.BtnDelete_Text = "Sil     ";
            this.uscMusteriyeEvrakCik.BtnSave_Enable = true;
            this.uscMusteriyeEvrakCik.BtnSave_Text = "Kaydet";
            this.uscMusteriyeEvrakCik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscMusteriyeEvrakCik.LblStatus_Text = "";
            this.uscMusteriyeEvrakCik.Location = new System.Drawing.Point(0, 463);
            this.uscMusteriyeEvrakCik.Name = "uscMusteriyeEvrakCik";
            this.uscMusteriyeEvrakCik.Size = new System.Drawing.Size(757, 44);
            this.uscMusteriyeEvrakCik.TabIndex = 2;
            this.uscMusteriyeEvrakCik.TabStop = false;
            // 
            // FrmMusteriyeEvrakCik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 507);
            this.Controls.Add(this.dgvMusteridenEvrakAl);
            this.Controls.Add(this.pnlUstBilgiler);
            this.Controls.Add(this.uscMusteriyeEvrakCik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteriyeEvrakCik";
            this.Text = "Müşteriye Portföyden Evrak Çık";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteridenEvrakAl)).EndInit();
            this.pnlUstBilgiler.ResumeLayout(false);
            this.grpEvrakBilgiler.ResumeLayout(false);
            this.grpEvrakBilgiler.PerformLayout();
            this.grpBordroBilgiler.ResumeLayout(false);
            this.grpBordroBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteridenEvrakAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsilBorclu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.Panel pnlUstBilgiler;
        private System.Windows.Forms.GroupBox grpEvrakBilgiler;
        private UserControls.UscFormButtons uscEvrakEkleGuncelleSil;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.GroupBox grpBordroBilgiler;
        private System.Windows.Forms.Label lblBordroKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.DateTimePicker dtpAlisTarih;
        private System.Windows.Forms.Button btnBordroNoBul;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtBordroAciklama;
        private System.Windows.Forms.TextBox txtBordroNo;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.Label lblCikisTarih;
        private System.Windows.Forms.Label lblBordroAciklama;
        private UserControls.UscFormButtons uscMusteriyeEvrakCik;
        private System.Windows.Forms.Button btnEvrakBul;
    }
}
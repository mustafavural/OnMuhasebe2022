namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmBorcEvrakCik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorcEvrakCik));
            this.grpEvrakBilgiler = new System.Windows.Forms.GroupBox();
            this.uscEvrakEkleGuncelleSil = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.dtpVade = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblVade = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.dtpCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.lblCikisTarih = new System.Windows.Forms.Label();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.dgvEvrakCik = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscBorcEvrakCik = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.pnlUstBilgiler = new System.Windows.Forms.Panel();
            this.grpBordroBilgiler = new System.Windows.Forms.GroupBox();
            this.lblBordroKod = new System.Windows.Forms.Label();
            this.btnBordroNoBul = new System.Windows.Forms.Button();
            this.txtBordroAciklama = new System.Windows.Forms.TextBox();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.lblBordroAciklama = new System.Windows.Forms.Label();
            this.grpEvrakBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakCik)).BeginInit();
            this.pnlUstBilgiler.SuspendLayout();
            this.grpBordroBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEvrakBilgiler
            // 
            this.grpEvrakBilgiler.Controls.Add(this.uscEvrakEkleGuncelleSil);
            this.grpEvrakBilgiler.Controls.Add(this.dtpVade);
            this.grpEvrakBilgiler.Controls.Add(this.txtAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.txtTutar);
            this.grpEvrakBilgiler.Controls.Add(this.txtEvrakNo);
            this.grpEvrakBilgiler.Controls.Add(this.lblVade);
            this.grpEvrakBilgiler.Controls.Add(this.lblAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.lblTutar);
            this.grpEvrakBilgiler.Controls.Add(this.lblEvrakNo);
            this.grpEvrakBilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEvrakBilgiler.Location = new System.Drawing.Point(217, 0);
            this.grpEvrakBilgiler.Name = "grpEvrakBilgiler";
            this.grpEvrakBilgiler.Size = new System.Drawing.Size(539, 175);
            this.grpEvrakBilgiler.TabIndex = 1;
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
            this.uscEvrakEkleGuncelleSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscEvrakEkleGuncelleSil.LblStatus_Text = "";
            this.uscEvrakEkleGuncelleSil.Location = new System.Drawing.Point(3, 122);
            this.uscEvrakEkleGuncelleSil.Name = "uscEvrakEkleGuncelleSil";
            this.uscEvrakEkleGuncelleSil.Size = new System.Drawing.Size(533, 50);
            this.uscEvrakEkleGuncelleSil.TabIndex = 10;
            this.uscEvrakEkleGuncelleSil.TabStop = false;
            this.uscEvrakEkleGuncelleSil.ClickClear += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickClear);
            this.uscEvrakEkleGuncelleSil.ClickSave += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickSave);
            // 
            // dtpVade
            // 
            this.dtpVade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVade.Location = new System.Drawing.Point(257, 23);
            this.dtpVade.Name = "dtpVade";
            this.dtpVade.Size = new System.Drawing.Size(100, 24);
            this.dtpVade.TabIndex = 3;
            this.dtpVade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.dtpVade.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(87, 53);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(446, 24);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(413, 23);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 24);
            this.txtTutar.TabIndex = 5;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDecimalHarfEngelle);
            this.txtTutar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(87, 23);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(114, 24);
            this.txtEvrakNo.TabIndex = 1;
            this.txtEvrakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.txtEvrakNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblVade
            // 
            this.lblVade.AutoSize = true;
            this.lblVade.Location = new System.Drawing.Point(207, 26);
            this.lblVade.Name = "lblVade";
            this.lblVade.Size = new System.Drawing.Size(44, 17);
            this.lblVade.TabIndex = 2;
            this.lblVade.Text = "Vadesi";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(12, 56);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(363, 26);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(44, 17);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutarı";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(12, 26);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(69, 17);
            this.lblEvrakNo.TabIndex = 0;
            this.lblEvrakNo.Text = "Evrak Kodu";
            // 
            // dtpCikisTarih
            // 
            this.dtpCikisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCikisTarih.Location = new System.Drawing.Point(78, 78);
            this.dtpCikisTarih.Name = "dtpCikisTarih";
            this.dtpCikisTarih.Size = new System.Drawing.Size(133, 24);
            this.dtpCikisTarih.TabIndex = 4;
            this.dtpCikisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.dtpCikisTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(78, 48);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(111, 24);
            this.txtCariKod.TabIndex = 1;
            this.txtCariKod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.Location = new System.Drawing.Point(190, 48);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(25, 24);
            this.btnCariBul.TabIndex = 2;
            this.btnCariBul.TabStop = false;
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.BtnCariBul_Click);
            // 
            // lblCikisTarih
            // 
            this.lblCikisTarih.AutoSize = true;
            this.lblCikisTarih.Location = new System.Drawing.Point(6, 81);
            this.lblCikisTarih.Name = "lblCikisTarih";
            this.lblCikisTarih.Size = new System.Drawing.Size(73, 17);
            this.lblCikisTarih.TabIndex = 3;
            this.lblCikisTarih.Text = "Çıkış Tarihi";
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCariUnvan.Location = new System.Drawing.Point(3, 145);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(211, 27);
            this.lblCariUnvan.TabIndex = 7;
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(6, 51);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(60, 17);
            this.lblCariKod.TabIndex = 0;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // dgvEvrakCik
            // 
            this.dgvEvrakCik.AllowUserToAddRows = false;
            this.dgvEvrakCik.AllowUserToDeleteRows = false;
            this.dgvEvrakCik.AllowUserToResizeRows = false;
            this.dgvEvrakCik.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvrakCik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvrakCik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvrakCik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvrakCik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNo,
            this.colVade,
            this.colTutar,
            this.colAciklama});
            this.dgvEvrakCik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvrakCik.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvrakCik.EnableHeadersVisualStyles = false;
            this.dgvEvrakCik.Location = new System.Drawing.Point(0, 175);
            this.dgvEvrakCik.MultiSelect = false;
            this.dgvEvrakCik.Name = "dgvEvrakCik";
            this.dgvEvrakCik.ReadOnly = true;
            this.dgvEvrakCik.RowHeadersVisible = false;
            this.dgvEvrakCik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEvrakCik.RowTemplate.Height = 25;
            this.dgvEvrakCik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvrakCik.Size = new System.Drawing.Size(756, 171);
            this.dgvEvrakCik.TabIndex = 2;
            this.dgvEvrakCik.TabStop = false;
            this.dgvEvrakCik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorcEvrakCik_CellDoubleClick);
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
            // colAciklama
            // 
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle5;
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // uscBorcEvrakCik
            // 
            this.uscBorcEvrakCik.BtnClear_Visible = true;
            this.uscBorcEvrakCik.BtnDelete_Enable = true;
            this.uscBorcEvrakCik.BtnDelete_Text = "Sil     ";
            this.uscBorcEvrakCik.BtnSave_Enable = true;
            this.uscBorcEvrakCik.BtnSave_Text = "Kaydet";
            this.uscBorcEvrakCik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscBorcEvrakCik.LblStatus_Text = "";
            this.uscBorcEvrakCik.Location = new System.Drawing.Point(0, 346);
            this.uscBorcEvrakCik.Name = "uscBorcEvrakCik";
            this.uscBorcEvrakCik.Size = new System.Drawing.Size(756, 44);
            this.uscBorcEvrakCik.TabIndex = 1;
            this.uscBorcEvrakCik.TabStop = false;
            this.uscBorcEvrakCik.ClickClear += new System.EventHandler(this.UscBorcEvrakCik_ClickClear);
            this.uscBorcEvrakCik.ClickSave += new System.EventHandler(this.UscBorcEvrakCik_ClickSave);
            this.uscBorcEvrakCik.ClickCancel += new System.EventHandler(this.UscBorcEvrakCik_ClickCancel);
            // 
            // pnlUstBilgiler
            // 
            this.pnlUstBilgiler.Controls.Add(this.grpEvrakBilgiler);
            this.pnlUstBilgiler.Controls.Add(this.grpBordroBilgiler);
            this.pnlUstBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBilgiler.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBilgiler.Name = "pnlUstBilgiler";
            this.pnlUstBilgiler.Size = new System.Drawing.Size(756, 175);
            this.pnlUstBilgiler.TabIndex = 0;
            // 
            // grpBordroBilgiler
            // 
            this.grpBordroBilgiler.Controls.Add(this.lblBordroKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariKod);
            this.grpBordroBilgiler.Controls.Add(this.dtpCikisTarih);
            this.grpBordroBilgiler.Controls.Add(this.btnBordroNoBul);
            this.grpBordroBilgiler.Controls.Add(this.btnCariBul);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroAciklama);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroNo);
            this.grpBordroBilgiler.Controls.Add(this.txtCariKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariUnvan);
            this.grpBordroBilgiler.Controls.Add(this.lblCikisTarih);
            this.grpBordroBilgiler.Controls.Add(this.lblBordroAciklama);
            this.grpBordroBilgiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBordroBilgiler.Location = new System.Drawing.Point(0, 0);
            this.grpBordroBilgiler.Name = "grpBordroBilgiler";
            this.grpBordroBilgiler.Size = new System.Drawing.Size(217, 175);
            this.grpBordroBilgiler.TabIndex = 0;
            this.grpBordroBilgiler.TabStop = false;
            this.grpBordroBilgiler.Text = "Bordro Bilgileri";
            // 
            // lblBordroKod
            // 
            this.lblBordroKod.AutoSize = true;
            this.lblBordroKod.Location = new System.Drawing.Point(6, 21);
            this.lblBordroKod.Name = "lblBordroKod";
            this.lblBordroKod.Size = new System.Drawing.Size(66, 17);
            this.lblBordroKod.TabIndex = 0;
            this.lblBordroKod.Text = "Bordro No";
            // 
            // btnBordroNoBul
            // 
            this.btnBordroNoBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.btnBordroNoBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBordroNoBul.Location = new System.Drawing.Point(190, 18);
            this.btnBordroNoBul.Name = "btnBordroNoBul";
            this.btnBordroNoBul.Size = new System.Drawing.Size(25, 24);
            this.btnBordroNoBul.TabIndex = 2;
            this.btnBordroNoBul.TabStop = false;
            this.btnBordroNoBul.UseVisualStyleBackColor = true;
            this.btnBordroNoBul.Click += new System.EventHandler(this.BtnBordroNoBul_Click);
            // 
            // txtBordroAciklama
            // 
            this.txtBordroAciklama.Location = new System.Drawing.Point(78, 108);
            this.txtBordroAciklama.Name = "txtBordroAciklama";
            this.txtBordroAciklama.Size = new System.Drawing.Size(133, 24);
            this.txtBordroAciklama.TabIndex = 6;
            this.txtBordroAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Location = new System.Drawing.Point(78, 18);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Size = new System.Drawing.Size(111, 24);
            this.txtBordroNo.TabIndex = 1;
            this.txtBordroNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.txtBordroNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblBordroAciklama
            // 
            this.lblBordroAciklama.AutoSize = true;
            this.lblBordroAciklama.Location = new System.Drawing.Point(6, 111);
            this.lblBordroAciklama.Name = "lblBordroAciklama";
            this.lblBordroAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblBordroAciklama.TabIndex = 5;
            this.lblBordroAciklama.Text = "Açıklama";
            // 
            // FrmMusteriyeBorcEvrakCik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 390);
            this.Controls.Add(this.dgvEvrakCik);
            this.Controls.Add(this.pnlUstBilgiler);
            this.Controls.Add(this.uscBorcEvrakCik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(772, 556);
            this.MinimumSize = new System.Drawing.Size(772, 429);
            this.Name = "FrmMusteriyeBorcEvrakCik";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Muşteriye Borç Evrağı Ver";
            this.Load += new System.EventHandler(this.FrmBorcEvrakCik_Load);
            this.grpEvrakBilgiler.ResumeLayout(false);
            this.grpEvrakBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakCik)).EndInit();
            this.pnlUstBilgiler.ResumeLayout(false);
            this.grpBordroBilgiler.ResumeLayout(false);
            this.grpBordroBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvrakBilgiler;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.DateTimePicker dtpVade;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblVade;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.DateTimePicker dtpCikisTarih;
        private System.Windows.Forms.Label lblCikisTarih;
        private UserControls.UscFormButtons uscEvrakEkleGuncelleSil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridView dgvEvrakCik;
        private UserControls.UscFormButtons uscBorcEvrakCik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlUstBilgiler;
        private System.Windows.Forms.GroupBox grpBordroBilgiler;
        private System.Windows.Forms.TextBox txtBordroAciklama;
        private System.Windows.Forms.Label lblBordroAciklama;
        private System.Windows.Forms.Label lblBordroKod;
        private System.Windows.Forms.Button btnBordroNoBul;
        private System.Windows.Forms.TextBox txtBordroNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
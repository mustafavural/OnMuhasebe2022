namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmEvrakAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvrakAl));
            this.grpEvrakBilgiler = new System.Windows.Forms.GroupBox();
            this.uscEvrak = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.dtpVade = new System.Windows.Forms.DateTimePicker();
            this.txtAsilBorclu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblVade = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblAsilBorclu = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.dtpAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.lblAlisTarih = new System.Windows.Forms.Label();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.dgvEvraklar = new System.Windows.Forms.DataGridView();
            this.uscBordro = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.pnlUstBilgiler = new System.Windows.Forms.Panel();
            this.grpBordroBilgiler = new System.Windows.Forms.GroupBox();
            this.lblBordroKod = new System.Windows.Forms.Label();
            this.btnBordroBul = new System.Windows.Forms.Button();
            this.txtBordroAciklama = new System.Windows.Forms.TextBox();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.lblBordroAciklama = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsilBorclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEvrakBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvraklar)).BeginInit();
            this.pnlUstBilgiler.SuspendLayout();
            this.grpBordroBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEvrakBilgiler
            // 
            this.grpEvrakBilgiler.Controls.Add(this.uscEvrak);
            this.grpEvrakBilgiler.Controls.Add(this.dtpVade);
            this.grpEvrakBilgiler.Controls.Add(this.txtAsilBorclu);
            this.grpEvrakBilgiler.Controls.Add(this.txtAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.txtTutar);
            this.grpEvrakBilgiler.Controls.Add(this.txtEvrakNo);
            this.grpEvrakBilgiler.Controls.Add(this.lblVade);
            this.grpEvrakBilgiler.Controls.Add(this.lblAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.lblAsilBorclu);
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
            // uscEvrak
            // 
            this.uscEvrak.BtnClear_Visible = false;
            this.uscEvrak.BtnDelete_Enable = false;
            this.uscEvrak.BtnDelete_Text = "Sil     ";
            this.uscEvrak.BtnSave_Enable = false;
            this.uscEvrak.BtnSave_Text = "Ekle   ";
            this.uscEvrak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscEvrak.LblStatus_Text = "";
            this.uscEvrak.Location = new System.Drawing.Point(3, 122);
            this.uscEvrak.Name = "uscEvrak";
            this.uscEvrak.Size = new System.Drawing.Size(533, 50);
            this.uscEvrak.TabIndex = 10;
            this.uscEvrak.TabStop = false;
            this.uscEvrak.ClickClear += new System.EventHandler(this.UscEvrak_ClickClear);
            this.uscEvrak.ClickSave += new System.EventHandler(this.UscEvrak_ClickSave);
            this.uscEvrak.ClickCancel += new System.EventHandler(this.UscEvrak_ClickCancel);
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
            // txtAsilBorclu
            // 
            this.txtAsilBorclu.Location = new System.Drawing.Point(87, 53);
            this.txtAsilBorclu.Name = "txtAsilBorclu";
            this.txtAsilBorclu.Size = new System.Drawing.Size(446, 24);
            this.txtAsilBorclu.TabIndex = 7;
            this.txtAsilBorclu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(87, 83);
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
            this.lblAciklama.Location = new System.Drawing.Point(12, 86);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblAsilBorclu
            // 
            this.lblAsilBorclu.AutoSize = true;
            this.lblAsilBorclu.Location = new System.Drawing.Point(12, 56);
            this.lblAsilBorclu.Name = "lblAsilBorclu";
            this.lblAsilBorclu.Size = new System.Drawing.Size(70, 17);
            this.lblAsilBorclu.TabIndex = 6;
            this.lblAsilBorclu.Text = "Asıl Borçlu";
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
            // dtpAlisTarih
            // 
            this.dtpAlisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlisTarih.Location = new System.Drawing.Point(78, 78);
            this.dtpAlisTarih.Name = "dtpAlisTarih";
            this.dtpAlisTarih.Size = new System.Drawing.Size(133, 24);
            this.dtpAlisTarih.TabIndex = 4;
            this.dtpAlisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBelgeNoHarfEngelle);
            this.dtpAlisTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
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
            // lblAlisTarih
            // 
            this.lblAlisTarih.AutoSize = true;
            this.lblAlisTarih.Location = new System.Drawing.Point(6, 81);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(68, 17);
            this.lblAlisTarih.TabIndex = 3;
            this.lblAlisTarih.Text = "Alış Tarihi";
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
            // dgvEvraklar
            // 
            this.dgvEvraklar.AllowUserToAddRows = false;
            this.dgvEvraklar.AllowUserToDeleteRows = false;
            this.dgvEvraklar.AllowUserToResizeRows = false;
            this.dgvEvraklar.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvraklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvraklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvraklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvraklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNo,
            this.colVade,
            this.colTutar,
            this.colAsilBorclu,
            this.colAciklama});
            this.dgvEvraklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvraklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvraklar.EnableHeadersVisualStyles = false;
            this.dgvEvraklar.Location = new System.Drawing.Point(0, 175);
            this.dgvEvraklar.MultiSelect = false;
            this.dgvEvraklar.Name = "dgvEvraklar";
            this.dgvEvraklar.ReadOnly = true;
            this.dgvEvraklar.RowHeadersVisible = false;
            this.dgvEvraklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEvraklar.RowTemplate.Height = 25;
            this.dgvEvraklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvraklar.Size = new System.Drawing.Size(756, 171);
            this.dgvEvraklar.TabIndex = 2;
            this.dgvEvraklar.TabStop = false;
            this.dgvEvraklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEvraklar_CellDoubleClick);
            // 
            // uscBordro
            // 
            this.uscBordro.BtnClear_Visible = true;
            this.uscBordro.BtnDelete_Enable = true;
            this.uscBordro.BtnDelete_Text = "Sil     ";
            this.uscBordro.BtnSave_Enable = true;
            this.uscBordro.BtnSave_Text = "Kaydet";
            this.uscBordro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscBordro.LblStatus_Text = "";
            this.uscBordro.Location = new System.Drawing.Point(0, 346);
            this.uscBordro.Name = "uscBordro";
            this.uscBordro.Size = new System.Drawing.Size(756, 44);
            this.uscBordro.TabIndex = 1;
            this.uscBordro.TabStop = false;
            this.uscBordro.ClickClear += new System.EventHandler(this.UscBordro_ClickClear);
            this.uscBordro.ClickSave += new System.EventHandler(this.UscBordro_ClickSave);
            this.uscBordro.ClickCancel += new System.EventHandler(this.UscBordro_ClickCancel);
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
            this.grpBordroBilgiler.Controls.Add(this.dtpAlisTarih);
            this.grpBordroBilgiler.Controls.Add(this.btnBordroBul);
            this.grpBordroBilgiler.Controls.Add(this.btnCariBul);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroAciklama);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroNo);
            this.grpBordroBilgiler.Controls.Add(this.txtCariKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariUnvan);
            this.grpBordroBilgiler.Controls.Add(this.lblAlisTarih);
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
            // btnBordroBul
            // 
            this.btnBordroBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.btnBordroBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBordroBul.Location = new System.Drawing.Point(190, 18);
            this.btnBordroBul.Name = "btnBordroBul";
            this.btnBordroBul.Size = new System.Drawing.Size(25, 24);
            this.btnBordroBul.TabIndex = 2;
            this.btnBordroBul.TabStop = false;
            this.btnBordroBul.UseVisualStyleBackColor = true;
            this.btnBordroBul.Click += new System.EventHandler(this.BtnBordroNoBul_Click);
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
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            this.colId.Width = 46;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNo.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 49;
            // 
            // colVade
            // 
            this.colVade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVade.DataPropertyName = "Vade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colVade.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVade.HeaderText = "Vadesi";
            this.colVade.Name = "colVade";
            this.colVade.ReadOnly = true;
            this.colVade.Width = 69;
            // 
            // colTutar
            // 
            this.colTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "#,###.## TL";
            dataGridViewCellStyle4.NullValue = null;
            this.colTutar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTutar.HeaderText = "Tutarı";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            this.colTutar.Width = 69;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAsilBorclu.DataPropertyName = "AsilBorclu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colAsilBorclu.DefaultCellStyle = dataGridViewCellStyle5;
            this.colAsilBorclu.HeaderText = "Asıl Borçlu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.ReadOnly = true;
            this.colAsilBorclu.Width = 95;
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
            // FrmEvrakAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 390);
            this.Controls.Add(this.dgvEvraklar);
            this.Controls.Add(this.pnlUstBilgiler);
            this.Controls.Add(this.uscBordro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(772, 556);
            this.MinimumSize = new System.Drawing.Size(772, 429);
            this.Name = "FrmEvrakAl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Muşteriden Evrak Al";
            this.grpEvrakBilgiler.ResumeLayout(false);
            this.grpEvrakBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvraklar)).EndInit();
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
        private System.Windows.Forms.TextBox txtAsilBorclu;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblVade;
        private System.Windows.Forms.Label lblAsilBorclu;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.DateTimePicker dtpAlisTarih;
        private System.Windows.Forms.Label lblAlisTarih;
        private UserControls.UscFormButtons uscEvrakEkleGuncelleSil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridView dgvEvraklar;
        private UserControls.UscFormButtons uscEvrakAl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlUstBilgiler;
        private System.Windows.Forms.GroupBox grpBordroBilgiler;
        private System.Windows.Forms.TextBox txtBordroAciklama;
        private System.Windows.Forms.Label lblBordroAciklama;
        private System.Windows.Forms.Label lblBordroKod;
        private System.Windows.Forms.Button btnBordroBul;
        private System.Windows.Forms.TextBox txtBordroNo;
        private UserControls.UscFormButtons uscEvrak;
        private UserControls.UscFormButtons uscBordro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsilBorclu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
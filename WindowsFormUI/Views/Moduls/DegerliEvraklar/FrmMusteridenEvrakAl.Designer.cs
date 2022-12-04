namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    partial class FrmMusteridenEvrakAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteridenEvrakAl));
            this.grpEvrakBilgiler = new System.Windows.Forms.GroupBox();
            this.uscEvrakEkleGuncelleSil = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.dtpAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpVade = new System.Windows.Forms.DateTimePicker();
            this.txtAsilBorclu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtEvrakKod = new System.Windows.Forms.TextBox();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.lblAlisTarih = new System.Windows.Forms.Label();
            this.lblVade = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblAsilBorclu = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblEvrakKod = new System.Windows.Forms.Label();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.dgvMusteridenEvrakAl = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlinanCariId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlınanCariUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsilBorclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscMusteriyeEvrakCik = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.grpEvrakBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteridenEvrakAl)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvrakBilgiler
            // 
            this.grpEvrakBilgiler.Controls.Add(this.uscEvrakEkleGuncelleSil);
            this.grpEvrakBilgiler.Controls.Add(this.dtpAlisTarih);
            this.grpEvrakBilgiler.Controls.Add(this.dtpVade);
            this.grpEvrakBilgiler.Controls.Add(this.txtAsilBorclu);
            this.grpEvrakBilgiler.Controls.Add(this.txtAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.txtTutar);
            this.grpEvrakBilgiler.Controls.Add(this.txtEvrakKod);
            this.grpEvrakBilgiler.Controls.Add(this.txtCariKod);
            this.grpEvrakBilgiler.Controls.Add(this.btnCariBul);
            this.grpEvrakBilgiler.Controls.Add(this.lblAlisTarih);
            this.grpEvrakBilgiler.Controls.Add(this.lblVade);
            this.grpEvrakBilgiler.Controls.Add(this.lblAciklama);
            this.grpEvrakBilgiler.Controls.Add(this.lblAsilBorclu);
            this.grpEvrakBilgiler.Controls.Add(this.lblTutar);
            this.grpEvrakBilgiler.Controls.Add(this.lblEvrakKod);
            this.grpEvrakBilgiler.Controls.Add(this.lblCariUnvan);
            this.grpEvrakBilgiler.Controls.Add(this.lblCariKod);
            this.grpEvrakBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEvrakBilgiler.Location = new System.Drawing.Point(0, 0);
            this.grpEvrakBilgiler.Name = "grpEvrakBilgiler";
            this.grpEvrakBilgiler.Size = new System.Drawing.Size(708, 156);
            this.grpEvrakBilgiler.TabIndex = 0;
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
            this.uscEvrakEkleGuncelleSil.Location = new System.Drawing.Point(3, 109);
            this.uscEvrakEkleGuncelleSil.Name = "uscEvrakEkleGuncelleSil";
            this.uscEvrakEkleGuncelleSil.Size = new System.Drawing.Size(702, 44);
            this.uscEvrakEkleGuncelleSil.TabIndex = 16;
            this.uscEvrakEkleGuncelleSil.ClickClear += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickClear);
            this.uscEvrakEkleGuncelleSil.ClickSave += new System.EventHandler(this.UscEvrakEkleGuncelleSil_ClickSave);
            // 
            // dtpAlisTarih
            // 
            this.dtpAlisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlisTarih.Location = new System.Drawing.Point(597, 48);
            this.dtpAlisTarih.Name = "dtpAlisTarih";
            this.dtpAlisTarih.Size = new System.Drawing.Size(100, 24);
            this.dtpAlisTarih.TabIndex = 11;
            this.dtpAlisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpInputEngelle);
            // 
            // dtpVade
            // 
            this.dtpVade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVade.Location = new System.Drawing.Point(243, 47);
            this.dtpVade.Name = "dtpVade";
            this.dtpVade.Size = new System.Drawing.Size(100, 24);
            this.dtpVade.TabIndex = 7;
            this.dtpVade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpInputEngelle);
            // 
            // txtAsilBorclu
            // 
            this.txtAsilBorclu.Location = new System.Drawing.Point(87, 77);
            this.txtAsilBorclu.Name = "txtAsilBorclu";
            this.txtAsilBorclu.Size = new System.Drawing.Size(256, 24);
            this.txtAsilBorclu.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(411, 78);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(286, 24);
            this.txtAciklama.TabIndex = 15;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(411, 48);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 24);
            this.txtTutar.TabIndex = 9;
            // 
            // txtEvrakKod
            // 
            this.txtEvrakKod.Location = new System.Drawing.Point(87, 47);
            this.txtEvrakKod.Name = "txtEvrakKod";
            this.txtEvrakKod.Size = new System.Drawing.Size(100, 24);
            this.txtEvrakKod.TabIndex = 5;
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(87, 17);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(100, 24);
            this.txtCariKod.TabIndex = 1;
            this.txtCariKod.Leave += new System.EventHandler(this.TxtCariKod_Leave);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.Location = new System.Drawing.Point(193, 16);
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
            this.lblAlisTarih.Location = new System.Drawing.Point(523, 53);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(68, 17);
            this.lblAlisTarih.TabIndex = 10;
            this.lblAlisTarih.Text = "Alış Tarihi";
            // 
            // lblVade
            // 
            this.lblVade.AutoSize = true;
            this.lblVade.Location = new System.Drawing.Point(193, 50);
            this.lblVade.Name = "lblVade";
            this.lblVade.Size = new System.Drawing.Size(44, 17);
            this.lblVade.TabIndex = 6;
            this.lblVade.Text = "Vadesi";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(349, 81);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 14;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblAsilBorclu
            // 
            this.lblAsilBorclu.AutoSize = true;
            this.lblAsilBorclu.Location = new System.Drawing.Point(12, 80);
            this.lblAsilBorclu.Name = "lblAsilBorclu";
            this.lblAsilBorclu.Size = new System.Drawing.Size(70, 17);
            this.lblAsilBorclu.TabIndex = 12;
            this.lblAsilBorclu.Text = "Asıl Borçlu";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(361, 51);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(44, 17);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "Tutarı";
            // 
            // lblEvrakKod
            // 
            this.lblEvrakKod.AutoSize = true;
            this.lblEvrakKod.Location = new System.Drawing.Point(12, 50);
            this.lblEvrakKod.Name = "lblEvrakKod";
            this.lblEvrakKod.Size = new System.Drawing.Size(69, 17);
            this.lblEvrakKod.TabIndex = 4;
            this.lblEvrakKod.Text = "Evrak Kodu";
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.Location = new System.Drawing.Point(224, 20);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(473, 17);
            this.lblCariUnvan.TabIndex = 3;
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(12, 20);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(60, 17);
            this.lblCariKod.TabIndex = 0;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // dgvMusteridenEvrakAl
            // 
            this.dgvMusteridenEvrakAl.AllowUserToAddRows = false;
            this.dgvMusteridenEvrakAl.AllowUserToDeleteRows = false;
            this.dgvMusteridenEvrakAl.AllowUserToResizeRows = false;
            this.dgvMusteridenEvrakAl.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteridenEvrakAl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusteridenEvrakAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMusteridenEvrakAl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colAlinanCariId,
            this.colAlınanCariUnvan,
            this.colVade,
            this.colTutar,
            this.colAsilBorclu,
            this.colAlisTarihi,
            this.colAciklama});
            this.dgvMusteridenEvrakAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteridenEvrakAl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMusteridenEvrakAl.EnableHeadersVisualStyles = false;
            this.dgvMusteridenEvrakAl.Location = new System.Drawing.Point(0, 156);
            this.dgvMusteridenEvrakAl.MultiSelect = false;
            this.dgvMusteridenEvrakAl.Name = "dgvMusteridenEvrakAl";
            this.dgvMusteridenEvrakAl.ReadOnly = true;
            this.dgvMusteridenEvrakAl.RowHeadersVisible = false;
            this.dgvMusteridenEvrakAl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMusteridenEvrakAl.RowTemplate.Height = 25;
            this.dgvMusteridenEvrakAl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteridenEvrakAl.Size = new System.Drawing.Size(708, 190);
            this.dgvMusteridenEvrakAl.TabIndex = 1;
            this.dgvMusteridenEvrakAl.TabStop = false;
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
            // colKod
            // 
            this.colKod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKod.DataPropertyName = "Kod";
            this.colKod.HeaderText = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            this.colKod.Width = 52;
            // 
            // colAlinanCariId
            // 
            this.colAlinanCariId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAlinanCariId.DataPropertyName = "AlinanCariId";
            this.colAlinanCariId.HeaderText = "Alinan Cari Id";
            this.colAlinanCariId.Name = "colAlinanCariId";
            this.colAlinanCariId.ReadOnly = true;
            this.colAlinanCariId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAlinanCariId.Visible = false;
            // 
            // colAlınanCariUnvan
            // 
            this.colAlınanCariUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAlınanCariUnvan.DataPropertyName = "CariUnvan";
            this.colAlınanCariUnvan.HeaderText = "Alınan Cari Unvan";
            this.colAlınanCariUnvan.Name = "colAlınanCariUnvan";
            this.colAlınanCariUnvan.ReadOnly = true;
            this.colAlınanCariUnvan.Width = 131;
            // 
            // colVade
            // 
            this.colVade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVade.DataPropertyName = "Vade";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colVade.DefaultCellStyle = dataGridViewCellStyle1;
            this.colVade.HeaderText = "Vadesi";
            this.colVade.Name = "colVade";
            this.colVade.ReadOnly = true;
            this.colVade.Width = 69;
            // 
            // colTutar
            // 
            this.colTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "#,###.## TL";
            dataGridViewCellStyle2.NullValue = null;
            this.colTutar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTutar.HeaderText = "Tutarı";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            this.colTutar.Width = 69;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAsilBorclu.DataPropertyName = "AsilBorclu";
            this.colAsilBorclu.HeaderText = "Asıl Borçlu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.ReadOnly = true;
            this.colAsilBorclu.Width = 95;
            // 
            // colAlisTarihi
            // 
            this.colAlisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAlisTarihi.DataPropertyName = "AlisTarihi";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colAlisTarihi.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAlisTarihi.HeaderText = "Alış Tarihi";
            this.colAlisTarihi.Name = "colAlisTarihi";
            this.colAlisTarihi.ReadOnly = true;
            this.colAlisTarihi.Width = 93;
            // 
            // colAciklama
            // 
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAciklama.DataPropertyName = "Aciklama";
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            this.colAciklama.Width = 81;
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
            this.uscMusteriyeEvrakCik.Location = new System.Drawing.Point(0, 346);
            this.uscMusteriyeEvrakCik.Name = "uscMusteriyeEvrakCik";
            this.uscMusteriyeEvrakCik.Size = new System.Drawing.Size(708, 44);
            this.uscMusteriyeEvrakCik.TabIndex = 2;
            this.uscMusteriyeEvrakCik.ClickClear += new System.EventHandler(this.UscMusteriyeEvrakCik_ClickClear);
            this.uscMusteriyeEvrakCik.ClickSave += new System.EventHandler(this.UscMusteriyeEvrakCik_ClickSave);
            this.uscMusteriyeEvrakCik.ClickCancel += new System.EventHandler(this.UscMusteriyeEvrakCik_ClickCancel);
            // 
            // FrmMusteridenEvrakAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 390);
            this.Controls.Add(this.dgvMusteridenEvrakAl);
            this.Controls.Add(this.uscMusteriyeEvrakCik);
            this.Controls.Add(this.grpEvrakBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteridenEvrakAl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Muşteriden Evrak Al";
            this.Load += new System.EventHandler(this.FrmMusteridenEvrakAl_Load);
            this.grpEvrakBilgiler.ResumeLayout(false);
            this.grpEvrakBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteridenEvrakAl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvrakBilgiler;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.TextBox txtEvrakKod;
        private System.Windows.Forms.Label lblEvrakKod;
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
        private System.Windows.Forms.DataGridView dgvMusteridenEvrakAl;
        private UserControls.UscFormButtons uscMusteriyeEvrakCik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlinanCariId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlınanCariUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsilBorclu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
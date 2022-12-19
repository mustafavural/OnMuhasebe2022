namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmMusteriyePortfoydenEvrakCik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriyePortfoydenEvrakCik));
            this.dgvPortfoydenEvrakCik = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsilBorclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUstBilgiler = new System.Windows.Forms.Panel();
            this.grpBordroBilgiler = new System.Windows.Forms.GroupBox();
            this.uscEvrak = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.btnEvrakBul = new System.Windows.Forms.Button();
            this.lblBordroKod = new System.Windows.Forms.Label();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.dtpCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.btnBordroBul = new System.Windows.Forms.Button();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.txtBordroAciklama = new System.Windows.Forms.TextBox();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.lblCikisTarih = new System.Windows.Forms.Label();
            this.lblBordroAciklama = new System.Windows.Forms.Label();
            this.uscBordro = new WindowsFormUI.Views.UserControls.UscFormButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfoydenEvrakCik)).BeginInit();
            this.pnlUstBilgiler.SuspendLayout();
            this.grpBordroBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPortfoydenEvrakCik
            // 
            this.dgvPortfoydenEvrakCik.AllowUserToAddRows = false;
            this.dgvPortfoydenEvrakCik.AllowUserToDeleteRows = false;
            this.dgvPortfoydenEvrakCik.AllowUserToResizeRows = false;
            this.dgvPortfoydenEvrakCik.BackgroundColor = System.Drawing.Color.White;
            this.dgvPortfoydenEvrakCik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPortfoydenEvrakCik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPortfoydenEvrakCik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPortfoydenEvrakCik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNo,
            this.colUnvan,
            this.colVade,
            this.colTutar,
            this.colAsilBorclu,
            this.colAciklama});
            this.dgvPortfoydenEvrakCik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPortfoydenEvrakCik.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPortfoydenEvrakCik.EnableHeadersVisualStyles = false;
            this.dgvPortfoydenEvrakCik.Location = new System.Drawing.Point(264, 0);
            this.dgvPortfoydenEvrakCik.MultiSelect = false;
            this.dgvPortfoydenEvrakCik.Name = "dgvPortfoydenEvrakCik";
            this.dgvPortfoydenEvrakCik.ReadOnly = true;
            this.dgvPortfoydenEvrakCik.RowHeadersVisible = false;
            this.dgvPortfoydenEvrakCik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPortfoydenEvrakCik.RowTemplate.Height = 25;
            this.dgvPortfoydenEvrakCik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortfoydenEvrakCik.Size = new System.Drawing.Size(721, 314);
            this.dgvPortfoydenEvrakCik.TabIndex = 0;
            this.dgvPortfoydenEvrakCik.TabStop = false;
            this.dgvPortfoydenEvrakCik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEvraklar_CellDoubleClick);
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
            // colUnvan
            // 
            this.colUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUnvan.DataPropertyName = "Unvan";
            this.colUnvan.HeaderText = "Kimden Alındı";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.ReadOnly = true;
            this.colUnvan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnvan.Width = 106;
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
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            this.colAciklama.Width = 81;
            // 
            // pnlUstBilgiler
            // 
            this.pnlUstBilgiler.Controls.Add(this.grpBordroBilgiler);
            this.pnlUstBilgiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUstBilgiler.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBilgiler.Name = "pnlUstBilgiler";
            this.pnlUstBilgiler.Size = new System.Drawing.Size(264, 314);
            this.pnlUstBilgiler.TabIndex = 0;
            // 
            // grpBordroBilgiler
            // 
            this.grpBordroBilgiler.Controls.Add(this.uscEvrak);
            this.grpBordroBilgiler.Controls.Add(this.btnEvrakBul);
            this.grpBordroBilgiler.Controls.Add(this.lblBordroKod);
            this.grpBordroBilgiler.Controls.Add(this.txtEvrakNo);
            this.grpBordroBilgiler.Controls.Add(this.lblCariKod);
            this.grpBordroBilgiler.Controls.Add(this.lblEvrakNo);
            this.grpBordroBilgiler.Controls.Add(this.dtpCikisTarih);
            this.grpBordroBilgiler.Controls.Add(this.btnBordroBul);
            this.grpBordroBilgiler.Controls.Add(this.btnCariBul);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroAciklama);
            this.grpBordroBilgiler.Controls.Add(this.txtBordroNo);
            this.grpBordroBilgiler.Controls.Add(this.txtCariKod);
            this.grpBordroBilgiler.Controls.Add(this.lblCariUnvan);
            this.grpBordroBilgiler.Controls.Add(this.lblCikisTarih);
            this.grpBordroBilgiler.Controls.Add(this.lblBordroAciklama);
            this.grpBordroBilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBordroBilgiler.Location = new System.Drawing.Point(0, 0);
            this.grpBordroBilgiler.Name = "grpBordroBilgiler";
            this.grpBordroBilgiler.Size = new System.Drawing.Size(264, 314);
            this.grpBordroBilgiler.TabIndex = 0;
            this.grpBordroBilgiler.TabStop = false;
            this.grpBordroBilgiler.Text = "Bordro Bilgileri";
            // 
            // uscEvrak
            // 
            this.uscEvrak.BtnClear_Visible = false;
            this.uscEvrak.BtnDelete_Enable = false;
            this.uscEvrak.BtnDelete_Text = "Sil     ";
            this.uscEvrak.BtnSave_Enable = false;
            this.uscEvrak.BtnSave_Text = "Kaydet";
            this.uscEvrak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscEvrak.LblStatus_Text = "";
            this.uscEvrak.Location = new System.Drawing.Point(3, 262);
            this.uscEvrak.Name = "uscEvrak";
            this.uscEvrak.Size = new System.Drawing.Size(258, 49);
            this.uscEvrak.TabIndex = 14;
            this.uscEvrak.ClickCancel += new System.EventHandler(this.UscEvrak_ClickSil);
            // 
            // btnEvrakBul
            // 
            this.btnEvrakBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_BordroLst32x32;
            this.btnEvrakBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvrakBul.Enabled = false;
            this.btnEvrakBul.Location = new System.Drawing.Point(231, 232);
            this.btnEvrakBul.Name = "btnEvrakBul";
            this.btnEvrakBul.Size = new System.Drawing.Size(24, 24);
            this.btnEvrakBul.TabIndex = 12;
            this.btnEvrakBul.TabStop = false;
            this.btnEvrakBul.UseVisualStyleBackColor = true;
            this.btnEvrakBul.Click += new System.EventHandler(this.BtnEvrakBul_Click);
            // 
            // lblBordroKod
            // 
            this.lblBordroKod.AutoSize = true;
            this.lblBordroKod.Location = new System.Drawing.Point(12, 22);
            this.lblBordroKod.Name = "lblBordroKod";
            this.lblBordroKod.Size = new System.Drawing.Size(66, 17);
            this.lblBordroKod.TabIndex = 0;
            this.lblBordroKod.Text = "Bordro No";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Enabled = false;
            this.txtEvrakNo.Location = new System.Drawing.Point(91, 232);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(134, 24);
            this.txtEvrakNo.TabIndex = 11;
            this.txtEvrakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtEvrakNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(12, 55);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(60, 17);
            this.lblCariKod.TabIndex = 3;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(12, 235);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(69, 17);
            this.lblEvrakNo.TabIndex = 10;
            this.lblEvrakNo.Text = "Evrak Kodu";
            // 
            // dtpCikisTarih
            // 
            this.dtpCikisTarih.Enabled = false;
            this.dtpCikisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCikisTarih.Location = new System.Drawing.Point(91, 172);
            this.dtpCikisTarih.Name = "dtpCikisTarih";
            this.dtpCikisTarih.Size = new System.Drawing.Size(164, 24);
            this.dtpCikisTarih.TabIndex = 7;
            this.dtpCikisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.dtpCikisTarih.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // btnBordroBul
            // 
            this.btnBordroBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.btnBordroBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBordroBul.Enabled = false;
            this.btnBordroBul.Location = new System.Drawing.Point(231, 19);
            this.btnBordroBul.Name = "btnBordroBul";
            this.btnBordroBul.Size = new System.Drawing.Size(24, 24);
            this.btnBordroBul.TabIndex = 2;
            this.btnBordroBul.TabStop = false;
            this.btnBordroBul.UseVisualStyleBackColor = true;
            this.btnBordroBul.Click += new System.EventHandler(this.BtnBordroNoBul_Click);
            // 
            // btnCariBul
            // 
            this.btnCariBul.BackgroundImage = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnCariBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBul.Enabled = false;
            this.btnCariBul.Location = new System.Drawing.Point(231, 49);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(24, 24);
            this.btnCariBul.TabIndex = 5;
            this.btnCariBul.TabStop = false;
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.BtnCariBul_Click);
            // 
            // txtBordroAciklama
            // 
            this.txtBordroAciklama.Enabled = false;
            this.txtBordroAciklama.Location = new System.Drawing.Point(91, 202);
            this.txtBordroAciklama.Name = "txtBordroAciklama";
            this.txtBordroAciklama.Size = new System.Drawing.Size(164, 24);
            this.txtBordroAciklama.TabIndex = 9;
            this.txtBordroAciklama.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Enabled = false;
            this.txtBordroNo.Location = new System.Drawing.Point(91, 19);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Size = new System.Drawing.Size(134, 24);
            this.txtBordroNo.TabIndex = 1;
            this.txtBordroNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle);
            this.txtBordroNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Enabled = false;
            this.txtCariKod.Location = new System.Drawing.Point(91, 49);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(134, 24);
            this.txtCariKod.TabIndex = 4;
            this.txtCariKod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.Location = new System.Drawing.Point(12, 76);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(243, 93);
            this.lblCariUnvan.TabIndex = 13;
            this.lblCariUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCikisTarih
            // 
            this.lblCikisTarih.AutoSize = true;
            this.lblCikisTarih.Location = new System.Drawing.Point(12, 175);
            this.lblCikisTarih.Name = "lblCikisTarih";
            this.lblCikisTarih.Size = new System.Drawing.Size(73, 17);
            this.lblCikisTarih.TabIndex = 6;
            this.lblCikisTarih.Text = "Cikis Tarihi";
            // 
            // lblBordroAciklama
            // 
            this.lblBordroAciklama.AutoSize = true;
            this.lblBordroAciklama.Location = new System.Drawing.Point(12, 205);
            this.lblBordroAciklama.Name = "lblBordroAciklama";
            this.lblBordroAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblBordroAciklama.TabIndex = 8;
            this.lblBordroAciklama.Text = "Açıklama";
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
            this.uscBordro.Location = new System.Drawing.Point(264, 262);
            this.uscBordro.Name = "uscBordro";
            this.uscBordro.Size = new System.Drawing.Size(721, 52);
            this.uscBordro.TabIndex = 1;
            this.uscBordro.TabStop = false;
            this.uscBordro.ClickClear += new System.EventHandler(this.UscBordro_ClickClear);
            this.uscBordro.ClickSave += new System.EventHandler(this.UscBordro_ClickSave);
            this.uscBordro.ClickCancel += new System.EventHandler(this.UscBordro_ClickSil);
            // 
            // FrmMusteriyePortfoydenEvrakCik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 314);
            this.Controls.Add(this.uscBordro);
            this.Controls.Add(this.dgvPortfoydenEvrakCik);
            this.Controls.Add(this.pnlUstBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteriyePortfoydenEvrakCik";
            this.Text = "Müşteriye Portföyden Evrak Çık";
            this.Load += new System.EventHandler(this.FrmMusteriyePortfoydenEvrakCik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfoydenEvrakCik)).EndInit();
            this.pnlUstBilgiler.ResumeLayout(false);
            this.grpBordroBilgiler.ResumeLayout(false);
            this.grpBordroBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPortfoydenEvrakCik;
        private System.Windows.Forms.Panel pnlUstBilgiler;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.GroupBox grpBordroBilgiler;
        private System.Windows.Forms.Label lblBordroKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.Button btnBordroBul;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtBordroAciklama;
        private System.Windows.Forms.TextBox txtBordroNo;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.Label lblCikisTarih;
        private System.Windows.Forms.Label lblBordroAciklama;
        private UserControls.UscFormButtons uscBordro;
        private System.Windows.Forms.Button btnEvrakBul;
        private System.Windows.Forms.DateTimePicker dtpCikisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsilBorclu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private UserControls.UscFormButtons uscEvrak;
    }
}
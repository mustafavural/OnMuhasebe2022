namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmPortfoydekiEvraklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPortfoydekiEvraklar));
            this.dgvEvrakListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsilBorclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCariListe = new System.Windows.Forms.GroupBox();
            this.grpTutar = new System.Windows.Forms.GroupBox();
            this.lblTutarEnAz = new System.Windows.Forms.Label();
            this.lblTutarEnCok = new System.Windows.Forms.Label();
            this.txtTutarEnCok = new System.Windows.Forms.TextBox();
            this.txtTutarEnAz = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.grpVade = new System.Windows.Forms.GroupBox();
            this.lblVadeBaslangic = new System.Windows.Forms.Label();
            this.dtpVadeSon = new System.Windows.Forms.DateTimePicker();
            this.lblVadeBitis = new System.Windows.Forms.Label();
            this.dtpVadeIlk = new System.Windows.Forms.DateTimePicker();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAsilBorclu = new System.Windows.Forms.TextBox();
            this.lblAsilBorclu = new System.Windows.Forms.Label();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakListe)).BeginInit();
            this.grpCariListe.SuspendLayout();
            this.grpTutar.SuspendLayout();
            this.grpVade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvrakListe
            // 
            this.dgvEvrakListe.AllowUserToAddRows = false;
            this.dgvEvrakListe.AllowUserToDeleteRows = false;
            this.dgvEvrakListe.AllowUserToResizeRows = false;
            this.dgvEvrakListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvrakListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvrakListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNo,
            this.colUnvan,
            this.colAsilBorclu,
            this.colVade,
            this.colTutar,
            this.colAciklama});
            this.dgvEvrakListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvrakListe.Location = new System.Drawing.Point(131, 0);
            this.dgvEvrakListe.MultiSelect = false;
            this.dgvEvrakListe.Name = "dgvEvrakListe";
            this.dgvEvrakListe.ReadOnly = true;
            this.dgvEvrakListe.RowHeadersVisible = false;
            this.dgvEvrakListe.RowTemplate.Height = 25;
            this.dgvEvrakListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvrakListe.Size = new System.Drawing.Size(669, 464);
            this.dgvEvrakListe.TabIndex = 3;
            this.dgvEvrakListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFaturaListe_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNo.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNo.HeaderText = "Evrak No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 85;
            // 
            // colUnvan
            // 
            this.colUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUnvan.DataPropertyName = "Unvan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.colUnvan.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnvan.HeaderText = "Alınan Cari Unvan";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.ReadOnly = true;
            this.colUnvan.Width = 131;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAsilBorclu.DataPropertyName = "AsilBorclu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colAsilBorclu.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAsilBorclu.HeaderText = "Asıl Borçlu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.ReadOnly = true;
            this.colAsilBorclu.Width = 95;
            // 
            // colVade
            // 
            this.colVade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVade.DataPropertyName = "Vade";
            this.colVade.HeaderText = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.ReadOnly = true;
            this.colVade.Width = 59;
            // 
            // colTutar
            // 
            this.colTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "#,###.## TL";
            this.colTutar.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            this.colTutar.Width = 65;
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
            // grpCariListe
            // 
            this.grpCariListe.Controls.Add(this.grpTutar);
            this.grpCariListe.Controls.Add(this.txtAciklama);
            this.grpCariListe.Controls.Add(this.grpVade);
            this.grpCariListe.Controls.Add(this.lblAciklama);
            this.grpCariListe.Controls.Add(this.txtAsilBorclu);
            this.grpCariListe.Controls.Add(this.lblAsilBorclu);
            this.grpCariListe.Controls.Add(this.txtCariUnvan);
            this.grpCariListe.Controls.Add(this.lblCariUnvan);
            this.grpCariListe.Controls.Add(this.txtEvrakNo);
            this.grpCariListe.Controls.Add(this.lblEvrakNo);
            this.grpCariListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCariListe.Location = new System.Drawing.Point(0, 0);
            this.grpCariListe.Name = "grpCariListe";
            this.grpCariListe.Size = new System.Drawing.Size(131, 464);
            this.grpCariListe.TabIndex = 2;
            this.grpCariListe.TabStop = false;
            this.grpCariListe.Text = "Cari Bilgileri";
            // 
            // grpTutar
            // 
            this.grpTutar.Controls.Add(this.lblTutarEnAz);
            this.grpTutar.Controls.Add(this.lblTutarEnCok);
            this.grpTutar.Controls.Add(this.txtTutarEnCok);
            this.grpTutar.Controls.Add(this.txtTutarEnAz);
            this.grpTutar.Location = new System.Drawing.Point(6, 162);
            this.grpTutar.Name = "grpTutar";
            this.grpTutar.Size = new System.Drawing.Size(119, 120);
            this.grpTutar.TabIndex = 10;
            this.grpTutar.TabStop = false;
            this.grpTutar.Text = "Tutar";
            // 
            // lblTutarEnAz
            // 
            this.lblTutarEnAz.AutoSize = true;
            this.lblTutarEnAz.Location = new System.Drawing.Point(6, 22);
            this.lblTutarEnAz.Name = "lblTutarEnAz";
            this.lblTutarEnAz.Size = new System.Drawing.Size(76, 17);
            this.lblTutarEnAz.TabIndex = 0;
            this.lblTutarEnAz.Text = "En Az Tutar";
            // 
            // lblTutarEnCok
            // 
            this.lblTutarEnCok.AutoSize = true;
            this.lblTutarEnCok.Location = new System.Drawing.Point(6, 69);
            this.lblTutarEnCok.Name = "lblTutarEnCok";
            this.lblTutarEnCok.Size = new System.Drawing.Size(81, 17);
            this.lblTutarEnCok.TabIndex = 2;
            this.lblTutarEnCok.Text = "En Çok Tutar";
            // 
            // txtTutarEnCok
            // 
            this.txtTutarEnCok.Location = new System.Drawing.Point(6, 91);
            this.txtTutarEnCok.Name = "txtTutarEnCok";
            this.txtTutarEnCok.Size = new System.Drawing.Size(107, 24);
            this.txtTutarEnCok.TabIndex = 3;
            this.txtTutarEnCok.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // txtTutarEnAz
            // 
            this.txtTutarEnAz.Location = new System.Drawing.Point(6, 42);
            this.txtTutarEnAz.Name = "txtTutarEnAz";
            this.txtTutarEnAz.Size = new System.Drawing.Size(107, 24);
            this.txtTutarEnAz.TabIndex = 1;
            this.txtTutarEnAz.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 434);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(119, 24);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // grpVade
            // 
            this.grpVade.Controls.Add(this.lblVadeBaslangic);
            this.grpVade.Controls.Add(this.dtpVadeSon);
            this.grpVade.Controls.Add(this.lblVadeBitis);
            this.grpVade.Controls.Add(this.dtpVadeIlk);
            this.grpVade.Location = new System.Drawing.Point(6, 288);
            this.grpVade.Name = "grpVade";
            this.grpVade.Size = new System.Drawing.Size(119, 123);
            this.grpVade.TabIndex = 11;
            this.grpVade.TabStop = false;
            this.grpVade.Text = "Vade";
            // 
            // lblVadeBaslangic
            // 
            this.lblVadeBaslangic.AutoSize = true;
            this.lblVadeBaslangic.Location = new System.Drawing.Point(25, 22);
            this.lblVadeBaslangic.Name = "lblVadeBaslangic";
            this.lblVadeBaslangic.Size = new System.Drawing.Size(69, 17);
            this.lblVadeBaslangic.TabIndex = 0;
            this.lblVadeBaslangic.Text = "Başlangıç...";
            // 
            // dtpVadeSon
            // 
            this.dtpVadeSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVadeSon.Location = new System.Drawing.Point(18, 91);
            this.dtpVadeSon.Name = "dtpVadeSon";
            this.dtpVadeSon.Size = new System.Drawing.Size(83, 24);
            this.dtpVadeSon.TabIndex = 3;
            this.dtpVadeSon.ValueChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // lblVadeBitis
            // 
            this.lblVadeBitis.AutoSize = true;
            this.lblVadeBitis.Location = new System.Drawing.Point(37, 71);
            this.lblVadeBitis.Name = "lblVadeBitis";
            this.lblVadeBitis.Size = new System.Drawing.Size(45, 17);
            this.lblVadeBitis.TabIndex = 2;
            this.lblVadeBitis.Text = "Bitiş...";
            // 
            // dtpVadeIlk
            // 
            this.dtpVadeIlk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVadeIlk.Location = new System.Drawing.Point(18, 42);
            this.dtpVadeIlk.Name = "dtpVadeIlk";
            this.dtpVadeIlk.Size = new System.Drawing.Size(83, 24);
            this.dtpVadeIlk.TabIndex = 1;
            this.dtpVadeIlk.ValueChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(6, 414);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtAsilBorclu
            // 
            this.txtAsilBorclu.Location = new System.Drawing.Point(6, 132);
            this.txtAsilBorclu.Name = "txtAsilBorclu";
            this.txtAsilBorclu.Size = new System.Drawing.Size(119, 24);
            this.txtAsilBorclu.TabIndex = 5;
            this.txtAsilBorclu.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // lblAsilBorclu
            // 
            this.lblAsilBorclu.AutoSize = true;
            this.lblAsilBorclu.Location = new System.Drawing.Point(6, 112);
            this.lblAsilBorclu.Name = "lblAsilBorclu";
            this.lblAsilBorclu.Size = new System.Drawing.Size(70, 17);
            this.lblAsilBorclu.TabIndex = 4;
            this.lblAsilBorclu.Text = "Asıl Borçlu";
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(6, 85);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(119, 24);
            this.txtCariUnvan.TabIndex = 3;
            this.txtCariUnvan.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.AutoSize = true;
            this.lblCariUnvan.Location = new System.Drawing.Point(6, 65);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(45, 17);
            this.lblCariUnvan.TabIndex = 2;
            this.lblCariUnvan.Text = "Unvanı";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(6, 38);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(119, 24);
            this.txtEvrakNo.TabIndex = 1;
            this.txtEvrakNo.TextChanged += new System.EventHandler(this.TxtTextChanged);
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Location = new System.Drawing.Point(6, 18);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(60, 17);
            this.lblEvrakNo.TabIndex = 0;
            this.lblEvrakNo.Text = "Evrak No";
            // 
            // FrmPortfoydekiEvraklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.dgvEvrakListe);
            this.Controls.Add(this.grpCariListe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPortfoydekiEvraklar";
            this.Text = "FrmPortfoydekiEvraklar";
            this.Load += new System.EventHandler(this.FrmPortfoydekiEvraklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakListe)).EndInit();
            this.grpCariListe.ResumeLayout(false);
            this.grpCariListe.PerformLayout();
            this.grpTutar.ResumeLayout(false);
            this.grpTutar.PerformLayout();
            this.grpVade.ResumeLayout(false);
            this.grpVade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvrakListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsilBorclu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.GroupBox grpCariListe;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAsilBorclu;
        private System.Windows.Forms.Label lblAsilBorclu;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.GroupBox grpTutar;
        private System.Windows.Forms.Label lblTutarEnAz;
        private System.Windows.Forms.Label lblTutarEnCok;
        private System.Windows.Forms.TextBox txtTutarEnCok;
        private System.Windows.Forms.TextBox txtTutarEnAz;
        private System.Windows.Forms.GroupBox grpVade;
        private System.Windows.Forms.Label lblVadeBaslangic;
        private System.Windows.Forms.DateTimePicker dtpVadeSon;
        private System.Windows.Forms.Label lblVadeBitis;
        private System.Windows.Forms.DateTimePicker dtpVadeIlk;
    }
}
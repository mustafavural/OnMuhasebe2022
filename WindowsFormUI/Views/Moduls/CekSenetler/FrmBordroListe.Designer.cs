using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmBordroListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBordroListe));
            this.grpBordroListe = new System.Windows.Forms.GroupBox();
            this.lblBordroTurler = new System.Windows.Forms.Label();
            this.grpBordroTutar = new System.Windows.Forms.GroupBox();
            this.lblTutarEnAz = new System.Windows.Forms.Label();
            this.lblTutarEnCok = new System.Windows.Forms.Label();
            this.txtTutarEnCok = new System.Windows.Forms.TextBox();
            this.txtTutarEnAz = new System.Windows.Forms.TextBox();
            this.grpBordroTarih = new System.Windows.Forms.GroupBox();
            this.lblTarihBaslangic = new System.Windows.Forms.Label();
            this.dtpTarihSon = new System.Windows.Forms.DateTimePicker();
            this.lblTarihBitis = new System.Windows.Forms.Label();
            this.dtpTarihIlk = new System.Windows.Forms.DateTimePicker();
            this.lblBordroTur = new System.Windows.Forms.Label();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.lblBordroNo = new System.Windows.Forms.Label();
            this.dgvBordroListe = new System.Windows.Forms.DataGridView();
            this.colBordroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBordroNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBordroTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBordroTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBordroTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBordroAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBordroListe.SuspendLayout();
            this.grpBordroTutar.SuspendLayout();
            this.grpBordroTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBordroListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBordroListe
            // 
            this.grpBordroListe.Controls.Add(this.lblBordroTurler);
            this.grpBordroListe.Controls.Add(this.grpBordroTutar);
            this.grpBordroListe.Controls.Add(this.grpBordroTarih);
            this.grpBordroListe.Controls.Add(this.lblBordroTur);
            this.grpBordroListe.Controls.Add(this.txtCariUnvan);
            this.grpBordroListe.Controls.Add(this.lblCariUnvan);
            this.grpBordroListe.Controls.Add(this.txtBordroNo);
            this.grpBordroListe.Controls.Add(this.lblBordroNo);
            this.grpBordroListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBordroListe.Location = new System.Drawing.Point(0, 0);
            this.grpBordroListe.Name = "grpBordroListe";
            this.grpBordroListe.Size = new System.Drawing.Size(131, 448);
            this.grpBordroListe.TabIndex = 0;
            this.grpBordroListe.TabStop = false;
            this.grpBordroListe.Text = "Bordro Bilgileri";
            // 
            // lblBordroTurler
            // 
            this.lblBordroTurler.Location = new System.Drawing.Point(6, 88);
            this.lblBordroTurler.Name = "lblBordroTurler";
            this.lblBordroTurler.Size = new System.Drawing.Size(119, 33);
            this.lblBordroTurler.TabIndex = 3;
            this.lblBordroTurler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBordroTutar
            // 
            this.grpBordroTutar.Controls.Add(this.lblTutarEnAz);
            this.grpBordroTutar.Controls.Add(this.lblTutarEnCok);
            this.grpBordroTutar.Controls.Add(this.txtTutarEnCok);
            this.grpBordroTutar.Controls.Add(this.txtTutarEnAz);
            this.grpBordroTutar.Location = new System.Drawing.Point(6, 170);
            this.grpBordroTutar.Name = "grpBordroTutar";
            this.grpBordroTutar.Size = new System.Drawing.Size(119, 133);
            this.grpBordroTutar.TabIndex = 6;
            this.grpBordroTutar.TabStop = false;
            this.grpBordroTutar.Text = "Bordro Tutarı";
            // 
            // lblTutarEnAz
            // 
            this.lblTutarEnAz.AutoSize = true;
            this.lblTutarEnAz.Location = new System.Drawing.Point(20, 22);
            this.lblTutarEnAz.Name = "lblTutarEnAz";
            this.lblTutarEnAz.Size = new System.Drawing.Size(76, 17);
            this.lblTutarEnAz.TabIndex = 0;
            this.lblTutarEnAz.Text = "En Az Tutar";
            // 
            // lblTutarEnCok
            // 
            this.lblTutarEnCok.AutoSize = true;
            this.lblTutarEnCok.Location = new System.Drawing.Point(20, 71);
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
            this.txtTutarEnCok.TextChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // txtTutarEnAz
            // 
            this.txtTutarEnAz.Location = new System.Drawing.Point(6, 42);
            this.txtTutarEnAz.Name = "txtTutarEnAz";
            this.txtTutarEnAz.Size = new System.Drawing.Size(107, 24);
            this.txtTutarEnAz.TabIndex = 1;
            this.txtTutarEnAz.TextChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // grpBordroTarih
            // 
            this.grpBordroTarih.Controls.Add(this.lblTarihBaslangic);
            this.grpBordroTarih.Controls.Add(this.dtpTarihSon);
            this.grpBordroTarih.Controls.Add(this.lblTarihBitis);
            this.grpBordroTarih.Controls.Add(this.dtpTarihIlk);
            this.grpBordroTarih.Location = new System.Drawing.Point(6, 309);
            this.grpBordroTarih.Name = "grpBordroTarih";
            this.grpBordroTarih.Size = new System.Drawing.Size(119, 133);
            this.grpBordroTarih.TabIndex = 7;
            this.grpBordroTarih.TabStop = false;
            this.grpBordroTarih.Text = "Bordro Tarihi";
            // 
            // lblTarihBaslangic
            // 
            this.lblTarihBaslangic.AutoSize = true;
            this.lblTarihBaslangic.Location = new System.Drawing.Point(25, 22);
            this.lblTarihBaslangic.Name = "lblTarihBaslangic";
            this.lblTarihBaslangic.Size = new System.Drawing.Size(69, 17);
            this.lblTarihBaslangic.TabIndex = 0;
            this.lblTarihBaslangic.Text = "Başlangıç...";
            // 
            // dtpTarihSon
            // 
            this.dtpTarihSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihSon.Location = new System.Drawing.Point(18, 91);
            this.dtpTarihSon.Name = "dtpTarihSon";
            this.dtpTarihSon.Size = new System.Drawing.Size(83, 24);
            this.dtpTarihSon.TabIndex = 3;
            this.dtpTarihSon.ValueChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // lblTarihBitis
            // 
            this.lblTarihBitis.AutoSize = true;
            this.lblTarihBitis.Location = new System.Drawing.Point(37, 71);
            this.lblTarihBitis.Name = "lblTarihBitis";
            this.lblTarihBitis.Size = new System.Drawing.Size(45, 17);
            this.lblTarihBitis.TabIndex = 2;
            this.lblTarihBitis.Text = "Bitiş...";
            // 
            // dtpTarihIlk
            // 
            this.dtpTarihIlk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihIlk.Location = new System.Drawing.Point(18, 42);
            this.dtpTarihIlk.Name = "dtpTarihIlk";
            this.dtpTarihIlk.Size = new System.Drawing.Size(83, 24);
            this.dtpTarihIlk.TabIndex = 1;
            this.dtpTarihIlk.ValueChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // lblBordroTur
            // 
            this.lblBordroTur.AutoSize = true;
            this.lblBordroTur.Location = new System.Drawing.Point(6, 71);
            this.lblBordroTur.Name = "lblBordroTur";
            this.lblBordroTur.Size = new System.Drawing.Size(76, 17);
            this.lblBordroTur.TabIndex = 2;
            this.lblBordroTur.Text = "Bordro Türü";
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(6, 142);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(119, 24);
            this.txtCariUnvan.TabIndex = 5;
            this.txtCariUnvan.TextChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.AutoSize = true;
            this.lblCariUnvan.Location = new System.Drawing.Point(6, 121);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(72, 17);
            this.lblCariUnvan.TabIndex = 4;
            this.lblCariUnvan.Text = "Cari Unvanı";
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Location = new System.Drawing.Point(6, 42);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Size = new System.Drawing.Size(119, 24);
            this.txtBordroNo.TabIndex = 1;
            this.txtBordroNo.TextChanged += new System.EventHandler(this.BordroListe_TextChanged);
            // 
            // lblBordroNo
            // 
            this.lblBordroNo.AutoSize = true;
            this.lblBordroNo.Location = new System.Drawing.Point(6, 22);
            this.lblBordroNo.Name = "lblBordroNo";
            this.lblBordroNo.Size = new System.Drawing.Size(66, 17);
            this.lblBordroNo.TabIndex = 0;
            this.lblBordroNo.Text = "Bordro No";
            // 
            // dgvBordroListe
            // 
            this.dgvBordroListe.AllowUserToAddRows = false;
            this.dgvBordroListe.AllowUserToDeleteRows = false;
            this.dgvBordroListe.AllowUserToResizeRows = false;
            this.dgvBordroListe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBordroListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBordroListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBordroListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBordroId,
            this.colBordroNo,
            this.colBordroTur,
            this.colCariUnvan,
            this.colBordroTutar,
            this.colBordroTarih,
            this.colBordroAciklama});
            this.dgvBordroListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBordroListe.Location = new System.Drawing.Point(131, 0);
            this.dgvBordroListe.MultiSelect = false;
            this.dgvBordroListe.Name = "dgvBordroListe";
            this.dgvBordroListe.ReadOnly = true;
            this.dgvBordroListe.RowHeadersVisible = false;
            this.dgvBordroListe.RowTemplate.Height = 25;
            this.dgvBordroListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBordroListe.Size = new System.Drawing.Size(716, 448);
            this.dgvBordroListe.TabIndex = 1;
            this.dgvBordroListe.TabStop = false;
            this.dgvBordroListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBordroListe_CellDoubleClick);
            // 
            // colBordroId
            // 
            this.colBordroId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBordroId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBordroId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBordroId.HeaderText = "Id";
            this.colBordroId.Name = "colBordroId";
            this.colBordroId.ReadOnly = true;
            this.colBordroId.Visible = false;
            this.colBordroId.Width = 27;
            // 
            // colBordroNo
            // 
            this.colBordroNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBordroNo.DataPropertyName = "No";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBordroNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBordroNo.HeaderText = "No";
            this.colBordroNo.Name = "colBordroNo";
            this.colBordroNo.ReadOnly = true;
            this.colBordroNo.Width = 49;
            // 
            // colBordroTur
            // 
            this.colBordroTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBordroTur.DataPropertyName = "Tur";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBordroTur.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBordroTur.HeaderText = "Tür";
            this.colBordroTur.Name = "colBordroTur";
            this.colBordroTur.ReadOnly = true;
            this.colBordroTur.Width = 53;
            // 
            // colCariUnvan
            // 
            this.colCariUnvan.DataPropertyName = "Unvan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colCariUnvan.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCariUnvan.HeaderText = "Unvan";
            this.colCariUnvan.Name = "colCariUnvan";
            this.colCariUnvan.ReadOnly = true;
            this.colCariUnvan.Width = 200;
            // 
            // colBordroTutar
            // 
            this.colBordroTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBordroTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "#,###.## TL";
            dataGridViewCellStyle6.NullValue = "0";
            this.colBordroTutar.DefaultCellStyle = dataGridViewCellStyle6;
            this.colBordroTutar.HeaderText = "Tutar";
            this.colBordroTutar.Name = "colBordroTutar";
            this.colBordroTutar.ReadOnly = true;
            this.colBordroTutar.Width = 65;
            // 
            // colBordroTarih
            // 
            this.colBordroTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBordroTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBordroTarih.DefaultCellStyle = dataGridViewCellStyle7;
            this.colBordroTarih.HeaderText = "Tarih";
            this.colBordroTarih.Name = "colBordroTarih";
            this.colBordroTarih.ReadOnly = true;
            this.colBordroTarih.Width = 63;
            // 
            // colBordroAciklama
            // 
            this.colBordroAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBordroAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colBordroAciklama.DefaultCellStyle = dataGridViewCellStyle8;
            this.colBordroAciklama.HeaderText = "Aciklama";
            this.colBordroAciklama.Name = "colBordroAciklama";
            this.colBordroAciklama.ReadOnly = true;
            // 
            // FrmBordroListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 448);
            this.Controls.Add(this.dgvBordroListe);
            this.Controls.Add(this.grpBordroListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 675);
            this.MinimumSize = new System.Drawing.Size(863, 487);
            this.Name = "FrmBordroListe";
            this.Text = "Bordro Listesi";
            this.Load += new System.EventHandler(this.FrmBordroListe_Load);
            this.grpBordroListe.ResumeLayout(false);
            this.grpBordroListe.PerformLayout();
            this.grpBordroTutar.ResumeLayout(false);
            this.grpBordroTutar.PerformLayout();
            this.grpBordroTarih.ResumeLayout(false);
            this.grpBordroTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBordroListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBordroListe;
        private System.Windows.Forms.DataGridView dgvBordroListe;
        private System.Windows.Forms.Label lblTarihBaslangic;
        private System.Windows.Forms.Label lblBordroTur;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.TextBox txtBordroNo;
        private System.Windows.Forms.Label lblBordroNo;
        private System.Windows.Forms.Label lblTarihBitis;
        private DateTimePicker dtpTarihSon;
        private DateTimePicker dtpTarihIlk;
        private GroupBox grpBordroTarih;
        private Label lblBordroTurler;
        private GroupBox grpBordroTutar;
        private Label lblTutarEnAz;
        private Label lblTutarEnCok;
        private TextBox txtTutarEnCok;
        private TextBox txtTutarEnAz;
        private DataGridViewTextBoxColumn colBordroId;
        private DataGridViewTextBoxColumn colBordroNo;
        private DataGridViewTextBoxColumn colBordroTur;
        private DataGridViewTextBoxColumn colCariUnvan;
        private DataGridViewTextBoxColumn colBordroTutar;
        private DataGridViewTextBoxColumn colBordroTarih;
        private DataGridViewTextBoxColumn colBordroAciklama;
    }
}
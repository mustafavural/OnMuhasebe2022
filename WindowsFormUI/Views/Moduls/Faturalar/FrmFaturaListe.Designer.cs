
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Faturalar
{
    partial class FrmFaturaListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListe));
            this.grpFaturaListe = new System.Windows.Forms.GroupBox();
            this.lblFaturaTurler = new System.Windows.Forms.Label();
            this.grpFaturaTarih = new System.Windows.Forms.GroupBox();
            this.lblTarihBaslangic = new System.Windows.Forms.Label();
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.lblTarihBitis = new System.Windows.Forms.Label();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblFaturaTur = new System.Windows.Forms.Label();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.dgvFaturaListe = new System.Windows.Forms.DataGridView();
            this.colFaturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFaturaListe.SuspendLayout();
            this.grpFaturaTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFaturaListe
            // 
            this.grpFaturaListe.Controls.Add(this.lblFaturaTurler);
            this.grpFaturaListe.Controls.Add(this.grpFaturaTarih);
            this.grpFaturaListe.Controls.Add(this.lblFaturaTur);
            this.grpFaturaListe.Controls.Add(this.txtCariUnvan);
            this.grpFaturaListe.Controls.Add(this.lblCariUnvan);
            this.grpFaturaListe.Controls.Add(this.txtFaturaNo);
            this.grpFaturaListe.Controls.Add(this.lblFaturaNo);
            this.grpFaturaListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpFaturaListe.Location = new System.Drawing.Point(0, 0);
            this.grpFaturaListe.Name = "grpFaturaListe";
            this.grpFaturaListe.Size = new System.Drawing.Size(131, 448);
            this.grpFaturaListe.TabIndex = 0;
            this.grpFaturaListe.TabStop = false;
            this.grpFaturaListe.Text = "Fatura Bilgileri";
            // 
            // lblFaturaTurler
            // 
            this.lblFaturaTurler.Location = new System.Drawing.Point(6, 88);
            this.lblFaturaTurler.Name = "lblFaturaTurler";
            this.lblFaturaTurler.Size = new System.Drawing.Size(119, 33);
            this.lblFaturaTurler.TabIndex = 11;
            this.lblFaturaTurler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFaturaTarih
            // 
            this.grpFaturaTarih.Controls.Add(this.lblTarihBaslangic);
            this.grpFaturaTarih.Controls.Add(this.dtpTarihBitis);
            this.grpFaturaTarih.Controls.Add(this.lblTarihBitis);
            this.grpFaturaTarih.Controls.Add(this.dtpTarihBaslangic);
            this.grpFaturaTarih.Location = new System.Drawing.Point(6, 172);
            this.grpFaturaTarih.Name = "grpFaturaTarih";
            this.grpFaturaTarih.Size = new System.Drawing.Size(119, 133);
            this.grpFaturaTarih.TabIndex = 10;
            this.grpFaturaTarih.TabStop = false;
            this.grpFaturaTarih.Text = "Fatura Tarihi";
            // 
            // lblTarihBaslangic
            // 
            this.lblTarihBaslangic.AutoSize = true;
            this.lblTarihBaslangic.Location = new System.Drawing.Point(25, 22);
            this.lblTarihBaslangic.Name = "lblTarihBaslangic";
            this.lblTarihBaslangic.Size = new System.Drawing.Size(69, 17);
            this.lblTarihBaslangic.TabIndex = 6;
            this.lblTarihBaslangic.Text = "Başlangıç...";
            // 
            // dtpTarihBitis
            // 
            this.dtpTarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihBitis.Location = new System.Drawing.Point(18, 91);
            this.dtpTarihBitis.Name = "dtpTarihBitis";
            this.dtpTarihBitis.Size = new System.Drawing.Size(83, 24);
            this.dtpTarihBitis.TabIndex = 9;
            this.dtpTarihBitis.ValueChanged += new System.EventHandler(this.FaturaListe_TextChanged);
            // 
            // lblTarihBitis
            // 
            this.lblTarihBitis.AutoSize = true;
            this.lblTarihBitis.Location = new System.Drawing.Point(37, 71);
            this.lblTarihBitis.Name = "lblTarihBitis";
            this.lblTarihBitis.Size = new System.Drawing.Size(45, 17);
            this.lblTarihBitis.TabIndex = 8;
            this.lblTarihBitis.Text = "Bitiş...";
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(18, 42);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(83, 24);
            this.dtpTarihBaslangic.TabIndex = 7;
            this.dtpTarihBaslangic.ValueChanged += new System.EventHandler(this.FaturaListe_TextChanged);
            // 
            // lblFaturaTur
            // 
            this.lblFaturaTur.AutoSize = true;
            this.lblFaturaTur.Location = new System.Drawing.Point(6, 71);
            this.lblFaturaTur.Name = "lblFaturaTur";
            this.lblFaturaTur.Size = new System.Drawing.Size(75, 17);
            this.lblFaturaTur.TabIndex = 2;
            this.lblFaturaTur.Text = "Fatura Türü";
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(6, 142);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(119, 24);
            this.txtCariUnvan.TabIndex = 5;
            this.txtCariUnvan.TextChanged += new System.EventHandler(this.FaturaListe_TextChanged);
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
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(6, 42);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(119, 24);
            this.txtFaturaNo.TabIndex = 1;
            this.txtFaturaNo.TextChanged += new System.EventHandler(this.FaturaListe_TextChanged);
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(6, 22);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(65, 17);
            this.lblFaturaNo.TabIndex = 0;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // dgvFaturaListe
            // 
            this.dgvFaturaListe.AllowUserToAddRows = false;
            this.dgvFaturaListe.AllowUserToDeleteRows = false;
            this.dgvFaturaListe.AllowUserToResizeRows = false;
            this.dgvFaturaListe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturaListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaturaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFaturaId,
            this.colFaturaNo,
            this.colFaturaTur,
            this.colCariUnvan,
            this.colFaturaTutar,
            this.colFaturaTarih,
            this.colAciklama});
            this.dgvFaturaListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturaListe.Location = new System.Drawing.Point(131, 0);
            this.dgvFaturaListe.MultiSelect = false;
            this.dgvFaturaListe.Name = "dgvFaturaListe";
            this.dgvFaturaListe.ReadOnly = true;
            this.dgvFaturaListe.RowHeadersVisible = false;
            this.dgvFaturaListe.RowTemplate.Height = 25;
            this.dgvFaturaListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturaListe.Size = new System.Drawing.Size(716, 448);
            this.dgvFaturaListe.TabIndex = 1;
            this.dgvFaturaListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFaturaListe_CellDoubleClick);
            // 
            // colFaturaId
            // 
            this.colFaturaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFaturaId.HeaderText = "Id";
            this.colFaturaId.Name = "colFaturaId";
            this.colFaturaId.ReadOnly = true;
            this.colFaturaId.Visible = false;
            this.colFaturaId.Width = 27;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaNo.DataPropertyName = "No";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFaturaNo.HeaderText = "No";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.ReadOnly = true;
            this.colFaturaNo.Width = 49;
            // 
            // colFaturaTur
            // 
            this.colFaturaTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaTur.DataPropertyName = "Tur";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaTur.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFaturaTur.HeaderText = "Tür";
            this.colFaturaTur.Name = "colFaturaTur";
            this.colFaturaTur.ReadOnly = true;
            this.colFaturaTur.Width = 53;
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
            // colFaturaTutar
            // 
            this.colFaturaTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaTutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "#,###.## TL";
            dataGridViewCellStyle6.NullValue = "0";
            this.colFaturaTutar.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFaturaTutar.HeaderText = "Tutar";
            this.colFaturaTutar.Name = "colFaturaTutar";
            this.colFaturaTutar.ReadOnly = true;
            this.colFaturaTutar.Width = 65;
            // 
            // colFaturaTarih
            // 
            this.colFaturaTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaTarih.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFaturaTarih.HeaderText = "Tarih";
            this.colFaturaTarih.Name = "colFaturaTarih";
            this.colFaturaTarih.ReadOnly = true;
            this.colFaturaTarih.Width = 63;
            // 
            // colAciklama
            // 
            this.colAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle8;
            this.colAciklama.HeaderText = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // FrmFaturaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 448);
            this.Controls.Add(this.dgvFaturaListe);
            this.Controls.Add(this.grpFaturaListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 675);
            this.MinimumSize = new System.Drawing.Size(863, 487);
            this.Name = "FrmFaturaListe";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListe_Load);
            this.grpFaturaListe.ResumeLayout(false);
            this.grpFaturaListe.PerformLayout();
            this.grpFaturaTarih.ResumeLayout(false);
            this.grpFaturaTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFaturaListe;
        private System.Windows.Forms.DataGridView dgvFaturaListe;
        private System.Windows.Forms.Label lblTarihBaslangic;
        private System.Windows.Forms.Label lblFaturaTur;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.Label lblTarihBitis;
        private DateTimePicker dtpTarihBitis;
        private DateTimePicker dtpTarihBaslangic;
        private GroupBox grpFaturaTarih;
        private Label lblFaturaTurler;
        private DataGridViewTextBoxColumn colFaturaId;
        private DataGridViewTextBoxColumn colFaturaNo;
        private DataGridViewTextBoxColumn colFaturaTur;
        private DataGridViewTextBoxColumn colCariUnvan;
        private DataGridViewTextBoxColumn colFaturaTutar;
        private DataGridViewTextBoxColumn colFaturaTarih;
        private DataGridViewTextBoxColumn colAciklama;
    }
}
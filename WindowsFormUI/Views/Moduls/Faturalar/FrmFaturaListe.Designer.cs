
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListe));
            this.grpFaturaListe = new System.Windows.Forms.GroupBox();
            this.grpFaturaTarih = new System.Windows.Forms.GroupBox();
            this.lblTarihBaslangic = new System.Windows.Forms.Label();
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.lblTarihBitis = new System.Windows.Forms.Label();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbFaturaTur = new System.Windows.Forms.ComboBox();
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
            this.colFaturaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFaturaListe.SuspendLayout();
            this.grpFaturaTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFaturaListe
            // 
            this.grpFaturaListe.Controls.Add(this.grpFaturaTarih);
            this.grpFaturaListe.Controls.Add(this.cmbFaturaTur);
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
            // cmbFaturaTur
            // 
            this.cmbFaturaTur.FormattingEnabled = true;
            this.cmbFaturaTur.Items.AddRange(new object[] {
            "<<tümünü seç>>",
            "Alış Faturası",
            "Satış Faturası",
            "Alış İade Faturası",
            "Satış İade Faturası"});
            this.cmbFaturaTur.Location = new System.Drawing.Point(6, 92);
            this.cmbFaturaTur.Name = "cmbFaturaTur";
            this.cmbFaturaTur.Size = new System.Drawing.Size(119, 25);
            this.cmbFaturaTur.TabIndex = 3;
            this.cmbFaturaTur.SelectedIndexChanged += new System.EventHandler(this.FaturaListe_TextChanged);
            this.cmbFaturaTur.TextChanged += new System.EventHandler(this.FaturaListe_TextChanged);
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
            this.dgvFaturaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFaturaId,
            this.colFaturaNo,
            this.colFaturaTur,
            this.colCariUnvan,
            this.colFaturaTarih});
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFaturaId.HeaderText = "Id";
            this.colFaturaId.Name = "colFaturaId";
            this.colFaturaId.ReadOnly = true;
            this.colFaturaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFaturaId.Visible = false;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaNo.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFaturaNo.HeaderText = "Fatura No";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.ReadOnly = true;
            this.colFaturaNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFaturaNo.Width = 90;
            // 
            // colFaturaTur
            // 
            this.colFaturaTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaTur.DataPropertyName = "FaturaTur";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaTur.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFaturaTur.HeaderText = "Fatura Tür";
            this.colFaturaTur.Name = "colFaturaTur";
            this.colFaturaTur.ReadOnly = true;
            this.colFaturaTur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFaturaTur.Width = 87;
            // 
            // colCariUnvan
            // 
            this.colCariUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCariUnvan.DataPropertyName = "Unvan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colCariUnvan.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCariUnvan.HeaderText = "Unvan";
            this.colCariUnvan.Name = "colCariUnvan";
            this.colCariUnvan.ReadOnly = true;
            this.colCariUnvan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colFaturaTarih
            // 
            this.colFaturaTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFaturaTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colFaturaTarih.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFaturaTarih.HeaderText = "Fatura Tarihi";
            this.colFaturaTarih.Name = "colFaturaTarih";
            this.colFaturaTarih.ReadOnly = true;
            this.colFaturaTarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFaturaTarih.Width = 99;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFaturaListe_FormClosing);
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
        private ComboBox cmbFaturaTur;
        private DateTimePicker dtpTarihBitis;
        private DateTimePicker dtpTarihBaslangic;
        private GroupBox grpFaturaTarih;
        private DataGridViewTextBoxColumn colFaturaId;
        private DataGridViewTextBoxColumn colFaturaNo;
        private DataGridViewTextBoxColumn colFaturaTur;
        private DataGridViewTextBoxColumn colCariUnvan;
        private DataGridViewTextBoxColumn colFaturaTarih;
    }
}
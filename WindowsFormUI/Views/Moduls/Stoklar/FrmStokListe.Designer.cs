
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Stoklar
{
    partial class FrmStokListe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokListe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpStokListe = new System.Windows.Forms.GroupBox();
            this.lsbCategoryler = new System.Windows.Forms.ListBox();
            this.lblCategoryler = new System.Windows.Forms.Label();
            this.txtStokBirim = new System.Windows.Forms.TextBox();
            this.lblStokBirim = new System.Windows.Forms.Label();
            this.txtStokKDV = new System.Windows.Forms.TextBox();
            this.lblStokKDV = new System.Windows.Forms.Label();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.lblStokAd = new System.Windows.Forms.Label();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.lblStokBarkod = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.btnStokGrupSil = new System.Windows.Forms.Button();
            this.btnStokGrupEkle = new System.Windows.Forms.Button();
            this.dgvStokListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMevcutMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msShowColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowKod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowBarkod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowAd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowKDV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowMevcutMiktar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowBirim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStokListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).BeginInit();
            this.msShowColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStokListe
            // 
            this.grpStokListe.Controls.Add(this.lsbCategoryler);
            this.grpStokListe.Controls.Add(this.lblCategoryler);
            this.grpStokListe.Controls.Add(this.txtStokBirim);
            this.grpStokListe.Controls.Add(this.lblStokBirim);
            this.grpStokListe.Controls.Add(this.txtStokKDV);
            this.grpStokListe.Controls.Add(this.lblStokKDV);
            this.grpStokListe.Controls.Add(this.txtStokAd);
            this.grpStokListe.Controls.Add(this.lblStokAd);
            this.grpStokListe.Controls.Add(this.txtStokBarkod);
            this.grpStokListe.Controls.Add(this.lblStokBarkod);
            this.grpStokListe.Controls.Add(this.txtStokKod);
            this.grpStokListe.Controls.Add(this.lblStokKod);
            this.grpStokListe.Controls.Add(this.btnStokGrupSil);
            this.grpStokListe.Controls.Add(this.btnStokGrupEkle);
            this.grpStokListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpStokListe.Location = new System.Drawing.Point(0, 0);
            this.grpStokListe.Name = "grpStokListe";
            this.grpStokListe.Size = new System.Drawing.Size(216, 501);
            this.grpStokListe.TabIndex = 0;
            this.grpStokListe.TabStop = false;
            this.grpStokListe.Text = "Stok Bilgileri";
            // 
            // lsbCategoryler
            // 
            this.lsbCategoryler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbCategoryler.FormattingEnabled = true;
            this.lsbCategoryler.ItemHeight = 17;
            this.lsbCategoryler.Location = new System.Drawing.Point(3, 341);
            this.lsbCategoryler.Name = "lsbCategoryler";
            this.lsbCategoryler.Size = new System.Drawing.Size(210, 157);
            this.lsbCategoryler.TabIndex = 7;
            // 
            // lblCategoryler
            // 
            this.lblCategoryler.AutoSize = true;
            this.lblCategoryler.Location = new System.Drawing.Point(6, 319);
            this.lblCategoryler.Name = "lblCategoryler";
            this.lblCategoryler.Size = new System.Drawing.Size(50, 17);
            this.lblCategoryler.TabIndex = 12;
            this.lblCategoryler.Text = "Gruplar";
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.Location = new System.Drawing.Point(6, 241);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.Size = new System.Drawing.Size(204, 24);
            this.txtStokBirim.TabIndex = 4;
            this.txtStokBirim.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokBirim
            // 
            this.lblStokBirim.AutoSize = true;
            this.lblStokBirim.Location = new System.Drawing.Point(6, 221);
            this.lblStokBirim.Name = "lblStokBirim";
            this.lblStokBirim.Size = new System.Drawing.Size(42, 17);
            this.lblStokBirim.TabIndex = 8;
            this.lblStokBirim.Text = "Birimi";
            // 
            // txtStokKDV
            // 
            this.txtStokKDV.Location = new System.Drawing.Point(6, 192);
            this.txtStokKDV.Name = "txtStokKDV";
            this.txtStokKDV.Size = new System.Drawing.Size(204, 24);
            this.txtStokKDV.TabIndex = 3;
            this.txtStokKDV.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokKDV
            // 
            this.lblStokKDV.AutoSize = true;
            this.lblStokKDV.Location = new System.Drawing.Point(6, 171);
            this.lblStokKDV.Name = "lblStokKDV";
            this.lblStokKDV.Size = new System.Drawing.Size(32, 17);
            this.lblStokKDV.TabIndex = 6;
            this.lblStokKDV.Text = "KDV";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(6, 142);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(204, 24);
            this.txtStokAd.TabIndex = 2;
            this.txtStokAd.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokAd
            // 
            this.lblStokAd.AutoSize = true;
            this.lblStokAd.Location = new System.Drawing.Point(6, 121);
            this.lblStokAd.Name = "lblStokAd";
            this.lblStokAd.Size = new System.Drawing.Size(56, 17);
            this.lblStokAd.TabIndex = 4;
            this.lblStokAd.Text = "Stok Adı";
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Location = new System.Drawing.Point(6, 92);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(204, 24);
            this.txtStokBarkod.TabIndex = 1;
            this.txtStokBarkod.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokBarkod
            // 
            this.lblStokBarkod.AutoSize = true;
            this.lblStokBarkod.Location = new System.Drawing.Point(6, 71);
            this.lblStokBarkod.Name = "lblStokBarkod";
            this.lblStokBarkod.Size = new System.Drawing.Size(52, 17);
            this.lblStokBarkod.TabIndex = 2;
            this.lblStokBarkod.Text = "Barkodu";
            // 
            // txtStokKod
            // 
            this.txtStokKod.Location = new System.Drawing.Point(6, 42);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(204, 24);
            this.txtStokKod.TabIndex = 0;
            this.txtStokKod.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(6, 22);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(63, 17);
            this.lblStokKod.TabIndex = 0;
            this.lblStokKod.Text = "Stok Kodu";
            // 
            // btnStokGrupSil
            // 
            this.btnStokGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnStokGrupSil.Image")));
            this.btnStokGrupSil.Location = new System.Drawing.Point(126, 271);
            this.btnStokGrupSil.Name = "btnStokGrupSil";
            this.btnStokGrupSil.Size = new System.Drawing.Size(43, 45);
            this.btnStokGrupSil.TabIndex = 8;
            this.btnStokGrupSil.UseVisualStyleBackColor = true;
            this.btnStokGrupSil.Click += new System.EventHandler(this.BtnStokGrupSil_Click);
            // 
            // btnStokGrupEkle
            // 
            this.btnStokGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnStokGrupEkle.Image")));
            this.btnStokGrupEkle.Location = new System.Drawing.Point(42, 271);
            this.btnStokGrupEkle.Name = "btnStokGrupEkle";
            this.btnStokGrupEkle.Size = new System.Drawing.Size(43, 45);
            this.btnStokGrupEkle.TabIndex = 6;
            this.btnStokGrupEkle.UseVisualStyleBackColor = true;
            this.btnStokGrupEkle.Click += new System.EventHandler(this.BtnStokGrupEkle_Click);
            // 
            // dgvStokListe
            // 
            this.dgvStokListe.AllowUserToAddRows = false;
            this.dgvStokListe.AllowUserToDeleteRows = false;
            this.dgvStokListe.AllowUserToOrderColumns = true;
            this.dgvStokListe.AllowUserToResizeRows = false;
            this.dgvStokListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvStokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colBarkod,
            this.colAd,
            this.colKDV,
            this.colMevcutMiktar,
            this.colBirim});
            this.dgvStokListe.ContextMenuStrip = this.msShowColumns;
            this.dgvStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokListe.Location = new System.Drawing.Point(216, 0);
            this.dgvStokListe.MultiSelect = false;
            this.dgvStokListe.Name = "dgvStokListe";
            this.dgvStokListe.ReadOnly = true;
            this.dgvStokListe.RowHeadersVisible = false;
            this.dgvStokListe.RowTemplate.Height = 25;
            this.dgvStokListe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStokListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokListe.Size = new System.Drawing.Size(683, 501);
            this.dgvStokListe.TabIndex = 1;
            this.dgvStokListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStokListe_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colKod
            // 
            this.colKod.DataPropertyName = "Kod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colKod.DefaultCellStyle = dataGridViewCellStyle2;
            this.colKod.HeaderText = "Stok Kodu";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            this.colKod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBarkod
            // 
            this.colBarkod.DataPropertyName = "Barkod";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBarkod.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBarkod.HeaderText = "Barkodu";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colAd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAd.HeaderText = "Stok Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colKDV
            // 
            this.colKDV.DataPropertyName = "KDV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colKDV.DefaultCellStyle = dataGridViewCellStyle5;
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.ReadOnly = true;
            this.colKDV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colKDV.Width = 50;
            // 
            // colMevcutMiktar
            // 
            this.colMevcutMiktar.DataPropertyName = "MevcutBakiye";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = null;
            this.colMevcutMiktar.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMevcutMiktar.HeaderText = "Mevcut Stok";
            this.colMevcutMiktar.Name = "colMevcutMiktar";
            this.colMevcutMiktar.ReadOnly = true;
            this.colMevcutMiktar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMevcutMiktar.Width = 150;
            // 
            // colBirim
            // 
            this.colBirim.DataPropertyName = "Birim";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colBirim.DefaultCellStyle = dataGridViewCellStyle7;
            this.colBirim.HeaderText = "Birimi";
            this.colBirim.Name = "colBirim";
            this.colBirim.ReadOnly = true;
            this.colBirim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // msShowColumns
            // 
            this.msShowColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSperator1,
            this.tsmiShowKod,
            this.tsmiShowBarkod,
            this.tsmiShowAd,
            this.tsmiShowKDV,
            this.tsmiShowMevcutMiktar,
            this.tsmiShowBirim,
            this.toolStripSeparator1,
            this.yazdırToolStripMenuItem});
            this.msShowColumns.Name = "msShowColumns";
            this.msShowColumns.Size = new System.Drawing.Size(145, 170);
            this.msShowColumns.Text = "Sütunları Göster/Gizle";
            // 
            // tsmiSperator1
            // 
            this.tsmiSperator1.Name = "tsmiSperator1";
            this.tsmiSperator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiShowKod
            // 
            this.tsmiShowKod.Checked = true;
            this.tsmiShowKod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowKod.Name = "tsmiShowKod";
            this.tsmiShowKod.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowKod.Text = "Stok Kodu";
            this.tsmiShowKod.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiShowBarkod
            // 
            this.tsmiShowBarkod.Checked = true;
            this.tsmiShowBarkod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowBarkod.Name = "tsmiShowBarkod";
            this.tsmiShowBarkod.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowBarkod.Text = "Stok Barkodu";
            this.tsmiShowBarkod.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiShowAd
            // 
            this.tsmiShowAd.Checked = true;
            this.tsmiShowAd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowAd.Name = "tsmiShowAd";
            this.tsmiShowAd.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowAd.Text = "Stok Adı";
            this.tsmiShowAd.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiShowKDV
            // 
            this.tsmiShowKDV.Checked = true;
            this.tsmiShowKDV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowKDV.Name = "tsmiShowKDV";
            this.tsmiShowKDV.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowKDV.Text = "KDV";
            this.tsmiShowKDV.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiShowMevcutMiktar
            // 
            this.tsmiShowMevcutMiktar.Checked = true;
            this.tsmiShowMevcutMiktar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowMevcutMiktar.Name = "tsmiShowMevcutMiktar";
            this.tsmiShowMevcutMiktar.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowMevcutMiktar.Text = "Mevcut Stok";
            this.tsmiShowMevcutMiktar.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiShowBirim
            // 
            this.tsmiShowBirim.Checked = true;
            this.tsmiShowBirim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowBirim.Name = "tsmiShowBirim";
            this.tsmiShowBirim.Size = new System.Drawing.Size(144, 22);
            this.tsmiShowBirim.Text = "Birim";
            this.tsmiShowBirim.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // FrmStokListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 501);
            this.Controls.Add(this.dgvStokListe);
            this.Controls.Add(this.grpStokListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStokListe";
            this.Text = "Stok Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStokListe_FormClosing);
            this.grpStokListe.ResumeLayout(false);
            this.grpStokListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).EndInit();
            this.msShowColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStokListe;
        private System.Windows.Forms.DataGridView dgvStokListe;
        private System.Windows.Forms.TextBox txtStokKDV;
        private System.Windows.Forms.Label lblStokKDV;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.Label lblStokAd;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.Label lblStokBarkod;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Button btnStokGrupSil;
        private System.Windows.Forms.Button btnStokGrupEkle;
        private System.Windows.Forms.TextBox txtStokBirim;
        private System.Windows.Forms.Label lblStokBirim;
        private ListBox lsbCategoryler;
        private Label lblCategoryler;
        private ContextMenuStrip msShowColumns;
        private ToolStripSeparator tsmiSperator1;
        private ToolStripMenuItem tsmiShowKod;
        private ToolStripMenuItem tsmiShowBarkod;
        private ToolStripMenuItem tsmiShowAd;
        private ToolStripMenuItem tsmiShowKDV;
        private ToolStripMenuItem tsmiShowBirim;
        private ToolStripMenuItem tsmiShowBirim2;
        private ToolStripMenuItem tsmiShowBirim2Oran;
        private ToolStripMenuItem tsmiShowMevcutMiktar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colKod;
        private DataGridViewTextBoxColumn colBarkod;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colKDV;
        private DataGridViewTextBoxColumn colMevcutMiktar;
        private DataGridViewTextBoxColumn colBirim;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem yazdırToolStripMenuItem;
    }
}
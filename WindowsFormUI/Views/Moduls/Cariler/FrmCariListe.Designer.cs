
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Cariler
{
    partial class FrmCariListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariListe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpCariListe = new System.Windows.Forms.GroupBox();
            this.txtCariIlce = new System.Windows.Forms.TextBox();
            this.lblCariIlce = new System.Windows.Forms.Label();
            this.txtCariIl = new System.Windows.Forms.TextBox();
            this.lblCariIl = new System.Windows.Forms.Label();
            this.txtCariEposta = new System.Windows.Forms.TextBox();
            this.lblCariEposta = new System.Windows.Forms.Label();
            this.lsbCategoryler = new System.Windows.Forms.ListBox();
            this.lblCategoryler = new System.Windows.Forms.Label();
            this.txtCariWeb = new System.Windows.Forms.TextBox();
            this.lblCariWeb = new System.Windows.Forms.Label();
            this.txtCariTelefon = new System.Windows.Forms.TextBox();
            this.lblCariTelefon = new System.Windows.Forms.Label();
            this.txtCariVergiNo = new System.Windows.Forms.TextBox();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.txtCariVergiDairesi = new System.Windows.Forms.TextBox();
            this.lblCariVergiDairesi = new System.Windows.Forms.Label();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.btnCariGrupSil = new System.Windows.Forms.Button();
            this.btnCariGrupEkle = new System.Windows.Forms.Button();
            this.dgvCariListe = new System.Windows.Forms.DataGridView();
            this.msShowColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCariKod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariUnvan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariVergiDairesi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariVergiNo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariTelefon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariTelefon2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariFax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariEPosta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariIl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariIlce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariAcikAdres = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariBakiye = new System.Windows.Forms.ToolStripMenuItem();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeb = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEPosta = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colIl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIlce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcikAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCariListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).BeginInit();
            this.msShowColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCariListe
            // 
            this.grpCariListe.Controls.Add(this.txtCariIlce);
            this.grpCariListe.Controls.Add(this.lblCariIlce);
            this.grpCariListe.Controls.Add(this.txtCariIl);
            this.grpCariListe.Controls.Add(this.lblCariIl);
            this.grpCariListe.Controls.Add(this.txtCariEposta);
            this.grpCariListe.Controls.Add(this.lblCariEposta);
            this.grpCariListe.Controls.Add(this.lsbCategoryler);
            this.grpCariListe.Controls.Add(this.lblCategoryler);
            this.grpCariListe.Controls.Add(this.txtCariWeb);
            this.grpCariListe.Controls.Add(this.lblCariWeb);
            this.grpCariListe.Controls.Add(this.txtCariTelefon);
            this.grpCariListe.Controls.Add(this.lblCariTelefon);
            this.grpCariListe.Controls.Add(this.txtCariVergiNo);
            this.grpCariListe.Controls.Add(this.lblVergiNo);
            this.grpCariListe.Controls.Add(this.txtCariVergiDairesi);
            this.grpCariListe.Controls.Add(this.lblCariVergiDairesi);
            this.grpCariListe.Controls.Add(this.txtCariUnvan);
            this.grpCariListe.Controls.Add(this.lblCariUnvan);
            this.grpCariListe.Controls.Add(this.txtCariKod);
            this.grpCariListe.Controls.Add(this.lblCariKod);
            this.grpCariListe.Controls.Add(this.btnCariGrupSil);
            this.grpCariListe.Controls.Add(this.btnCariGrupEkle);
            this.grpCariListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCariListe.Location = new System.Drawing.Point(0, 0);
            this.grpCariListe.Name = "grpCariListe";
            this.grpCariListe.Size = new System.Drawing.Size(131, 567);
            this.grpCariListe.TabIndex = 0;
            this.grpCariListe.TabStop = false;
            this.grpCariListe.Text = "Cari Bilgileri";
            // 
            // txtCariIlce
            // 
            this.txtCariIlce.Location = new System.Drawing.Point(6, 414);
            this.txtCariIlce.Name = "txtCariIlce";
            this.txtCariIlce.Size = new System.Drawing.Size(119, 24);
            this.txtCariIlce.TabIndex = 17;
            this.txtCariIlce.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariIlce
            // 
            this.lblCariIlce.AutoSize = true;
            this.lblCariIlce.Location = new System.Drawing.Point(6, 394);
            this.lblCariIlce.Name = "lblCariIlce";
            this.lblCariIlce.Size = new System.Drawing.Size(31, 17);
            this.lblCariIlce.TabIndex = 16;
            this.lblCariIlce.Text = "İlçe";
            // 
            // txtCariIl
            // 
            this.txtCariIl.Location = new System.Drawing.Point(6, 367);
            this.txtCariIl.Name = "txtCariIl";
            this.txtCariIl.Size = new System.Drawing.Size(119, 24);
            this.txtCariIl.TabIndex = 15;
            this.txtCariIl.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariIl
            // 
            this.lblCariIl.AutoSize = true;
            this.lblCariIl.Location = new System.Drawing.Point(6, 347);
            this.lblCariIl.Name = "lblCariIl";
            this.lblCariIl.Size = new System.Drawing.Size(19, 17);
            this.lblCariIl.TabIndex = 14;
            this.lblCariIl.Text = "İl";
            // 
            // txtCariEposta
            // 
            this.txtCariEposta.Location = new System.Drawing.Point(6, 320);
            this.txtCariEposta.Name = "txtCariEposta";
            this.txtCariEposta.Size = new System.Drawing.Size(119, 24);
            this.txtCariEposta.TabIndex = 13;
            this.txtCariEposta.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariEposta
            // 
            this.lblCariEposta.AutoSize = true;
            this.lblCariEposta.Location = new System.Drawing.Point(6, 300);
            this.lblCariEposta.Name = "lblCariEposta";
            this.lblCariEposta.Size = new System.Drawing.Size(46, 17);
            this.lblCariEposta.TabIndex = 12;
            this.lblCariEposta.Text = "EPosta";
            // 
            // lsbCategoryler
            // 
            this.lsbCategoryler.FormattingEnabled = true;
            this.lsbCategoryler.ItemHeight = 17;
            this.lsbCategoryler.Location = new System.Drawing.Point(6, 495);
            this.lsbCategoryler.Name = "lsbCategoryler";
            this.lsbCategoryler.Size = new System.Drawing.Size(119, 72);
            this.lsbCategoryler.TabIndex = 21;
            // 
            // lblCategoryler
            // 
            this.lblCategoryler.AutoSize = true;
            this.lblCategoryler.Location = new System.Drawing.Point(6, 475);
            this.lblCategoryler.Name = "lblCategoryler";
            this.lblCategoryler.Size = new System.Drawing.Size(50, 17);
            this.lblCategoryler.TabIndex = 20;
            this.lblCategoryler.Text = "Gruplar";
            // 
            // txtCariWeb
            // 
            this.txtCariWeb.Location = new System.Drawing.Point(6, 273);
            this.txtCariWeb.Name = "txtCariWeb";
            this.txtCariWeb.Size = new System.Drawing.Size(119, 24);
            this.txtCariWeb.TabIndex = 11;
            this.txtCariWeb.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariWeb
            // 
            this.lblCariWeb.AutoSize = true;
            this.lblCariWeb.Location = new System.Drawing.Point(6, 253);
            this.lblCariWeb.Name = "lblCariWeb";
            this.lblCariWeb.Size = new System.Drawing.Size(32, 17);
            this.lblCariWeb.TabIndex = 10;
            this.lblCariWeb.Text = "Web";
            // 
            // txtCariTelefon
            // 
            this.txtCariTelefon.Location = new System.Drawing.Point(6, 226);
            this.txtCariTelefon.Name = "txtCariTelefon";
            this.txtCariTelefon.Size = new System.Drawing.Size(119, 24);
            this.txtCariTelefon.TabIndex = 9;
            this.txtCariTelefon.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariTelefon
            // 
            this.lblCariTelefon.AutoSize = true;
            this.lblCariTelefon.Location = new System.Drawing.Point(6, 206);
            this.lblCariTelefon.Name = "lblCariTelefon";
            this.lblCariTelefon.Size = new System.Drawing.Size(50, 17);
            this.lblCariTelefon.TabIndex = 8;
            this.lblCariTelefon.Text = "Telefon";
            // 
            // txtCariVergiNo
            // 
            this.txtCariVergiNo.Location = new System.Drawing.Point(6, 179);
            this.txtCariVergiNo.Name = "txtCariVergiNo";
            this.txtCariVergiNo.Size = new System.Drawing.Size(119, 24);
            this.txtCariVergiNo.TabIndex = 7;
            this.txtCariVergiNo.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Location = new System.Drawing.Point(6, 159);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(58, 17);
            this.lblVergiNo.TabIndex = 6;
            this.lblVergiNo.Text = "Vergi No";
            // 
            // txtCariVergiDairesi
            // 
            this.txtCariVergiDairesi.Location = new System.Drawing.Point(6, 132);
            this.txtCariVergiDairesi.Name = "txtCariVergiDairesi";
            this.txtCariVergiDairesi.Size = new System.Drawing.Size(119, 24);
            this.txtCariVergiDairesi.TabIndex = 5;
            this.txtCariVergiDairesi.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariVergiDairesi
            // 
            this.lblCariVergiDairesi.AutoSize = true;
            this.lblCariVergiDairesi.Location = new System.Drawing.Point(6, 112);
            this.lblCariVergiDairesi.Name = "lblCariVergiDairesi";
            this.lblCariVergiDairesi.Size = new System.Drawing.Size(83, 17);
            this.lblCariVergiDairesi.TabIndex = 4;
            this.lblCariVergiDairesi.Text = "Vergi Dairesi";
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(6, 85);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(119, 24);
            this.txtCariUnvan.TabIndex = 3;
            this.txtCariUnvan.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
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
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(6, 38);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(119, 24);
            this.txtCariKod.TabIndex = 1;
            this.txtCariKod.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(6, 18);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(60, 17);
            this.lblCariKod.TabIndex = 0;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // btnCariGrupSil
            // 
            this.btnCariGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnCariGrupSil.Image")));
            this.btnCariGrupSil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCariGrupSil.Location = new System.Drawing.Point(86, 440);
            this.btnCariGrupSil.Name = "btnCariGrupSil";
            this.btnCariGrupSil.Size = new System.Drawing.Size(32, 32);
            this.btnCariGrupSil.TabIndex = 19;
            this.btnCariGrupSil.UseVisualStyleBackColor = true;
            this.btnCariGrupSil.Click += new System.EventHandler(this.BtnCariGrupSil_Click);
            // 
            // btnCariGrupEkle
            // 
            this.btnCariGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnCariGrupEkle.Image")));
            this.btnCariGrupEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCariGrupEkle.Location = new System.Drawing.Point(10, 440);
            this.btnCariGrupEkle.Name = "btnCariGrupEkle";
            this.btnCariGrupEkle.Size = new System.Drawing.Size(32, 32);
            this.btnCariGrupEkle.TabIndex = 18;
            this.btnCariGrupEkle.UseVisualStyleBackColor = true;
            this.btnCariGrupEkle.Click += new System.EventHandler(this.BtnCariGrupEkle_Click);
            // 
            // dgvCariListe
            // 
            this.dgvCariListe.AllowUserToAddRows = false;
            this.dgvCariListe.AllowUserToDeleteRows = false;
            this.dgvCariListe.AllowUserToResizeRows = false;
            this.dgvCariListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvCariListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colUnvan,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colBakiye,
            this.colTelefon,
            this.colTelefon2,
            this.colFax,
            this.colWeb,
            this.colEPosta,
            this.colIl,
            this.colIlce,
            this.colAcikAdres});
            this.dgvCariListe.ContextMenuStrip = this.msShowColumns;
            this.dgvCariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariListe.Location = new System.Drawing.Point(131, 0);
            this.dgvCariListe.MultiSelect = false;
            this.dgvCariListe.Name = "dgvCariListe";
            this.dgvCariListe.ReadOnly = true;
            this.dgvCariListe.RowHeadersVisible = false;
            this.dgvCariListe.RowTemplate.Height = 25;
            this.dgvCariListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariListe.Size = new System.Drawing.Size(886, 567);
            this.dgvCariListe.TabIndex = 1;
            this.dgvCariListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCariListe_CellDoubleClick);
            // 
            // msShowColumns
            // 
            this.msShowColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeperator1,
            this.tsmiCariKod,
            this.tsmiCariUnvan,
            this.tsmiCariVergiDairesi,
            this.tsmiCariVergiNo,
            this.tsmiCariTelefon,
            this.tsmiCariTelefon2,
            this.tsmiCariFax,
            this.tsmiCariWeb,
            this.tsmiCariEPosta,
            this.tsmiCariIl,
            this.tsmiCariIlce,
            this.tsmiCariAcikAdres,
            this.tsmiCariBakiye});
            this.msShowColumns.Name = "msShowColumns";
            this.msShowColumns.Size = new System.Drawing.Size(152, 296);
            // 
            // tsmiSeperator1
            // 
            this.tsmiSeperator1.Name = "tsmiSeperator1";
            this.tsmiSeperator1.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiCariKod
            // 
            this.tsmiCariKod.Checked = true;
            this.tsmiCariKod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariKod.Name = "tsmiCariKod";
            this.tsmiCariKod.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariKod.Text = "Cari Kod";
            this.tsmiCariKod.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariUnvan
            // 
            this.tsmiCariUnvan.Checked = true;
            this.tsmiCariUnvan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariUnvan.Name = "tsmiCariUnvan";
            this.tsmiCariUnvan.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariUnvan.Text = "Unvan";
            this.tsmiCariUnvan.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariVergiDairesi
            // 
            this.tsmiCariVergiDairesi.Name = "tsmiCariVergiDairesi";
            this.tsmiCariVergiDairesi.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariVergiDairesi.Text = "Vergi Dairesi";
            this.tsmiCariVergiDairesi.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariVergiNo
            // 
            this.tsmiCariVergiNo.Name = "tsmiCariVergiNo";
            this.tsmiCariVergiNo.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariVergiNo.Text = "Vergi No";
            this.tsmiCariVergiNo.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariTelefon
            // 
            this.tsmiCariTelefon.Checked = true;
            this.tsmiCariTelefon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariTelefon.Name = "tsmiCariTelefon";
            this.tsmiCariTelefon.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariTelefon.Text = "Telefon";
            this.tsmiCariTelefon.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariTelefon2
            // 
            this.tsmiCariTelefon2.Name = "tsmiCariTelefon2";
            this.tsmiCariTelefon2.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariTelefon2.Text = "Telefon2";
            this.tsmiCariTelefon2.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariFax
            // 
            this.tsmiCariFax.Name = "tsmiCariFax";
            this.tsmiCariFax.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariFax.Text = "Fax";
            this.tsmiCariFax.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariWeb
            // 
            this.tsmiCariWeb.Name = "tsmiCariWeb";
            this.tsmiCariWeb.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariWeb.Text = "Web";
            this.tsmiCariWeb.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariEPosta
            // 
            this.tsmiCariEPosta.Name = "tsmiCariEPosta";
            this.tsmiCariEPosta.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariEPosta.Text = "E-Posta";
            this.tsmiCariEPosta.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariIl
            // 
            this.tsmiCariIl.Checked = true;
            this.tsmiCariIl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariIl.Name = "tsmiCariIl";
            this.tsmiCariIl.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariIl.Text = "İli";
            this.tsmiCariIl.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariIlce
            // 
            this.tsmiCariIlce.Checked = true;
            this.tsmiCariIlce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariIlce.Name = "tsmiCariIlce";
            this.tsmiCariIlce.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariIlce.Text = "İlçesi";
            this.tsmiCariIlce.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariAcikAdres
            // 
            this.tsmiCariAcikAdres.Name = "tsmiCariAcikAdres";
            this.tsmiCariAcikAdres.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariAcikAdres.Text = "Açık Adres";
            this.tsmiCariAcikAdres.Click += new System.EventHandler(this.TsmiShowColumn_Click);
            // 
            // tsmiCariBakiye
            // 
            this.tsmiCariBakiye.Checked = true;
            this.tsmiCariBakiye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCariBakiye.Name = "tsmiCariBakiye";
            this.tsmiCariBakiye.Size = new System.Drawing.Size(151, 22);
            this.tsmiCariBakiye.Text = "Mevcut Bakiye";
            this.tsmiCariBakiye.Click += new System.EventHandler(this.TsmiShowColumn_Click);
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
            this.colId.Width = 27;
            // 
            // colKod
            // 
            this.colKod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKod.DataPropertyName = "Kod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colKod.DefaultCellStyle = dataGridViewCellStyle2;
            this.colKod.HeaderText = "Cari Kodu";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            this.colKod.Width = 85;
            // 
            // colUnvan
            // 
            this.colUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUnvan.DataPropertyName = "Unvan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colUnvan.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnvan.HeaderText = "Unvanı";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.ReadOnly = true;
            this.colUnvan.Width = 70;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVergiDairesi.DataPropertyName = "VergiDairesi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colVergiDairesi.DefaultCellStyle = dataGridViewCellStyle4;
            this.colVergiDairesi.HeaderText = "Vergi Dairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.ReadOnly = true;
            this.colVergiDairesi.Visible = false;
            this.colVergiDairesi.Width = 108;
            // 
            // colVergiNo
            // 
            this.colVergiNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVergiNo.DataPropertyName = "VergiNo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colVergiNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colVergiNo.HeaderText = "Vergi No";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.ReadOnly = true;
            this.colVergiNo.Visible = false;
            this.colVergiNo.Width = 83;
            // 
            // colBakiye
            // 
            this.colBakiye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBakiye.DataPropertyName = "Bakiye";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "#,###.## TL";
            dataGridViewCellStyle6.NullValue = "0,000.00 TL";
            this.colBakiye.DefaultCellStyle = dataGridViewCellStyle6;
            this.colBakiye.HeaderText = "Mevcut Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.ReadOnly = true;
            this.colBakiye.Width = 113;
            // 
            // colTelefon
            // 
            this.colTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTelefon.DataPropertyName = "Telefon";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colTelefon.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTelefon.HeaderText = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.ReadOnly = true;
            this.colTelefon.Width = 75;
            // 
            // colTelefon2
            // 
            this.colTelefon2.DataPropertyName = "Telefon2";
            this.colTelefon2.HeaderText = "Telefon 2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.ReadOnly = true;
            this.colTelefon2.Visible = false;
            // 
            // colFax
            // 
            this.colFax.DataPropertyName = "Fax";
            this.colFax.HeaderText = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            this.colFax.Visible = false;
            // 
            // colWeb
            // 
            this.colWeb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWeb.DataPropertyName = "Web";
            this.colWeb.HeaderText = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.ReadOnly = true;
            this.colWeb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colWeb.Visible = false;
            this.colWeb.Width = 57;
            // 
            // colEPosta
            // 
            this.colEPosta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEPosta.DataPropertyName = "EPosta";
            this.colEPosta.HeaderText = "EPosta";
            this.colEPosta.Name = "colEPosta";
            this.colEPosta.ReadOnly = true;
            this.colEPosta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEPosta.Visible = false;
            this.colEPosta.Width = 71;
            // 
            // colIl
            // 
            this.colIl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIl.DataPropertyName = "Il";
            this.colIl.HeaderText = "İli";
            this.colIl.Name = "colIl";
            this.colIl.ReadOnly = true;
            this.colIl.Width = 48;
            // 
            // colIlce
            // 
            this.colIlce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIlce.DataPropertyName = "Ilce";
            this.colIlce.HeaderText = "İlçesi";
            this.colIlce.Name = "colIlce";
            this.colIlce.ReadOnly = true;
            this.colIlce.Width = 66;
            // 
            // colAcikAdres
            // 
            this.colAcikAdres.DataPropertyName = "AcikAdres";
            this.colAcikAdres.HeaderText = "Açık Adres";
            this.colAcikAdres.Name = "colAcikAdres";
            this.colAcikAdres.ReadOnly = true;
            this.colAcikAdres.Visible = false;
            // 
            // FrmCariListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 567);
            this.Controls.Add(this.dgvCariListe);
            this.Controls.Add(this.grpCariListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCariListe";
            this.ShowInTaskbar = false;
            this.Text = "Cari Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCariListe_FormClosing);
            this.Load += new System.EventHandler(this.FrmCariListe_Load);
            this.grpCariListe.ResumeLayout(false);
            this.grpCariListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).EndInit();
            this.msShowColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCariListe;
        private System.Windows.Forms.DataGridView dgvCariListe;
        private System.Windows.Forms.TextBox txtCariVergiNo;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.TextBox txtCariVergiDairesi;
        private System.Windows.Forms.Label lblCariVergiDairesi;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.Button btnCariGrupSil;
        private System.Windows.Forms.Button btnCariGrupEkle;
        private System.Windows.Forms.TextBox txtCariWeb;
        private System.Windows.Forms.Label lblCariWeb;
        private System.Windows.Forms.TextBox txtCariTelefon;
        private System.Windows.Forms.Label lblCariTelefon;
        private ListBox lsbCategoryler;
        private Label lblCategoryler;
        private TextBox txtCariEposta;
        private Label lblCariEposta;
        private TextBox txtCariIlce;
        private Label lblCariIlce;
        private TextBox txtCariIl;
        private Label lblCariIl;
        private ContextMenuStrip msShowColumns;
        private ToolStripSeparator tsmiSeperator1;
        private ToolStripMenuItem tsmiCariKod;
        private ToolStripMenuItem tsmiCariUnvan;
        private ToolStripMenuItem tsmiCariVergiDairesi;
        private ToolStripMenuItem tsmiCariVergiNo;
        private ToolStripMenuItem tsmiCariTelefon;
        private ToolStripMenuItem tsmiCariWeb;
        private ToolStripMenuItem tsmiCariEPosta;
        private ToolStripMenuItem tsmiCariIl;
        private ToolStripMenuItem tsmiCariIlce;
        private ToolStripMenuItem tsmiCariAcikAdres;
        private ToolStripMenuItem tsmiCariBakiye;
        private ToolStripMenuItem tsmiCariTelefon2;
        private ToolStripMenuItem tsmiCariFax;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colKod;
        private DataGridViewTextBoxColumn colUnvan;
        private DataGridViewTextBoxColumn colVergiDairesi;
        private DataGridViewTextBoxColumn colVergiNo;
        private DataGridViewTextBoxColumn colBakiye;
        private DataGridViewTextBoxColumn colTelefon;
        private DataGridViewTextBoxColumn colTelefon2;
        private DataGridViewTextBoxColumn colFax;
        private DataGridViewLinkColumn colWeb;
        private DataGridViewLinkColumn colEPosta;
        private DataGridViewTextBoxColumn colIl;
        private DataGridViewTextBoxColumn colIlce;
        private DataGridViewTextBoxColumn colAcikAdres;
    }
}
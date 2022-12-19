
namespace WindowsFormUI.Views.Moduls.Stoklar
{
    partial class FrmStokKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokKart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpStok = new System.Windows.Forms.GroupBox();
            this.txtStokBirim = new System.Windows.Forms.TextBox();
            this.btnStokBul = new System.Windows.Forms.Button();
            this.lblStokBirim = new System.Windows.Forms.Label();
            this.txtStokKDV = new System.Windows.Forms.TextBox();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.lblStokKDV = new System.Windows.Forms.Label();
            this.lblStokAd = new System.Windows.Forms.Label();
            this.lblStokBarkod = new System.Windows.Forms.Label();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.grpGrup = new System.Windows.Forms.GroupBox();
            this.dgvGrupView = new System.Windows.Forms.DataGridView();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrupSil = new System.Windows.Forms.Button();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.uscStokEkleSilButon = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.dgvStokListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFrmStok = new System.Windows.Forms.TabControl();
            this.tabStokKart = new System.Windows.Forms.TabPage();
            this.tabStokHareket = new System.Windows.Forms.TabPage();
            this.grpStokHareketler = new System.Windows.Forms.GroupBox();
            this.dgvStokHareketler = new System.Windows.Forms.DataGridView();
            this.colHareketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStokId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrutTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imLStokKart = new System.Windows.Forms.ImageList(this.components);
            this.grpStok.SuspendLayout();
            this.grpGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).BeginInit();
            this.tabFrmStok.SuspendLayout();
            this.tabStokKart.SuspendLayout();
            this.tabStokHareket.SuspendLayout();
            this.grpStokHareketler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStok
            // 
            this.grpStok.Controls.Add(this.txtStokBirim);
            this.grpStok.Controls.Add(this.btnStokBul);
            this.grpStok.Controls.Add(this.lblStokBirim);
            this.grpStok.Controls.Add(this.txtStokKDV);
            this.grpStok.Controls.Add(this.txtStokAd);
            this.grpStok.Controls.Add(this.txtStokBarkod);
            this.grpStok.Controls.Add(this.txtStokKod);
            this.grpStok.Controls.Add(this.lblStokKDV);
            this.grpStok.Controls.Add(this.lblStokAd);
            this.grpStok.Controls.Add(this.lblStokBarkod);
            this.grpStok.Controls.Add(this.lblStokKod);
            this.grpStok.Controls.Add(this.grpGrup);
            this.grpStok.Controls.Add(this.uscStokEkleSilButon);
            this.grpStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStok.Location = new System.Drawing.Point(3, 3);
            this.grpStok.Name = "grpStok";
            this.grpStok.Size = new System.Drawing.Size(734, 208);
            this.grpStok.TabIndex = 0;
            this.grpStok.TabStop = false;
            this.grpStok.Text = "Stok Bilgileri";
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBirim.Location = new System.Drawing.Point(244, 124);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.Size = new System.Drawing.Size(168, 24);
            this.txtStokBirim.TabIndex = 10;
            // 
            // btnStokBul
            // 
            this.btnStokBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokBul.Image = ((System.Drawing.Image)(resources.GetObject("btnStokBul.Image")));
            this.btnStokBul.Location = new System.Drawing.Point(362, 23);
            this.btnStokBul.Name = "btnStokBul";
            this.btnStokBul.Size = new System.Drawing.Size(50, 26);
            this.btnStokBul.TabIndex = 2;
            this.btnStokBul.UseVisualStyleBackColor = true;
            this.btnStokBul.Click += new System.EventHandler(this.BtnStokBul_Click);
            // 
            // lblStokBirim
            // 
            this.lblStokBirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStokBirim.AutoSize = true;
            this.lblStokBirim.Location = new System.Drawing.Point(196, 127);
            this.lblStokBirim.Name = "lblStokBirim";
            this.lblStokBirim.Size = new System.Drawing.Size(42, 17);
            this.lblStokBirim.TabIndex = 9;
            this.lblStokBirim.Text = "Birimi";
            // 
            // txtStokKDV
            // 
            this.txtStokKDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKDV.Location = new System.Drawing.Point(74, 124);
            this.txtStokKDV.Name = "txtStokKDV";
            this.txtStokKDV.Size = new System.Drawing.Size(116, 24);
            this.txtStokKDV.TabIndex = 8;
            this.txtStokKDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle_KeyPress);
            // 
            // txtStokAd
            // 
            this.txtStokAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokAd.Location = new System.Drawing.Point(74, 91);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(338, 24);
            this.txtStokAd.TabIndex = 6;
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBarkod.Location = new System.Drawing.Point(74, 58);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(338, 24);
            this.txtStokBarkod.TabIndex = 4;
            this.txtStokBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle_KeyPress);
            // 
            // txtStokKod
            // 
            this.txtStokKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKod.Location = new System.Drawing.Point(74, 25);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(282, 24);
            this.txtStokKod.TabIndex = 1;
            this.txtStokKod.Leave += new System.EventHandler(this.TxtStokKod_Leave);
            // 
            // lblStokKDV
            // 
            this.lblStokKDV.AutoSize = true;
            this.lblStokKDV.Location = new System.Drawing.Point(39, 127);
            this.lblStokKDV.Name = "lblStokKDV";
            this.lblStokKDV.Size = new System.Drawing.Size(32, 17);
            this.lblStokKDV.TabIndex = 7;
            this.lblStokKDV.Text = "KDV";
            // 
            // lblStokAd
            // 
            this.lblStokAd.AutoSize = true;
            this.lblStokAd.Location = new System.Drawing.Point(17, 94);
            this.lblStokAd.Name = "lblStokAd";
            this.lblStokAd.Size = new System.Drawing.Size(56, 17);
            this.lblStokAd.TabIndex = 5;
            this.lblStokAd.Text = "Stok Adı";
            // 
            // lblStokBarkod
            // 
            this.lblStokBarkod.AutoSize = true;
            this.lblStokBarkod.Location = new System.Drawing.Point(17, 61);
            this.lblStokBarkod.Name = "lblStokBarkod";
            this.lblStokBarkod.Size = new System.Drawing.Size(52, 17);
            this.lblStokBarkod.TabIndex = 3;
            this.lblStokBarkod.Text = "Barkodu";
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(7, 28);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(63, 17);
            this.lblStokKod.TabIndex = 0;
            this.lblStokKod.Text = "Stok Kodu";
            // 
            // grpGrup
            // 
            this.grpGrup.Controls.Add(this.dgvGrupView);
            this.grpGrup.Controls.Add(this.btnGrupSil);
            this.grpGrup.Controls.Add(this.btnGrupEkle);
            this.grpGrup.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpGrup.Location = new System.Drawing.Point(418, 20);
            this.grpGrup.Name = "grpGrup";
            this.grpGrup.Size = new System.Drawing.Size(313, 133);
            this.grpGrup.TabIndex = 12;
            this.grpGrup.TabStop = false;
            this.grpGrup.Text = "Grup Bilgileri";
            // 
            // dgvGrupView
            // 
            this.dgvGrupView.AllowUserToAddRows = false;
            this.dgvGrupView.AllowUserToDeleteRows = false;
            this.dgvGrupView.AllowUserToResizeRows = false;
            this.dgvGrupView.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrupId,
            this.colGrupAd});
            this.dgvGrupView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGrupView.Location = new System.Drawing.Point(3, 20);
            this.dgvGrupView.MultiSelect = false;
            this.dgvGrupView.Name = "dgvGrupView";
            this.dgvGrupView.ReadOnly = true;
            this.dgvGrupView.RowHeadersVisible = false;
            this.dgvGrupView.RowTemplate.Height = 25;
            this.dgvGrupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupView.Size = new System.Drawing.Size(257, 110);
            this.dgvGrupView.TabIndex = 0;
            this.dgvGrupView.TabStop = false;
            this.dgvGrupView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupView_CellClick);
            this.dgvGrupView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupView_CellDoubleClick);
            // 
            // colGrupId
            // 
            this.colGrupId.DataPropertyName = "Id";
            this.colGrupId.Frozen = true;
            this.colGrupId.HeaderText = "Id";
            this.colGrupId.Name = "colGrupId";
            this.colGrupId.ReadOnly = true;
            this.colGrupId.Visible = false;
            // 
            // colGrupAd
            // 
            this.colGrupAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGrupAd.DataPropertyName = "Ad";
            this.colGrupAd.HeaderText = "Grup Adı";
            this.colGrupAd.Name = "colGrupAd";
            this.colGrupAd.ReadOnly = true;
            // 
            // btnGrupSil
            // 
            this.btnGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupSil.Image")));
            this.btnGrupSil.Location = new System.Drawing.Point(266, 80);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(40, 48);
            this.btnGrupSil.TabIndex = 2;
            this.btnGrupSil.UseVisualStyleBackColor = true;
            this.btnGrupSil.Click += new System.EventHandler(this.BtnGrupSil_Click);
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupEkle.Image")));
            this.btnGrupEkle.Location = new System.Drawing.Point(266, 20);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(40, 51);
            this.btnGrupEkle.TabIndex = 1;
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            this.btnGrupEkle.Click += new System.EventHandler(this.BtnGrupEkle_Click);
            // 
            // uscStokEkleSilButon
            // 
            this.uscStokEkleSilButon.BtnClear_Visible = false;
            this.uscStokEkleSilButon.BtnDelete_Enable = false;
            this.uscStokEkleSilButon.BtnDelete_Text = "Sil     ";
            this.uscStokEkleSilButon.BtnSave_Enable = true;
            this.uscStokEkleSilButon.BtnSave_Text = "Ekle";
            this.uscStokEkleSilButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscStokEkleSilButon.LblStatus_Text = "";
            this.uscStokEkleSilButon.Location = new System.Drawing.Point(3, 153);
            this.uscStokEkleSilButon.Name = "uscStokEkleSilButon";
            this.uscStokEkleSilButon.Size = new System.Drawing.Size(728, 52);
            this.uscStokEkleSilButon.TabIndex = 11;
            this.uscStokEkleSilButon.ClickClear += new System.EventHandler(this.UscStokEkleSilButon_ClickEkraniTemizle);
            this.uscStokEkleSilButon.ClickSave += new System.EventHandler(this.UscStokEkleSilButon_ClickEkleGuncelle);
            this.uscStokEkleSilButon.ClickCancel += new System.EventHandler(this.UscStokEkleSilButon_ClickSecileniSil);
            // 
            // dgvStokListe
            // 
            this.dgvStokListe.AllowUserToAddRows = false;
            this.dgvStokListe.AllowUserToDeleteRows = false;
            this.dgvStokListe.AllowUserToResizeRows = false;
            this.dgvStokListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvStokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colBarkod,
            this.colAd,
            this.colKDV,
            this.colBirim});
            this.dgvStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokListe.Location = new System.Drawing.Point(3, 211);
            this.dgvStokListe.Name = "dgvStokListe";
            this.dgvStokListe.ReadOnly = true;
            this.dgvStokListe.RowHeadersVisible = false;
            this.dgvStokListe.RowTemplate.Height = 25;
            this.dgvStokListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokListe.Size = new System.Drawing.Size(734, 114);
            this.dgvStokListe.TabIndex = 1;
            this.dgvStokListe.TabStop = false;
            this.dgvStokListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStokListe_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
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
            // colBarkod
            // 
            this.colBarkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBarkod.DataPropertyName = "Barkod";
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Width = 71;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            this.colAd.HeaderText = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            // 
            // colKDV
            // 
            this.colKDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKDV.DataPropertyName = "KDV";
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.ReadOnly = true;
            this.colKDV.Width = 57;
            // 
            // colBirim
            // 
            this.colBirim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBirim.DataPropertyName = "Birim";
            this.colBirim.HeaderText = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.ReadOnly = true;
            this.colBirim.Width = 63;
            // 
            // tabFrmStok
            // 
            this.tabFrmStok.Controls.Add(this.tabStokKart);
            this.tabFrmStok.Controls.Add(this.tabStokHareket);
            this.tabFrmStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFrmStok.ImageList = this.imLStokKart;
            this.tabFrmStok.Location = new System.Drawing.Point(0, 0);
            this.tabFrmStok.Name = "tabFrmStok";
            this.tabFrmStok.SelectedIndex = 0;
            this.tabFrmStok.Size = new System.Drawing.Size(748, 358);
            this.tabFrmStok.TabIndex = 0;
            // 
            // tabStokKart
            // 
            this.tabStokKart.Controls.Add(this.dgvStokListe);
            this.tabStokKart.Controls.Add(this.grpStok);
            this.tabStokKart.ImageIndex = 0;
            this.tabStokKart.Location = new System.Drawing.Point(4, 26);
            this.tabStokKart.Name = "tabStokKart";
            this.tabStokKart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStokKart.Size = new System.Drawing.Size(740, 328);
            this.tabStokKart.TabIndex = 0;
            this.tabStokKart.Text = "Kart Bilgileri";
            this.tabStokKart.UseVisualStyleBackColor = true;
            // 
            // tabStokHareket
            // 
            this.tabStokHareket.Controls.Add(this.grpStokHareketler);
            this.tabStokHareket.ImageIndex = 1;
            this.tabStokHareket.Location = new System.Drawing.Point(4, 26);
            this.tabStokHareket.Name = "tabStokHareket";
            this.tabStokHareket.Padding = new System.Windows.Forms.Padding(3);
            this.tabStokHareket.Size = new System.Drawing.Size(740, 328);
            this.tabStokHareket.TabIndex = 1;
            this.tabStokHareket.Text = "Hareket Bilgileri";
            this.tabStokHareket.UseVisualStyleBackColor = true;
            // 
            // grpStokHareketler
            // 
            this.grpStokHareketler.Controls.Add(this.dgvStokHareketler);
            this.grpStokHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStokHareketler.Location = new System.Drawing.Point(3, 3);
            this.grpStokHareketler.Name = "grpStokHareketler";
            this.grpStokHareketler.Size = new System.Drawing.Size(734, 322);
            this.grpStokHareketler.TabIndex = 0;
            this.grpStokHareketler.TabStop = false;
            this.grpStokHareketler.Text = "Stok Hareketler";
            // 
            // dgvStokHareketler
            // 
            this.dgvStokHareketler.AllowUserToAddRows = false;
            this.dgvStokHareketler.AllowUserToDeleteRows = false;
            this.dgvStokHareketler.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokHareketler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStokHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStokHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHareketId,
            this.colStokId,
            this.colFaturaId,
            this.colHareketMiktar,
            this.colHareketBirim,
            this.colHareketFiyat,
            this.colBrutTutar,
            this.dataGridViewTextBoxColumn1,
            this.colNetTutar,
            this.colHareketTarih,
            this.colHareketAciklama});
            this.dgvStokHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokHareketler.Location = new System.Drawing.Point(3, 20);
            this.dgvStokHareketler.Name = "dgvStokHareketler";
            this.dgvStokHareketler.ReadOnly = true;
            this.dgvStokHareketler.RowHeadersVisible = false;
            this.dgvStokHareketler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStokHareketler.RowTemplate.Height = 25;
            this.dgvStokHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokHareketler.Size = new System.Drawing.Size(728, 299);
            this.dgvStokHareketler.TabIndex = 0;
            // 
            // colHareketId
            // 
            this.colHareketId.DataPropertyName = "Id";
            this.colHareketId.HeaderText = "Id";
            this.colHareketId.Name = "colHareketId";
            this.colHareketId.ReadOnly = true;
            this.colHareketId.Visible = false;
            // 
            // colStokId
            // 
            this.colStokId.DataPropertyName = "StokId";
            this.colStokId.HeaderText = "Stok Id";
            this.colStokId.Name = "colStokId";
            this.colStokId.ReadOnly = true;
            this.colStokId.Visible = false;
            // 
            // colFaturaId
            // 
            this.colFaturaId.DataPropertyName = "FaturaId";
            this.colFaturaId.HeaderText = "Fatura Id";
            this.colFaturaId.Name = "colFaturaId";
            this.colFaturaId.ReadOnly = true;
            this.colFaturaId.Visible = false;
            // 
            // colHareketMiktar
            // 
            this.colHareketMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHareketMiktar.DataPropertyName = "Miktar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colHareketMiktar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colHareketMiktar.HeaderText = "Miktar";
            this.colHareketMiktar.Name = "colHareketMiktar";
            this.colHareketMiktar.ReadOnly = true;
            this.colHareketMiktar.Width = 71;
            // 
            // colHareketBirim
            // 
            this.colHareketBirim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHareketBirim.DataPropertyName = "Birim";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = null;
            this.colHareketBirim.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHareketBirim.HeaderText = "Birim";
            this.colHareketBirim.Name = "colHareketBirim";
            this.colHareketBirim.ReadOnly = true;
            this.colHareketBirim.Width = 61;
            // 
            // colHareketFiyat
            // 
            this.colHareketFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHareketFiyat.DataPropertyName = "Fiyat";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,###.## TL";
            dataGridViewCellStyle4.NullValue = null;
            this.colHareketFiyat.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHareketFiyat.HeaderText = "Fiyat";
            this.colHareketFiyat.Name = "colHareketFiyat";
            this.colHareketFiyat.ReadOnly = true;
            this.colHareketFiyat.Width = 62;
            // 
            // colBrutTutar
            // 
            this.colBrutTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBrutTutar.DataPropertyName = "BrutTutar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,###.## TL";
            this.colBrutTutar.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBrutTutar.HeaderText = "Brüt Tutar";
            this.colBrutTutar.Name = "colBrutTutar";
            this.colBrutTutar.ReadOnly = true;
            this.colBrutTutar.Width = 96;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KDV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "KDV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // colNetTutar
            // 
            this.colNetTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNetTutar.DataPropertyName = "NetTutar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,###.## TL";
            this.colNetTutar.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNetTutar.HeaderText = "Net Tutar";
            this.colNetTutar.Name = "colNetTutar";
            this.colNetTutar.ReadOnly = true;
            this.colNetTutar.Width = 93;
            // 
            // colHareketTarih
            // 
            this.colHareketTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHareketTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.colHareketTarih.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHareketTarih.HeaderText = "Tarih";
            this.colHareketTarih.Name = "colHareketTarih";
            this.colHareketTarih.ReadOnly = true;
            this.colHareketTarih.Width = 63;
            // 
            // colHareketAciklama
            // 
            this.colHareketAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHareketAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colHareketAciklama.DefaultCellStyle = dataGridViewCellStyle9;
            this.colHareketAciklama.HeaderText = "Açıklama";
            this.colHareketAciklama.Name = "colHareketAciklama";
            this.colHareketAciklama.ReadOnly = true;
            this.colHareketAciklama.Width = 82;
            // 
            // imLStokKart
            // 
            this.imLStokKart.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imLStokKart.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLStokKart.ImageStream")));
            this.imLStokKart.TransparentColor = System.Drawing.Color.Transparent;
            this.imLStokKart.Images.SetKeyName(0, "Stok_Kartı32x32.ico");
            this.imLStokKart.Images.SetKeyName(1, "Stok_Hareket32x32.ico");
            // 
            // FrmStokKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 358);
            this.Controls.Add(this.tabFrmStok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(764, 700);
            this.MinimumSize = new System.Drawing.Size(764, 397);
            this.Name = "FrmStokKart";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Stok Kartı";
            this.Load += new System.EventHandler(this.FrmStokKart_Load);
            this.grpStok.ResumeLayout(false);
            this.grpStok.PerformLayout();
            this.grpGrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).EndInit();
            this.tabFrmStok.ResumeLayout(false);
            this.tabStokKart.ResumeLayout(false);
            this.tabStokHareket.ResumeLayout(false);
            this.grpStokHareketler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStok;
        private System.Windows.Forms.GroupBox grpGrup;
        private UserControls.UscFormButtons uscStokEkleSilButon;
        private System.Windows.Forms.TextBox txtStokKDV;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.Label lblStokKDV;
        private System.Windows.Forms.Label lblStokAd;
        private System.Windows.Forms.Label lblStokBarkod;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Label lblStokBirim;
        private System.Windows.Forms.Button btnStokBul;
        private System.Windows.Forms.TextBox txtStokBirim;
        private System.Windows.Forms.Button btnGrupSil;
        private System.Windows.Forms.Button btnGrupEkle;
        private System.Windows.Forms.DataGridView dgvStokListe;
        private System.Windows.Forms.DataGridView dgvGrupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
        private System.Windows.Forms.TabControl tabFrmStok;
        private System.Windows.Forms.TabPage tabStokKart;
        private System.Windows.Forms.TabPage tabStokHareket;
        private System.Windows.Forms.GroupBox grpStokHareketler;
        private System.Windows.Forms.DataGridView dgvStokHareketler;
        private System.Windows.Forms.ImageList imLStokKart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrutTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketAciklama;
    }
}
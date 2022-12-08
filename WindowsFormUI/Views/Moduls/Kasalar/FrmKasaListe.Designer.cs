namespace WindowsFormUI.Views.Moduls.Kasalar
{
    partial class FrmKasaListe
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
            this.grpEvrakListe = new System.Windows.Forms.GroupBox();
            this.dtpTarihSon = new System.Windows.Forms.DateTimePicker();
            this.dtpTarihIlk = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtMiktarEnCok = new System.Windows.Forms.TextBox();
            this.lblTarihArasinda = new System.Windows.Forms.Label();
            this.txtMiktarEnAz = new System.Windows.Forms.TextBox();
            this.lblMiktarArasinda = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.lblCariUnvan = new System.Windows.Forms.Label();
            this.dgvEvrakListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEvrakListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvrakListe
            // 
            this.grpEvrakListe.Controls.Add(this.dtpTarihSon);
            this.grpEvrakListe.Controls.Add(this.dtpTarihIlk);
            this.grpEvrakListe.Controls.Add(this.txtAciklama);
            this.grpEvrakListe.Controls.Add(this.lblAciklama);
            this.grpEvrakListe.Controls.Add(this.lblTarih);
            this.grpEvrakListe.Controls.Add(this.txtMiktarEnCok);
            this.grpEvrakListe.Controls.Add(this.lblTarihArasinda);
            this.grpEvrakListe.Controls.Add(this.txtMiktarEnAz);
            this.grpEvrakListe.Controls.Add(this.lblMiktarArasinda);
            this.grpEvrakListe.Controls.Add(this.lblMiktar);
            this.grpEvrakListe.Controls.Add(this.txtEvrakNo);
            this.grpEvrakListe.Controls.Add(this.lblEvrakNo);
            this.grpEvrakListe.Controls.Add(this.txtCariUnvan);
            this.grpEvrakListe.Controls.Add(this.lblCariUnvan);
            this.grpEvrakListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpEvrakListe.Location = new System.Drawing.Point(0, 0);
            this.grpEvrakListe.Name = "grpEvrakListe";
            this.grpEvrakListe.Size = new System.Drawing.Size(229, 257);
            this.grpEvrakListe.TabIndex = 0;
            this.grpEvrakListe.TabStop = false;
            this.grpEvrakListe.Text = "Evrak Bilgileri";
            // 
            // dtpTarihSon
            // 
            this.dtpTarihSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihSon.Location = new System.Drawing.Point(141, 179);
            this.dtpTarihSon.Name = "dtpTarihSon";
            this.dtpTarihSon.Size = new System.Drawing.Size(81, 24);
            this.dtpTarihSon.TabIndex = 11;
            this.dtpTarihSon.ValueChanged += new System.EventHandler(this._TextChanged);
            // 
            // dtpTarihIlk
            // 
            this.dtpTarihIlk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihIlk.Location = new System.Drawing.Point(6, 179);
            this.dtpTarihIlk.Name = "dtpTarihIlk";
            this.dtpTarihIlk.Size = new System.Drawing.Size(81, 24);
            this.dtpTarihIlk.TabIndex = 9;
            this.dtpTarihIlk.ValueChanged += new System.EventHandler(this._TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 226);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(216, 24);
            this.txtAciklama.TabIndex = 13;
            this.txtAciklama.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(6, 206);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 17);
            this.lblAciklama.TabIndex = 12;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(6, 159);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 17);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Text = "Tarih";
            // 
            // txtMiktarEnCok
            // 
            this.txtMiktarEnCok.Location = new System.Drawing.Point(141, 132);
            this.txtMiktarEnCok.Name = "txtMiktarEnCok";
            this.txtMiktarEnCok.Size = new System.Drawing.Size(81, 24);
            this.txtMiktarEnCok.TabIndex = 7;
            this.txtMiktarEnCok.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // lblTarihArasinda
            // 
            this.lblTarihArasinda.AutoSize = true;
            this.lblTarihArasinda.Location = new System.Drawing.Point(87, 185);
            this.lblTarihArasinda.Name = "lblTarihArasinda";
            this.lblTarihArasinda.Size = new System.Drawing.Size(54, 17);
            this.lblTarihArasinda.TabIndex = 10;
            this.lblTarihArasinda.Text = "arasında";
            // 
            // txtMiktarEnAz
            // 
            this.txtMiktarEnAz.Location = new System.Drawing.Point(6, 132);
            this.txtMiktarEnAz.Name = "txtMiktarEnAz";
            this.txtMiktarEnAz.Size = new System.Drawing.Size(81, 24);
            this.txtMiktarEnAz.TabIndex = 5;
            this.txtMiktarEnAz.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // lblMiktarArasinda
            // 
            this.lblMiktarArasinda.AutoSize = true;
            this.lblMiktarArasinda.Location = new System.Drawing.Point(88, 135);
            this.lblMiktarArasinda.Name = "lblMiktarArasinda";
            this.lblMiktarArasinda.Size = new System.Drawing.Size(54, 17);
            this.lblMiktarArasinda.TabIndex = 6;
            this.lblMiktarArasinda.Text = "arasında";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(6, 112);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Miktarı";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(6, 38);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(216, 24);
            this.txtEvrakNo.TabIndex = 1;
            this.txtEvrakNo.TextChanged += new System.EventHandler(this._TextChanged);
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
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(6, 85);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(216, 24);
            this.txtCariUnvan.TabIndex = 3;
            this.txtCariUnvan.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // lblCariUnvan
            // 
            this.lblCariUnvan.AutoSize = true;
            this.lblCariUnvan.Location = new System.Drawing.Point(6, 65);
            this.lblCariUnvan.Name = "lblCariUnvan";
            this.lblCariUnvan.Size = new System.Drawing.Size(72, 17);
            this.lblCariUnvan.TabIndex = 2;
            this.lblCariUnvan.Text = "Cari Unvanı";
            // 
            // dgvEvrakListe
            // 
            this.dgvEvrakListe.AllowUserToAddRows = false;
            this.dgvEvrakListe.AllowUserToDeleteRows = false;
            this.dgvEvrakListe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvrakListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvrakListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvrakListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEvrakNo,
            this.colCariAd,
            this.colMiktar,
            this.colTarih,
            this.colAciklama});
            this.dgvEvrakListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvrakListe.Location = new System.Drawing.Point(229, 0);
            this.dgvEvrakListe.Name = "dgvEvrakListe";
            this.dgvEvrakListe.ReadOnly = true;
            this.dgvEvrakListe.RowHeadersVisible = false;
            this.dgvEvrakListe.RowTemplate.Height = 25;
            this.dgvEvrakListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvrakListe.Size = new System.Drawing.Size(647, 257);
            this.dgvEvrakListe.TabIndex = 1;
            this.dgvEvrakListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEvrakListe_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.DataPropertyName = "EvrakNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colEvrakNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEvrakNo.HeaderText = "Evrak No";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.ReadOnly = true;
            this.colEvrakNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEvrakNo.Width = 120;
            // 
            // colCariAd
            // 
            this.colCariAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCariAd.DataPropertyName = "Unvan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colCariAd.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCariAd.HeaderText = "Cari Unvan";
            this.colCariAd.Name = "colCariAd";
            this.colCariAd.ReadOnly = true;
            this.colCariAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMiktar
            // 
            this.colMiktar.DataPropertyName = "GirenCikanMiktar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "#,###.## TL";
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colTarih.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colAciklama
            // 
            this.colAciklama.DataPropertyName = "Aciklama";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAciklama.HeaderText = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // FrmKasaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 257);
            this.Controls.Add(this.dgvEvrakListe);
            this.Controls.Add(this.grpEvrakListe);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(892, 296);
            this.Name = "FrmKasaListe";
            this.Text = "FrmKasaListe";
            this.Load += new System.EventHandler(this.FrmKasaListe_Load);
            this.grpEvrakListe.ResumeLayout(false);
            this.grpEvrakListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvrakListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEvrakListe;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtMiktarEnAz;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.Label lblCariUnvan;
        private System.Windows.Forms.TextBox txtMiktarEnCok;
        private System.Windows.Forms.Label lblMiktarArasinda;
        private System.Windows.Forms.Label lblTarihArasinda;
        private System.Windows.Forms.DateTimePicker dtpTarihSon;
        private System.Windows.Forms.DateTimePicker dtpTarihIlk;
        private System.Windows.Forms.DataGridView dgvEvrakListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
    }
}
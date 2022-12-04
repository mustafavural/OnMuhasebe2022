
namespace WindowsFormUI.Views.Moduls.Cariler
{
    partial class FrmCariGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariGrup));
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.uscGruplar = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblGrupAd = new System.Windows.Forms.Label();
            this.txtGrupKodAd = new System.Windows.Forms.TextBox();
            this.dgvGruplar = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruplar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblStatusBar);
            this.grpEkleGuncelle.Controls.Add(this.uscGruplar);
            this.grpEkleGuncelle.Controls.Add(this.lblGrupAd);
            this.grpEkleGuncelle.Controls.Add(this.txtGrupKodAd);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(313, 147);
            this.grpEkleGuncelle.TabIndex = 0;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Grup Ekle Güncelle Seç";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(6, 61);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 17);
            this.lblStatusBar.TabIndex = 6;
            // 
            // uscGruplar
            // 
            this.uscGruplar.BtnClear_Visible = true;
            this.uscGruplar.BtnDelete_Enable = true;
            this.uscGruplar.BtnDelete_Text = "Sil     ";
            this.uscGruplar.BtnSave_Enable = true;
            this.uscGruplar.BtnSave_Text = "Kaydet";
            this.uscGruplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscGruplar.LblStatus_Text = "";
            this.uscGruplar.Location = new System.Drawing.Point(3, 83);
            this.uscGruplar.Name = "uscGruplar";
            this.uscGruplar.Size = new System.Drawing.Size(307, 61);
            this.uscGruplar.TabIndex = 4;
            this.uscGruplar.ClickClear += new System.EventHandler(this.UscGruplar_ClickClear);
            this.uscGruplar.ClickSave += new System.EventHandler(this.UscGruplar_GrupEkleGuncelle);
            this.uscGruplar.ClickCancel += new System.EventHandler(this.UscGruplar_GrupSil);
            // 
            // lblGrupAd
            // 
            this.lblGrupAd.AutoSize = true;
            this.lblGrupAd.Location = new System.Drawing.Point(6, 28);
            this.lblGrupAd.Name = "lblGrupAd";
            this.lblGrupAd.Size = new System.Drawing.Size(56, 17);
            this.lblGrupAd.TabIndex = 3;
            this.lblGrupAd.Text = "Grup Adı";
            // 
            // txtGrupKodAd
            // 
            this.txtGrupKodAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupKodAd.Location = new System.Drawing.Point(66, 25);
            this.txtGrupKodAd.Name = "txtGrupKodAd";
            this.txtGrupKodAd.Size = new System.Drawing.Size(244, 24);
            this.txtGrupKodAd.TabIndex = 1;
            this.txtGrupKodAd.TextChanged += new System.EventHandler(this.TxtGrupAd_TextChanged);
            // 
            // dgvGruplar
            // 
            this.dgvGruplar.AllowUserToAddRows = false;
            this.dgvGruplar.AllowUserToDeleteRows = false;
            this.dgvGruplar.AllowUserToResizeRows = false;
            this.dgvGruplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvGruplar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGruplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGruplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAd});
            this.dgvGruplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGruplar.Location = new System.Drawing.Point(0, 147);
            this.dgvGruplar.MultiSelect = false;
            this.dgvGruplar.Name = "dgvGruplar";
            this.dgvGruplar.ReadOnly = true;
            this.dgvGruplar.RowHeadersVisible = false;
            this.dgvGruplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGruplar.Size = new System.Drawing.Size(313, 215);
            this.dgvGruplar.TabIndex = 2;
            this.dgvGruplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGruplar_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            dataGridViewCellStyle1.NullValue = null;
            this.colAd.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAd.HeaderText = "Grup Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmCariGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 362);
            this.Controls.Add(this.dgvGruplar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCariGrup";
            this.ShowInTaskbar = false;
            this.Text = "Cari Grupları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStokGrup_FormClosing);
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkleGuncelle;
        private System.Windows.Forms.Label lblGrupAd;
        private System.Windows.Forms.TextBox txtGrupKodAd;
        private UserControls.UscFormButtons uscGruplar;
        private System.Windows.Forms.DataGridView dgvGruplar;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
    }
}
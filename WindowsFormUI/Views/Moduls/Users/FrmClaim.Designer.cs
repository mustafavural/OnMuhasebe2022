namespace WindowsFormUI.Views.Moduls.Users
{
    partial class FrmClaim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClaim));
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.uscClaims = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblClaimName = new System.Windows.Forms.Label();
            this.txtClaimName = new System.Windows.Forms.TextBox();
            this.dgvClaims = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblStatusBar);
            this.grpEkleGuncelle.Controls.Add(this.uscClaims);
            this.grpEkleGuncelle.Controls.Add(this.lblClaimName);
            this.grpEkleGuncelle.Controls.Add(this.txtClaimName);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(297, 139);
            this.grpEkleGuncelle.TabIndex = 3;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Yetki Ekle Güncelle Seç";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(12, 60);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 16);
            this.lblStatusBar.TabIndex = 5;
            // 
            // uscClaims
            // 
            this.uscClaims.BtnClear_Visible = true;
            this.uscClaims.BtnDelete_Enable = true;
            this.uscClaims.BtnDelete_Text = "Sil     ";
            this.uscClaims.BtnSave_Enable = true;
            this.uscClaims.BtnSave_Text = "Kaydet";
            this.uscClaims.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscClaims.LblStatus_Text = "";
            this.uscClaims.Location = new System.Drawing.Point(3, 83);
            this.uscClaims.Name = "uscClaims";
            this.uscClaims.Size = new System.Drawing.Size(291, 53);
            this.uscClaims.TabIndex = 4;
            this.uscClaims.ClickClear += new System.EventHandler(this.UscClaims_ClickClear);
            this.uscClaims.ClickSave += new System.EventHandler(this.UscClaims_EkleGuncelle);
            this.uscClaims.ClickCancel += new System.EventHandler(this.UscClaims_GrupSil);
            // 
            // lblClaimName
            // 
            this.lblClaimName.AutoSize = true;
            this.lblClaimName.Location = new System.Drawing.Point(6, 30);
            this.lblClaimName.Name = "lblClaimName";
            this.lblClaimName.Size = new System.Drawing.Size(61, 16);
            this.lblClaimName.TabIndex = 3;
            this.lblClaimName.Text = "Yetki Adı";
            // 
            // txtClaimName
            // 
            this.txtClaimName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaimName.Location = new System.Drawing.Point(66, 26);
            this.txtClaimName.Name = "txtClaimName";
            this.txtClaimName.Size = new System.Drawing.Size(219, 24);
            this.txtClaimName.TabIndex = 1;
            this.txtClaimName.TextChanged += new System.EventHandler(this.TxtClaimName_TextChanged);
            // 
            // dgvClaims
            // 
            this.dgvClaims.AllowUserToAddRows = false;
            this.dgvClaims.AllowUserToDeleteRows = false;
            this.dgvClaims.AllowUserToResizeRows = false;
            this.dgvClaims.BackgroundColor = System.Drawing.Color.White;
            this.dgvClaims.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClaims.ColumnHeadersVisible = false;
            this.dgvClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName});
            this.dgvClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClaims.Location = new System.Drawing.Point(0, 139);
            this.dgvClaims.MultiSelect = false;
            this.dgvClaims.Name = "dgvClaims";
            this.dgvClaims.ReadOnly = true;
            this.dgvClaims.RowHeadersVisible = false;
            this.dgvClaims.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClaims.Size = new System.Drawing.Size(297, 227);
            this.dgvClaims.TabIndex = 4;
            this.dgvClaims.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClaims_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Grup Adı";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 366);
            this.Controls.Add(this.dgvClaims);
            this.Controls.Add(this.grpEkleGuncelle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(313, 800);
            this.MinimumSize = new System.Drawing.Size(313, 405);
            this.Name = "FrmClaim";
            this.Text = "Yetkiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClaim_FormClosing);
            this.Load += new System.EventHandler(this.FrmClaim_Load);
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkleGuncelle;
        private System.Windows.Forms.Label lblStatusBar;
        private UserControls.UscFormButtons uscClaims;
        private System.Windows.Forms.Label lblClaimName;
        private System.Windows.Forms.TextBox txtClaimName;
        private System.Windows.Forms.DataGridView dgvClaims;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}
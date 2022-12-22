namespace WindowsFormUI.Views.Moduls.Users
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.grpClaims = new System.Windows.Forms.GroupBox();
            this.dgvClaims = new System.Windows.Forms.DataGridView();
            this.colClaimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteClaim = new System.Windows.Forms.Button();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.uscAddDeleteUser = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrupSil = new System.Windows.Forms.Button();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.grpUser.SuspendLayout();
            this.grpClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grpClaims);
            this.grpUser.Controls.Add(this.txtPasswordAgain);
            this.grpUser.Controls.Add(this.txtPassword);
            this.grpUser.Controls.Add(this.txtUserEmail);
            this.grpUser.Controls.Add(this.txtUserLastName);
            this.grpUser.Controls.Add(this.lblPasswordAgain);
            this.grpUser.Controls.Add(this.txtUserFirstName);
            this.grpUser.Controls.Add(this.lblPassword);
            this.grpUser.Controls.Add(this.lblUserEmail);
            this.grpUser.Controls.Add(this.lblUserLastName);
            this.grpUser.Controls.Add(this.lblUserName);
            this.grpUser.Controls.Add(this.uscAddDeleteUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(362, 383);
            this.grpUser.TabIndex = 0;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Kullanıcı Bilgileri";
            // 
            // grpClaims
            // 
            this.grpClaims.Controls.Add(this.dgvClaims);
            this.grpClaims.Controls.Add(this.btnDeleteClaim);
            this.grpClaims.Controls.Add(this.btnAddClaim);
            this.grpClaims.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpClaims.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpClaims.Location = new System.Drawing.Point(3, 173);
            this.grpClaims.Name = "grpClaims";
            this.grpClaims.Size = new System.Drawing.Size(356, 149);
            this.grpClaims.TabIndex = 10;
            this.grpClaims.TabStop = false;
            this.grpClaims.Text = "Yetki Bilgileri";
            // 
            // dgvClaims
            // 
            this.dgvClaims.AllowUserToAddRows = false;
            this.dgvClaims.AllowUserToDeleteRows = false;
            this.dgvClaims.AllowUserToResizeRows = false;
            this.dgvClaims.BackgroundColor = System.Drawing.Color.White;
            this.dgvClaims.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClaims.ColumnHeadersVisible = false;
            this.dgvClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClaimId,
            this.colClaimName});
            this.dgvClaims.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvClaims.Location = new System.Drawing.Point(3, 20);
            this.dgvClaims.MultiSelect = false;
            this.dgvClaims.Name = "dgvClaims";
            this.dgvClaims.ReadOnly = true;
            this.dgvClaims.RowHeadersVisible = false;
            this.dgvClaims.RowTemplate.Height = 25;
            this.dgvClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClaims.Size = new System.Drawing.Size(298, 126);
            this.dgvClaims.TabIndex = 2;
            this.dgvClaims.TabStop = false;
            this.dgvClaims.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClaims_CellDoubleClick);
            this.dgvClaims.Click += new System.EventHandler(this.DgvClaims_Click);
            // 
            // colClaimId
            // 
            this.colClaimId.DataPropertyName = "Id";
            this.colClaimId.Frozen = true;
            this.colClaimId.HeaderText = "Id";
            this.colClaimId.Name = "colClaimId";
            this.colClaimId.ReadOnly = true;
            this.colClaimId.Visible = false;
            // 
            // colClaimName
            // 
            this.colClaimName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClaimName.DataPropertyName = "Name";
            this.colClaimName.HeaderText = "Yetki Adı";
            this.colClaimName.Name = "colClaimName";
            this.colClaimName.ReadOnly = true;
            // 
            // btnDeleteClaim
            // 
            this.btnDeleteClaim.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClaim.Image")));
            this.btnDeleteClaim.Location = new System.Drawing.Point(307, 98);
            this.btnDeleteClaim.Name = "btnDeleteClaim";
            this.btnDeleteClaim.Size = new System.Drawing.Size(40, 51);
            this.btnDeleteClaim.TabIndex = 1;
            this.btnDeleteClaim.TabStop = false;
            this.btnDeleteClaim.UseVisualStyleBackColor = true;
            this.btnDeleteClaim.Click += new System.EventHandler(this.BtnDeleteClaim_Click);
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.FlatAppearance.BorderSize = 0;
            this.btnAddClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClaim.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClaim.Image")));
            this.btnAddClaim.Location = new System.Drawing.Point(307, 18);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(40, 55);
            this.btnAddClaim.TabIndex = 0;
            this.btnAddClaim.TabStop = false;
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Click += new System.EventHandler(this.BtnAddClaim_Click);
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPasswordAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAgain.Location = new System.Drawing.Point(113, 143);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.PasswordChar = '*';
            this.txtPasswordAgain.Size = new System.Drawing.Size(218, 24);
            this.txtPasswordAgain.TabIndex = 9;
            this.txtPasswordAgain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(113, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(218, 24);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserEmail.Location = new System.Drawing.Point(113, 23);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(218, 24);
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserLastName.Location = new System.Drawing.Point(113, 83);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(218, 24);
            this.txtUserLastName.TabIndex = 5;
            this.txtUserLastName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordAgain.Location = new System.Drawing.Point(25, 145);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(82, 16);
            this.lblPasswordAgain.TabIndex = 8;
            this.lblPasswordAgain.Text = "Şifre Tekrar";
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserFirstName.Location = new System.Drawing.Point(113, 53);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(218, 24);
            this.txtUserFirstName.TabIndex = 3;
            this.txtUserFirstName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LeaveOnlyWithTabKey);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(25, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Şifre";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserEmail.Location = new System.Drawing.Point(25, 25);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(37, 16);
            this.lblUserEmail.TabIndex = 0;
            this.lblUserEmail.Text = "Email";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserLastName.Location = new System.Drawing.Point(25, 85);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(45, 16);
            this.lblUserLastName.TabIndex = 4;
            this.lblUserLastName.Text = "Soyadı";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(25, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(26, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Adı";
            // 
            // uscAddDeleteUser
            // 
            this.uscAddDeleteUser.BtnClear_Visible = false;
            this.uscAddDeleteUser.BtnDelete_Enable = false;
            this.uscAddDeleteUser.BtnDelete_Text = "Sil     ";
            this.uscAddDeleteUser.BtnSave_Enable = true;
            this.uscAddDeleteUser.BtnSave_Text = "Ekle   ";
            this.uscAddDeleteUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscAddDeleteUser.LblStatus_Text = "";
            this.uscAddDeleteUser.Location = new System.Drawing.Point(3, 322);
            this.uscAddDeleteUser.Name = "uscAddDeleteUser";
            this.uscAddDeleteUser.Size = new System.Drawing.Size(356, 58);
            this.uscAddDeleteUser.TabIndex = 11;
            this.uscAddDeleteUser.TabStop = false;
            this.uscAddDeleteUser.ClickClear += new System.EventHandler(this.UscAddDeleteUser_ClickClear);
            this.uscAddDeleteUser.ClickSave += new System.EventHandler(this.UscAddDeleteUser_ClickSave);
            this.uscAddDeleteUser.ClickCancel += new System.EventHandler(this.UscAddDeleteUser_ClickCancel);
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
            this.btnGrupSil.Location = new System.Drawing.Point(190, 85);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(40, 306);
            this.btnGrupSil.TabIndex = 1;
            this.btnGrupSil.UseVisualStyleBackColor = true;
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupEkle.Image")));
            this.btnGrupEkle.Location = new System.Drawing.Point(190, 24);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(40, 306);
            this.btnGrupEkle.TabIndex = 0;
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 383);
            this.Controls.Add(this.grpUser);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.Text = "Kullanıcı Ayarları";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
        private System.Windows.Forms.Button btnGrupSil;
        private System.Windows.Forms.Button btnGrupEkle;
        private UserControls.UscFormButtons uscAddDeleteUser;
        private System.Windows.Forms.GroupBox grpClaims;
        private System.Windows.Forms.DataGridView dgvClaims;
        private System.Windows.Forms.Button btnDeleteClaim;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimName;
    }
}
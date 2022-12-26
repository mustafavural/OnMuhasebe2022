namespace WindowsFormUI.Views.Moduls.Companies
{
    partial class FrmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscAddDeleteCompany = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.lblCompanyYear = new System.Windows.Forms.Label();
            this.lblCompanyDetail = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyYear = new System.Windows.Forms.TextBox();
            this.txtCompanyDetail = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // colGrupAd
            // 
            this.colGrupAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGrupAd.DataPropertyName = "Ad";
            this.colGrupAd.HeaderText = "Grup Adı";
            this.colGrupAd.Name = "colGrupAd";
            this.colGrupAd.ReadOnly = true;
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
            // uscAddDeleteCompany
            // 
            this.uscAddDeleteCompany.BtnClear_Visible = true;
            this.uscAddDeleteCompany.BtnDelete_Enable = true;
            this.uscAddDeleteCompany.BtnDelete_Text = "Çıkış  ";
            this.uscAddDeleteCompany.BtnSave_Enable = true;
            this.uscAddDeleteCompany.BtnSave_Text = "Ekle  ";
            this.uscAddDeleteCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscAddDeleteCompany.LblStatus_Text = "";
            this.uscAddDeleteCompany.Location = new System.Drawing.Point(3, 229);
            this.uscAddDeleteCompany.Name = "uscAddDeleteCompany";
            this.uscAddDeleteCompany.Size = new System.Drawing.Size(450, 54);
            this.uscAddDeleteCompany.TabIndex = 7;
            this.uscAddDeleteCompany.TabStop = false;
            this.uscAddDeleteCompany.ClickClear += new System.EventHandler(this.UscAddDeleteCompany_ClickClear);
            this.uscAddDeleteCompany.ClickSave += new System.EventHandler(this.UscAddDeleteCompany_ClickSave);
            this.uscAddDeleteCompany.ClickCancel += new System.EventHandler(this.UscAddDeleteCompany_ClickCancel);
            // 
            // lblCompanyYear
            // 
            this.lblCompanyYear.AutoSize = true;
            this.lblCompanyYear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyYear.Location = new System.Drawing.Point(310, 25);
            this.lblCompanyYear.Name = "lblCompanyYear";
            this.lblCompanyYear.Size = new System.Drawing.Size(65, 16);
            this.lblCompanyYear.TabIndex = 2;
            this.lblCompanyYear.Text = "Şirket Yılı";
            // 
            // lblCompanyDetail
            // 
            this.lblCompanyDetail.AutoSize = true;
            this.lblCompanyDetail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyDetail.Location = new System.Drawing.Point(13, 55);
            this.lblCompanyDetail.Name = "lblCompanyDetail";
            this.lblCompanyDetail.Size = new System.Drawing.Size(57, 16);
            this.lblCompanyDetail.TabIndex = 4;
            this.lblCompanyDetail.Text = "Açıklama";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.Location = new System.Drawing.Point(13, 25);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(67, 16);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Şirket Adı";
            // 
            // txtCompanyYear
            // 
            this.txtCompanyYear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompanyYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyYear.Location = new System.Drawing.Point(381, 23);
            this.txtCompanyYear.Name = "txtCompanyYear";
            this.txtCompanyYear.Size = new System.Drawing.Size(70, 24);
            this.txtCompanyYear.TabIndex = 3;
            // 
            // txtCompanyDetail
            // 
            this.txtCompanyDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompanyDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyDetail.Location = new System.Drawing.Point(86, 53);
            this.txtCompanyDetail.Name = "txtCompanyDetail";
            this.txtCompanyDetail.Size = new System.Drawing.Size(365, 24);
            this.txtCompanyDetail.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Location = new System.Drawing.Point(86, 23);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(218, 24);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.Leave += new System.EventHandler(this.TxtCompanyName_Leave);
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.dgvUsers);
            this.grpUsers.Controls.Add(this.btnDeleteUser);
            this.grpUsers.Controls.Add(this.btnAddUser);
            this.grpUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUsers.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpUsers.Location = new System.Drawing.Point(3, 80);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(450, 149);
            this.grpUsers.TabIndex = 6;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Kullanıcı Bilgileri";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyId,
            this.colFirstName,
            this.colLastName,
            this.colEmail});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvUsers.Location = new System.Drawing.Point(3, 20);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(395, 126);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.TabStop = false;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellClick);
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellDoubleClick);
            // 
            // colCompanyId
            // 
            this.colCompanyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCompanyId.DataPropertyName = "Id";
            this.colCompanyId.HeaderText = "Id";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.ReadOnly = true;
            this.colCompanyId.Visible = false;
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Adı";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 51;
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Soyadı";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 70;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-Mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 71;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.Location = new System.Drawing.Point(404, 92);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(40, 51);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.TabStop = false;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUserFromCompany_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(404, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(40, 55);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUserToCompany_Click);
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grpUsers);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.txtCompanyDetail);
            this.grpCompany.Controls.Add(this.txtCompanyYear);
            this.grpCompany.Controls.Add(this.lblCompanyName);
            this.grpCompany.Controls.Add(this.lblCompanyDetail);
            this.grpCompany.Controls.Add(this.lblCompanyYear);
            this.grpCompany.Controls.Add(this.uscAddDeleteCompany);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(456, 286);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Şirket Bilgileri";
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 286);
            this.Controls.Add(this.grpCompany);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompany";
            this.Text = "Şirket Ayarları";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            this.grpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private UserControls.UscFormButtons uscAddDeleteCompany;
        private System.Windows.Forms.Label lblCompanyYear;
        private System.Windows.Forms.Label lblCompanyDetail;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyYear;
        private System.Windows.Forms.TextBox txtCompanyDetail;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}
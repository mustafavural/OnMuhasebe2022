namespace WindowsFormUI.Views.Moduls.Companies
{
    partial class FrmCompanyTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyTransfer));
            this.cmbCompanyList = new System.Windows.Forms.ComboBox();
            this.lblCompanyList = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNewYear = new System.Windows.Forms.TextBox();
            this.txtNewDetail = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewYear = new System.Windows.Forms.Label();
            this.lblNewDetail = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpTargetCompanyInfos = new System.Windows.Forms.GroupBox();
            this.uscTansfer = new WindowsFormUI.Views.UserControls.UscFormButtons();
            this.grpTargetCompanyInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCompanyList
            // 
            this.cmbCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyList.FormattingEnabled = true;
            this.cmbCompanyList.Location = new System.Drawing.Point(12, 31);
            this.cmbCompanyList.Name = "cmbCompanyList";
            this.cmbCompanyList.Size = new System.Drawing.Size(162, 25);
            this.cmbCompanyList.TabIndex = 1;
            this.cmbCompanyList.SelectedIndexChanged += new System.EventHandler(this.CmbCompanyList_SelectedIndexChanged);
            this.cmbCompanyList.Leave += new System.EventHandler(this.CmbCompanyList_Leave);
            // 
            // lblCompanyList
            // 
            this.lblCompanyList.AutoSize = true;
            this.lblCompanyList.Location = new System.Drawing.Point(12, 10);
            this.lblCompanyList.Name = "lblCompanyList";
            this.lblCompanyList.Size = new System.Drawing.Size(85, 17);
            this.lblCompanyList.TabIndex = 0;
            this.lblCompanyList.Text = "Kaynak Şirket";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(6, 41);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(140, 24);
            this.txtNewName.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(180, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(28, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = ">>>>>";
            // 
            // txtNewYear
            // 
            this.txtNewYear.Location = new System.Drawing.Point(152, 41);
            this.txtNewYear.Name = "txtNewYear";
            this.txtNewYear.Size = new System.Drawing.Size(140, 24);
            this.txtNewYear.TabIndex = 8;
            // 
            // txtNewDetail
            // 
            this.txtNewDetail.Location = new System.Drawing.Point(298, 41);
            this.txtNewDetail.Name = "txtNewDetail";
            this.txtNewDetail.Size = new System.Drawing.Size(266, 24);
            this.txtNewDetail.TabIndex = 10;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(6, 20);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(94, 17);
            this.lblNewName.TabIndex = 5;
            this.lblNewName.Text = "Yeni Şirket Adı";
            // 
            // lblNewYear
            // 
            this.lblNewYear.AutoSize = true;
            this.lblNewYear.Location = new System.Drawing.Point(152, 20);
            this.lblNewYear.Name = "lblNewYear";
            this.lblNewYear.Size = new System.Drawing.Size(96, 17);
            this.lblNewYear.TabIndex = 7;
            this.lblNewYear.Text = "Yeni Şirket Yılı";
            // 
            // lblNewDetail
            // 
            this.lblNewDetail.AutoSize = true;
            this.lblNewDetail.Location = new System.Drawing.Point(298, 20);
            this.lblNewDetail.Name = "lblNewDetail";
            this.lblNewDetail.Size = new System.Drawing.Size(134, 17);
            this.lblNewDetail.TabIndex = 9;
            this.lblNewDetail.Text = "Yeni Şirket Açıklaması";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 73);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(286, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // grpTargetCompanyInfos
            // 
            this.grpTargetCompanyInfos.Controls.Add(this.lblNewName);
            this.grpTargetCompanyInfos.Controls.Add(this.lblNewYear);
            this.grpTargetCompanyInfos.Controls.Add(this.btnEdit);
            this.grpTargetCompanyInfos.Controls.Add(this.lblNewDetail);
            this.grpTargetCompanyInfos.Controls.Add(this.txtNewDetail);
            this.grpTargetCompanyInfos.Controls.Add(this.txtNewName);
            this.grpTargetCompanyInfos.Controls.Add(this.txtNewYear);
            this.grpTargetCompanyInfos.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpTargetCompanyInfos.Location = new System.Drawing.Point(214, 0);
            this.grpTargetCompanyInfos.Name = "grpTargetCompanyInfos";
            this.grpTargetCompanyInfos.Size = new System.Drawing.Size(582, 117);
            this.grpTargetCompanyInfos.TabIndex = 11;
            this.grpTargetCompanyInfos.TabStop = false;
            this.grpTargetCompanyInfos.Text = "Hedef Şirket Bilgileri";
            // 
            // uscTansfer
            // 
            this.uscTansfer.BtnClear_Visible = false;
            this.uscTansfer.BtnDelete_Enable = true;
            this.uscTansfer.BtnDelete_Text = "Vazgeç";
            this.uscTansfer.BtnSave_Enable = true;
            this.uscTansfer.BtnSave_Text = "Devret";
            this.uscTansfer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscTansfer.LblStatus_Text = "";
            this.uscTansfer.Location = new System.Drawing.Point(0, 117);
            this.uscTansfer.Name = "uscTansfer";
            this.uscTansfer.Size = new System.Drawing.Size(796, 52);
            this.uscTansfer.TabIndex = 12;
            this.uscTansfer.ClickSave += new System.EventHandler(this.UscTransfer_Devret);
            this.uscTansfer.ClickCancel += new System.EventHandler(this.UscTansfer_Vazgec);
            // 
            // FrmCompanyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 169);
            this.Controls.Add(this.grpTargetCompanyInfos);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblCompanyList);
            this.Controls.Add(this.cmbCompanyList);
            this.Controls.Add(this.uscTansfer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(812, 539);
            this.Name = "FrmCompanyTransfer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Devir İşlemleri";
            this.Load += new System.EventHandler(this.FrmCompanyTransfer_Load);
            this.grpTargetCompanyInfos.ResumeLayout(false);
            this.grpTargetCompanyInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCompanyList;
        private System.Windows.Forms.Label lblCompanyList;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNewYear;
        private System.Windows.Forms.TextBox txtNewDetail;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewYear;
        private System.Windows.Forms.Label lblNewDetail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpTargetCompanyInfos;
        private UserControls.UscFormButtons uscTansfer;
    }
}
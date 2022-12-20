namespace WindowsFormUI.Views
{
    partial class FrmLogin
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
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.cmbSirketAd = new System.Windows.Forms.ComboBox();
            this.btnVazgec = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblSirketAd = new System.Windows.Forms.Label();
            this.btnGiris = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.SuspendLayout();
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciSifre.Location = new System.Drawing.Point(10, 39);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(37, 16);
            this.lblKullaniciSifre.TabIndex = 0;
            this.lblKullaniciSifre.Text = "Şifre";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(93, 36);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(194, 24);
            this.txtKullaniciSifre.TabIndex = 1;
            // 
            // cmbSirketAd
            // 
            this.cmbSirketAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketAd.Enabled = false;
            this.cmbSirketAd.FormattingEnabled = true;
            this.cmbSirketAd.Location = new System.Drawing.Point(93, 66);
            this.cmbSirketAd.Name = "cmbSirketAd";
            this.cmbSirketAd.Size = new System.Drawing.Size(194, 25);
            this.cmbSirketAd.TabIndex = 2;
            this.cmbSirketAd.SelectedIndexChanged += new System.EventHandler(this.CmbSirketAd_SelectedIndexChanged);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Crimson;
            this.btnVazgec.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVazgec.FlatAppearance.BorderSize = 5;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVazgec.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.ForeColor = System.Drawing.Color.Black;
            this.btnVazgec.Location = new System.Drawing.Point(151, 97);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(138, 40);
            this.btnVazgec.TabIndex = 0;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAd.Location = new System.Drawing.Point(10, 9);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(75, 16);
            this.lblKullaniciAd.TabIndex = 0;
            this.lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(93, 6);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(194, 24);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // lblSirketAd
            // 
            this.lblSirketAd.AutoSize = true;
            this.lblSirketAd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSirketAd.Location = new System.Drawing.Point(10, 69);
            this.lblSirketAd.Name = "lblSirketAd";
            this.lblSirketAd.Size = new System.Drawing.Size(67, 16);
            this.lblSirketAd.TabIndex = 0;
            this.lblSirketAd.Text = "Şirket Adı";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.BorderSize = 5;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiris.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(12, 97);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(138, 40);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgec;
            this.ClientSize = new System.Drawing.Size(299, 145);
            this.ControlBox = false;
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.cmbSirketAd);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.lblSirketAd);
            this.Controls.Add(this.lblKullaniciAd);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.lblKullaniciSifre);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.ComboBox cmbSirketAd;
        private UserControls.BtnWelcome btnVazgec;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label lblSirketAd;
        private UserControls.BtnWelcome btnGiris;
    }
}
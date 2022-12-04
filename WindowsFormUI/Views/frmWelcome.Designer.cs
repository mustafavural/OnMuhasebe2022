namespace WindowsFormUI.Views
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.btnWelcomeStok = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnWelcomeCari = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnWelcomeFatura = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnWelcomeKasa = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnWelcomeCek = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnWelcomeBanka = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnExit = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.btnMinimize = new WindowsFormUI.Views.UserControls.BtnWelcome();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWelcomeStok
            // 
            this.btnWelcomeStok.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeStok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeStok.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeStok.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeStok.Image = global::WindowsFormUI.Properties.Resources.Stok32x32;
            this.btnWelcomeStok.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeStok.Location = new System.Drawing.Point(12, 63);
            this.btnWelcomeStok.Name = "btnWelcomeStok";
            this.btnWelcomeStok.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeStok.TabIndex = 0;
            this.btnWelcomeStok.Text = "Stok";
            this.btnWelcomeStok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeStok.UseVisualStyleBackColor = false;
            this.btnWelcomeStok.Click += new System.EventHandler(this.BtnWelcomeStok_Click);
            // 
            // btnWelcomeCari
            // 
            this.btnWelcomeCari.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeCari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeCari.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeCari.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeCari.Image = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.btnWelcomeCari.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeCari.Location = new System.Drawing.Point(140, 63);
            this.btnWelcomeCari.Name = "btnWelcomeCari";
            this.btnWelcomeCari.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeCari.TabIndex = 1;
            this.btnWelcomeCari.Text = "Cari";
            this.btnWelcomeCari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeCari.UseVisualStyleBackColor = false;
            this.btnWelcomeCari.Click += new System.EventHandler(this.BtnWelcomeCari_Click);
            // 
            // btnWelcomeFatura
            // 
            this.btnWelcomeFatura.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeFatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeFatura.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeFatura.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeFatura.Image = global::WindowsFormUI.Properties.Resources.Fatura32x32;
            this.btnWelcomeFatura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeFatura.Location = new System.Drawing.Point(12, 133);
            this.btnWelcomeFatura.Name = "btnWelcomeFatura";
            this.btnWelcomeFatura.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeFatura.TabIndex = 2;
            this.btnWelcomeFatura.Text = "Fatura";
            this.btnWelcomeFatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeFatura.UseVisualStyleBackColor = false;
            this.btnWelcomeFatura.Click += new System.EventHandler(this.BtnWelcomeFatura_Click);
            // 
            // btnWelcomeKasa
            // 
            this.btnWelcomeKasa.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeKasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeKasa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeKasa.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeKasa.Image = global::WindowsFormUI.Properties.Resources.Kasa32x32;
            this.btnWelcomeKasa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeKasa.Location = new System.Drawing.Point(140, 133);
            this.btnWelcomeKasa.Name = "btnWelcomeKasa";
            this.btnWelcomeKasa.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeKasa.TabIndex = 4;
            this.btnWelcomeKasa.Text = "Kasa";
            this.btnWelcomeKasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeKasa.UseVisualStyleBackColor = false;
            this.btnWelcomeKasa.Click += new System.EventHandler(this.BtnWelcomeKasa_Click);
            // 
            // btnWelcomeCek
            // 
            this.btnWelcomeCek.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeCek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeCek.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeCek.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeCek.Image = global::WindowsFormUI.Properties.Resources.Cek32x32;
            this.btnWelcomeCek.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeCek.Location = new System.Drawing.Point(12, 203);
            this.btnWelcomeCek.Name = "btnWelcomeCek";
            this.btnWelcomeCek.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeCek.TabIndex = 5;
            this.btnWelcomeCek.Text = "Çek";
            this.btnWelcomeCek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeCek.UseVisualStyleBackColor = false;
            this.btnWelcomeCek.Click += new System.EventHandler(this.BtnWelcomeCek_Click);
            // 
            // btnWelcomeBanka
            // 
            this.btnWelcomeBanka.BackColor = System.Drawing.Color.Cyan;
            this.btnWelcomeBanka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWelcomeBanka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeBanka.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWelcomeBanka.ForeColor = System.Drawing.Color.Black;
            this.btnWelcomeBanka.Image = global::WindowsFormUI.Properties.Resources.Banka32x32;
            this.btnWelcomeBanka.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWelcomeBanka.Location = new System.Drawing.Point(140, 203);
            this.btnWelcomeBanka.Name = "btnWelcomeBanka";
            this.btnWelcomeBanka.Size = new System.Drawing.Size(122, 64);
            this.btnWelcomeBanka.TabIndex = 6;
            this.btnWelcomeBanka.Text = "Banka";
            this.btnWelcomeBanka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcomeBanka.UseVisualStyleBackColor = false;
            this.btnWelcomeBanka.Click += new System.EventHandler(this.BtnWelcomeBanka_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::WindowsFormUI.Properties.Resources.Sil24x24;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(234, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(195, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 35);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ön Muhasebe 2022";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(279, 367);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWelcomeBanka);
            this.Controls.Add(this.btnWelcomeCek);
            this.Controls.Add(this.btnWelcomeKasa);
            this.Controls.Add(this.btnWelcomeFatura);
            this.Controls.Add(this.btnWelcomeCari);
            this.Controls.Add(this.btnWelcomeStok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.BtnWelcome btnWelcomeStok;
        private UserControls.BtnWelcome btnWelcomeCari;
        private UserControls.BtnWelcome btnWelcomeFatura;
        private UserControls.BtnWelcome btnWelcomeKasa;
        private UserControls.BtnWelcome btnWelcomeCek;
        private UserControls.BtnWelcome btnWelcomeBanka;
        private UserControls.BtnWelcome btnExit;
        private UserControls.BtnWelcome btnMinimize;
        private System.Windows.Forms.Label label1;
    }
}
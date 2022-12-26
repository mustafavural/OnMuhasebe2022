namespace WindowsFormUI.Views.Moduls.Companies
{
    partial class FrmCompanyMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyMdi));
            this.msFaturaMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompanyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msFaturaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFaturaMenu
            // 
            this.msFaturaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompany,
            this.tsmiKayit});
            this.msFaturaMenu.Location = new System.Drawing.Point(0, 0);
            this.msFaturaMenu.Name = "msFaturaMenu";
            this.msFaturaMenu.Size = new System.Drawing.Size(800, 24);
            this.msFaturaMenu.TabIndex = 1;
            this.msFaturaMenu.Text = "menuStrip1";
            // 
            // tsmiCompany
            // 
            this.tsmiCompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompanyExit});
            this.tsmiCompany.Image = global::WindowsFormUI.Properties.Resources.Banka32x32;
            this.tsmiCompany.Name = "tsmiCompany";
            this.tsmiCompany.Size = new System.Drawing.Size(64, 20);
            this.tsmiCompany.Text = "Şirket";
            // 
            // tsmiCompanyExit
            // 
            this.tsmiCompanyExit.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiCompanyExit.Name = "tsmiCompanyExit";
            this.tsmiCompanyExit.Size = new System.Drawing.Size(99, 22);
            this.tsmiCompanyExit.Text = "Çıkış";
            this.tsmiCompanyExit.Click += new System.EventHandler(this.TsmiCompanyExit_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitCompany,
            this.tsmiKayitTransfer,
            this.tsmiKayitSeperator2});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitCompany
            // 
            this.tsmiKayitCompany.Image = global::WindowsFormUI.Properties.Resources.Fatura_Alis32x32;
            this.tsmiKayitCompany.Name = "tsmiKayitCompany";
            this.tsmiKayitCompany.Size = new System.Drawing.Size(194, 22);
            this.tsmiKayitCompany.Tag = "";
            this.tsmiKayitCompany.Text = "Şirket Ayarları";
            this.tsmiKayitCompany.Click += new System.EventHandler(this.TsmiKayitCompany_Click);
            // 
            // tsmiKayitTransfer
            // 
            this.tsmiKayitTransfer.Image = global::WindowsFormUI.Properties.Resources.Fatura_Satis32x32;
            this.tsmiKayitTransfer.Name = "tsmiKayitTransfer";
            this.tsmiKayitTransfer.Size = new System.Drawing.Size(194, 22);
            this.tsmiKayitTransfer.Tag = "2";
            this.tsmiKayitTransfer.Text = "Yıl Sonu Devir İşlemleri";
            this.tsmiKayitTransfer.Click += new System.EventHandler(this.TsmiKayitTransfer_Click);
            // 
            // tsmiKayitSeperator2
            // 
            this.tsmiKayitSeperator2.Name = "tsmiKayitSeperator2";
            this.tsmiKayitSeperator2.Size = new System.Drawing.Size(191, 6);
            // 
            // FrmCompanyMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msFaturaMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msFaturaMenu;
            this.Name = "FrmCompanyMdi";
            this.Text = "Şirket Ayarlar Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msFaturaMenu.ResumeLayout(false);
            this.msFaturaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFaturaMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompany;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompanyExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCompany;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitTransfer;
        private System.Windows.Forms.ToolStripSeparator tsmiKayitSeperator2;
    }
}
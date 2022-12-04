namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    partial class FrmDegerliEvrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDegerliEvrak));
            this.msDegerliEvraklarMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiDegerliEvrak = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDegerliEvrakCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitMusteridenEvrakAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitMusteriyeEvrakCik = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKayitPortfoydekiEvraklar = new System.Windows.Forms.ToolStripMenuItem();
            this.msDegerliEvraklarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msDegerliEvraklarMenu
            // 
            this.msDegerliEvraklarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDegerliEvrak,
            this.tsmiKayit});
            this.msDegerliEvraklarMenu.Location = new System.Drawing.Point(0, 0);
            this.msDegerliEvraklarMenu.Name = "msDegerliEvraklarMenu";
            this.msDegerliEvraklarMenu.Size = new System.Drawing.Size(800, 24);
            this.msDegerliEvraklarMenu.TabIndex = 1;
            this.msDegerliEvraklarMenu.Text = "menuStrip1";
            // 
            // tsmiDegerliEvrak
            // 
            this.tsmiDegerliEvrak.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDegerliEvrakCikis});
            this.tsmiDegerliEvrak.Image = global::WindowsFormUI.Properties.Resources.Cek32x32;
            this.tsmiDegerliEvrak.Name = "tsmiDegerliEvrak";
            this.tsmiDegerliEvrak.Size = new System.Drawing.Size(103, 20);
            this.tsmiDegerliEvrak.Text = "Değerli Evrak";
            // 
            // tsmiDegerliEvrakCikis
            // 
            this.tsmiDegerliEvrakCikis.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiDegerliEvrakCikis.Name = "tsmiDegerliEvrakCikis";
            this.tsmiDegerliEvrakCikis.Size = new System.Drawing.Size(99, 22);
            this.tsmiDegerliEvrakCikis.Text = "Çıkış";
            this.tsmiDegerliEvrakCikis.Click += new System.EventHandler(this.TsmiDegerliEvrakCikis_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitMusteridenEvrakAl,
            this.tsmiKayitMusteriyeEvrakCik,
            this.tsmiSeperator,
            this.tsmiKayitPortfoydekiEvraklar});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitMusteridenEvrakAl
            // 
            this.tsmiKayitMusteridenEvrakAl.Image = global::WindowsFormUI.Properties.Resources.Senet_Kendi32x32;
            this.tsmiKayitMusteridenEvrakAl.Name = "tsmiKayitMusteridenEvrakAl";
            this.tsmiKayitMusteridenEvrakAl.Size = new System.Drawing.Size(179, 22);
            this.tsmiKayitMusteridenEvrakAl.Text = "Müşteriden Evrak Al";
            this.tsmiKayitMusteridenEvrakAl.Click += new System.EventHandler(this.TsmiKayitMusteridenEvrakAl_Click);
            // 
            // tsmiKayitMusteriyeEvrakCik
            // 
            this.tsmiKayitMusteriyeEvrakCik.Image = global::WindowsFormUI.Properties.Resources.Cek_Cariye32x32;
            this.tsmiKayitMusteriyeEvrakCik.Name = "tsmiKayitMusteriyeEvrakCik";
            this.tsmiKayitMusteriyeEvrakCik.Size = new System.Drawing.Size(179, 22);
            this.tsmiKayitMusteriyeEvrakCik.Text = "Müşteriye Evrak Çık";
            this.tsmiKayitMusteriyeEvrakCik.Click += new System.EventHandler(this.TsmiKayitMusteriyeEvrakCik_Click);
            // 
            // tsmiSeperator
            // 
            this.tsmiSeperator.Name = "tsmiSeperator";
            this.tsmiSeperator.Size = new System.Drawing.Size(176, 6);
            // 
            // tsmiKayitPortfoydekiEvraklar
            // 
            this.tsmiKayitPortfoydekiEvraklar.Image = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.tsmiKayitPortfoydekiEvraklar.Name = "tsmiKayitPortfoydekiEvraklar";
            this.tsmiKayitPortfoydekiEvraklar.Size = new System.Drawing.Size(179, 22);
            this.tsmiKayitPortfoydekiEvraklar.Text = "Portföydeki Evraklar";
            this.tsmiKayitPortfoydekiEvraklar.Click += new System.EventHandler(this.TsmiKayitPortfoydekiEvraklar_Click);
            // 
            // FrmDegerliEvrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msDegerliEvraklarMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msDegerliEvraklarMenu;
            this.Name = "FrmDegerliEvrak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değerli Evrak Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msDegerliEvraklarMenu.ResumeLayout(false);
            this.msDegerliEvraklarMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msDegerliEvraklarMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDegerliEvrak;
        private System.Windows.Forms.ToolStripMenuItem tsmiDegerliEvrakCikis;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitMusteriyeEvrakCik;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitMusteridenEvrakAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitPortfoydekiEvraklar;
        private System.Windows.Forms.ToolStripSeparator tsmiSeperator;
    }
}
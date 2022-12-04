namespace WindowsFormUI.Views.Moduls.Faturalar
{
    partial class FrmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFatura));
            this.msFaturaMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFatura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFaturaExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitAlis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKayitFaturaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.msFaturaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFaturaMenu
            // 
            this.msFaturaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFatura,
            this.tsmiKayit});
            this.msFaturaMenu.Location = new System.Drawing.Point(0, 0);
            this.msFaturaMenu.Name = "msFaturaMenu";
            this.msFaturaMenu.Size = new System.Drawing.Size(800, 24);
            this.msFaturaMenu.TabIndex = 1;
            this.msFaturaMenu.Text = "menuStrip1";
            // 
            // tsmiFatura
            // 
            this.tsmiFatura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFaturaExit});
            this.tsmiFatura.Image = global::WindowsFormUI.Properties.Resources.Fatura32x32;
            this.tsmiFatura.Name = "tsmiFatura";
            this.tsmiFatura.Size = new System.Drawing.Size(68, 20);
            this.tsmiFatura.Text = "Fatura";
            // 
            // tsmiFaturaExit
            // 
            this.tsmiFaturaExit.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiFaturaExit.Name = "tsmiFaturaExit";
            this.tsmiFaturaExit.Size = new System.Drawing.Size(99, 22);
            this.tsmiFaturaExit.Text = "Çıkış";
            this.tsmiFaturaExit.Click += new System.EventHandler(this.TsmiFaturaExit_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitAlis,
            this.tsmiKayitSatis,
            this.tsmiKayitSeperator2,
            this.tsmiKayitFaturaListe});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitAlis
            // 
            this.tsmiKayitAlis.Image = global::WindowsFormUI.Properties.Resources.Fatura_Alis32x32;
            this.tsmiKayitAlis.Name = "tsmiKayitAlis";
            this.tsmiKayitAlis.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitAlis.Tag = "1";
            this.tsmiKayitAlis.Text = "Alış Faturası";
            this.tsmiKayitAlis.Click += new System.EventHandler(this.TsmiKayit_Click);
            // 
            // tsmiKayitSatis
            // 
            this.tsmiKayitSatis.Image = global::WindowsFormUI.Properties.Resources.Fatura_Satis32x32;
            this.tsmiKayitSatis.Name = "tsmiKayitSatis";
            this.tsmiKayitSatis.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitSatis.Tag = "2";
            this.tsmiKayitSatis.Text = "Satış Faturası";
            this.tsmiKayitSatis.Click += new System.EventHandler(this.TsmiKayit_Click);
            // 
            // tsmiKayitSeperator2
            // 
            this.tsmiKayitSeperator2.Name = "tsmiKayitSeperator2";
            this.tsmiKayitSeperator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiKayitFaturaListe
            // 
            this.tsmiKayitFaturaListe.Image = global::WindowsFormUI.Properties.Resources.Fatura32x32;
            this.tsmiKayitFaturaListe.Name = "tsmiKayitFaturaListe";
            this.tsmiKayitFaturaListe.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitFaturaListe.Text = "Fatura Liste";
            this.tsmiKayitFaturaListe.Click += new System.EventHandler(this.TsmiKayitFaturaListe_Click);
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msFaturaMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msFaturaMenu;
            this.Name = "FrmFatura";
            this.Text = "Fatura Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msFaturaMenu.ResumeLayout(false);
            this.msFaturaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFaturaMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFatura;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaturaExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitAlis;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitSatis;
        private System.Windows.Forms.ToolStripSeparator tsmiKayitSeperator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitFaturaListe;
    }
}
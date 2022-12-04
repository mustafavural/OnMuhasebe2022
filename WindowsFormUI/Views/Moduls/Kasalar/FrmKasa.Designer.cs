namespace WindowsFormUI.Views.Moduls.Kasalar
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.msKasaMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiKasa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKasaCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitKart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKayitTahsilatYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitOdemeYap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKayitListe = new System.Windows.Forms.ToolStripMenuItem();
            this.msKasaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msKasaMenu
            // 
            this.msKasaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKasa,
            this.tsmiKayit});
            this.msKasaMenu.Location = new System.Drawing.Point(0, 0);
            this.msKasaMenu.Name = "msKasaMenu";
            this.msKasaMenu.Size = new System.Drawing.Size(800, 24);
            this.msKasaMenu.TabIndex = 1;
            this.msKasaMenu.Text = "menuStrip1";
            // 
            // tsmiKasa
            // 
            this.tsmiKasa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKasaCikis});
            this.tsmiKasa.Image = global::WindowsFormUI.Properties.Resources.Kasa32x32;
            this.tsmiKasa.Name = "tsmiKasa";
            this.tsmiKasa.Size = new System.Drawing.Size(59, 20);
            this.tsmiKasa.Text = "Kasa";
            // 
            // tsmiKasaCikis
            // 
            this.tsmiKasaCikis.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiKasaCikis.Name = "tsmiKasaCikis";
            this.tsmiKasaCikis.Size = new System.Drawing.Size(99, 22);
            this.tsmiKasaCikis.Text = "Çıkış";
            this.tsmiKasaCikis.Click += new System.EventHandler(this.TsmiCikis_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitKart,
            this.toolStripSeparator1,
            this.tsmiKayitTahsilatYap,
            this.tsmiKayitOdemeYap,
            this.toolStripSeparator2,
            this.tsmiKayitListe});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitKart
            // 
            this.tsmiKayitKart.Image = global::WindowsFormUI.Properties.Resources.Kasa_Karti32x32;
            this.tsmiKayitKart.Name = "tsmiKayitKart";
            this.tsmiKayitKart.Size = new System.Drawing.Size(135, 22);
            this.tsmiKayitKart.Text = "Kasa Kart";
            this.tsmiKayitKart.Click += new System.EventHandler(this.TsmiKayitKart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // tsmiKayitTahsilatYap
            // 
            this.tsmiKayitTahsilatYap.Image = global::WindowsFormUI.Properties.Resources.Kasa_Tahsilat32x32;
            this.tsmiKayitTahsilatYap.Name = "tsmiKayitTahsilatYap";
            this.tsmiKayitTahsilatYap.Size = new System.Drawing.Size(135, 22);
            this.tsmiKayitTahsilatYap.Tag = "1";
            this.tsmiKayitTahsilatYap.Text = "Tahsilat Yap";
            this.tsmiKayitTahsilatYap.Click += new System.EventHandler(this.TsmiKayitYap_Click);
            // 
            // tsmiKayitOdemeYap
            // 
            this.tsmiKayitOdemeYap.Image = global::WindowsFormUI.Properties.Resources.Kasa_Odeme32x32;
            this.tsmiKayitOdemeYap.Name = "tsmiKayitOdemeYap";
            this.tsmiKayitOdemeYap.Size = new System.Drawing.Size(135, 22);
            this.tsmiKayitOdemeYap.Tag = "2";
            this.tsmiKayitOdemeYap.Text = "Ödeme Yap";
            this.tsmiKayitOdemeYap.Click += new System.EventHandler(this.TsmiKayitYap_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // tsmiKayitListe
            // 
            this.tsmiKayitListe.Image = global::WindowsFormUI.Properties.Resources.Kasa_Liste32x32;
            this.tsmiKayitListe.Name = "tsmiKayitListe";
            this.tsmiKayitListe.Size = new System.Drawing.Size(135, 22);
            this.tsmiKayitListe.Text = "Kasa Liste";
            this.tsmiKayitListe.Click += new System.EventHandler(this.TsmiKayitListe_Click);
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msKasaMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msKasaMenu;
            this.Name = "FrmKasa";
            this.Text = "Kasa Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msKasaMenu.ResumeLayout(false);
            this.msKasaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msKasaMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiKasa;
        private System.Windows.Forms.ToolStripMenuItem tsmiKasaCikis;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitKart;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitOdemeYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitListe;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitTahsilatYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
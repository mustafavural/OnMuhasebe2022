namespace WindowsFormUI.Views.Moduls.Cariler
{
    partial class FrmCari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCari));
            this.msCariMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCari = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCariExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCariKart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCariGrup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCariListe = new System.Windows.Forms.ToolStripMenuItem();
            this.msCariMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msCariMenu
            // 
            this.msCariMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCari,
            this.tsmiKayit});
            this.msCariMenu.Location = new System.Drawing.Point(0, 0);
            this.msCariMenu.Name = "msCariMenu";
            this.msCariMenu.Size = new System.Drawing.Size(800, 24);
            this.msCariMenu.TabIndex = 1;
            this.msCariMenu.Text = "menuStrip1";
            // 
            // tsmiCari
            // 
            this.tsmiCari.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCariExit});
            this.tsmiCari.Image = global::WindowsFormUI.Properties.Resources.Cari32x32;
            this.tsmiCari.Name = "tsmiCari";
            this.tsmiCari.Size = new System.Drawing.Size(56, 20);
            this.tsmiCari.Text = "Cari";
            // 
            // tsmiCariExit
            // 
            this.tsmiCariExit.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiCariExit.Name = "tsmiCariExit";
            this.tsmiCariExit.Size = new System.Drawing.Size(99, 22);
            this.tsmiCariExit.Text = "Çıkış";
            this.tsmiCariExit.Click += new System.EventHandler(this.TsmiCariExit_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitCariKart,
            this.tsmiKayitCariGrup,
            this.tsmiKayitCariListe});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitCariKart
            // 
            this.tsmiKayitCariKart.Image = global::WindowsFormUI.Properties.Resources.Cari_Kart32x32;
            this.tsmiKayitCariKart.Name = "tsmiKayitCariKart";
            this.tsmiKayitCariKart.Size = new System.Drawing.Size(124, 22);
            this.tsmiKayitCariKart.Text = "Cari Kart";
            this.tsmiKayitCariKart.Click += new System.EventHandler(this.TsmiCariKart_Click);
            // 
            // tsmiKayitCariGrup
            // 
            this.tsmiKayitCariGrup.Image = global::WindowsFormUI.Properties.Resources.Cari_Grup32x32;
            this.tsmiKayitCariGrup.Name = "tsmiKayitCariGrup";
            this.tsmiKayitCariGrup.Size = new System.Drawing.Size(124, 22);
            this.tsmiKayitCariGrup.Text = "Cari Grup";
            this.tsmiKayitCariGrup.Click += new System.EventHandler(this.TsmiCariGrup_Click);
            // 
            // tsmiKayitCariListe
            // 
            this.tsmiKayitCariListe.Image = global::WindowsFormUI.Properties.Resources.Cari_Liste32x32;
            this.tsmiKayitCariListe.Name = "tsmiKayitCariListe";
            this.tsmiKayitCariListe.Size = new System.Drawing.Size(124, 22);
            this.tsmiKayitCariListe.Text = "Cari Liste";
            this.tsmiKayitCariListe.Click += new System.EventHandler(this.TsmiCariListe_Click);
            // 
            // FrmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msCariMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msCariMenu;
            this.Name = "FrmCari";
            this.Text = "Cari Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msCariMenu.ResumeLayout(false);
            this.msCariMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCariMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCari;
        private System.Windows.Forms.ToolStripMenuItem tsmiCariExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCariKart;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCariGrup;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCariListe;
    }
}
namespace WindowsFormUI.Views.Moduls.Stoklar
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.msStokMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiStok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStokExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitStokKart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitStokGrup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitStokListe = new System.Windows.Forms.ToolStripMenuItem();
            this.msStokMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msStokMenu
            // 
            this.msStokMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStok,
            this.tsmiKayit});
            this.msStokMenu.Location = new System.Drawing.Point(0, 0);
            this.msStokMenu.Name = "msStokMenu";
            this.msStokMenu.Size = new System.Drawing.Size(800, 24);
            this.msStokMenu.TabIndex = 1;
            this.msStokMenu.Text = "menuStrip1";
            // 
            // tsmiStok
            // 
            this.tsmiStok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStokExit});
            this.tsmiStok.Image = global::WindowsFormUI.Properties.Resources.Stok32x32;
            this.tsmiStok.Name = "tsmiStok";
            this.tsmiStok.Size = new System.Drawing.Size(58, 20);
            this.tsmiStok.Text = "Stok";
            // 
            // tsmiStokExit
            // 
            this.tsmiStokExit.Image = global::WindowsFormUI.Properties.Resources.Kapat24x24;
            this.tsmiStokExit.Name = "tsmiStokExit";
            this.tsmiStokExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiStokExit.Text = "Çıkış";
            this.tsmiStokExit.Click += new System.EventHandler(this.TsmiStokExit_Click);
            // 
            // tsmiKayit
            // 
            this.tsmiKayit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKayitStokKart,
            this.tsmiKayitStokGrup,
            this.tsmiKayitStokListe});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitStokKart
            // 
            this.tsmiKayitStokKart.Image = global::WindowsFormUI.Properties.Resources.Stok_Kartı32x32;
            this.tsmiKayitStokKart.Name = "tsmiKayitStokKart";
            this.tsmiKayitStokKart.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitStokKart.Text = "Stok Kart";
            this.tsmiKayitStokKart.Click += new System.EventHandler(this.TsmiStokKart_Click);
            // 
            // tsmiKayitStokGrup
            // 
            this.tsmiKayitStokGrup.Image = global::WindowsFormUI.Properties.Resources.Stok_Grup32x32;
            this.tsmiKayitStokGrup.Name = "tsmiKayitStokGrup";
            this.tsmiKayitStokGrup.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitStokGrup.Text = "Stok Grup";
            this.tsmiKayitStokGrup.Click += new System.EventHandler(this.TsmiStokGrup_Click);
            // 
            // tsmiKayitStokListe
            // 
            this.tsmiKayitStokListe.Image = global::WindowsFormUI.Properties.Resources.Stok_Liste32x32;
            this.tsmiKayitStokListe.Name = "tsmiKayitStokListe";
            this.tsmiKayitStokListe.Size = new System.Drawing.Size(180, 22);
            this.tsmiKayitStokListe.Text = "Stok Liste";
            this.tsmiKayitStokListe.Click += new System.EventHandler(this.TsmiStokListe_Click);
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msStokMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msStokMenu;
            this.Name = "FrmStok";
            this.Text = "Stok Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msStokMenu.ResumeLayout(false);
            this.msStokMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msStokMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiStok;
        private System.Windows.Forms.ToolStripMenuItem tsmiStokExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitStokKart;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitStokGrup;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitStokListe;
    }
}
﻿namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    partial class FrmCekSenet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCekSenet));
            this.msDegerliEvraklarMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCekSenet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDegerliEvrakCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCaridenEvrakAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCariyeCiroEvrakCik = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKayitCariyeBorcEvrakCik = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKayitPortfoydekiEvraklar = new System.Windows.Forms.ToolStripMenuItem();
            this.bordroListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msDegerliEvraklarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msDegerliEvraklarMenu
            // 
            this.msDegerliEvraklarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCekSenet,
            this.tsmiKayit});
            this.msDegerliEvraklarMenu.Location = new System.Drawing.Point(0, 0);
            this.msDegerliEvraklarMenu.Name = "msDegerliEvraklarMenu";
            this.msDegerliEvraklarMenu.Size = new System.Drawing.Size(800, 24);
            this.msDegerliEvraklarMenu.TabIndex = 1;
            this.msDegerliEvraklarMenu.Text = "menuStrip1";
            // 
            // tsmiCekSenet
            // 
            this.tsmiCekSenet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDegerliEvrakCikis});
            this.tsmiCekSenet.Image = global::WindowsFormUI.Properties.Resources.Cek32x32;
            this.tsmiCekSenet.Name = "tsmiCekSenet";
            this.tsmiCekSenet.Size = new System.Drawing.Size(89, 20);
            this.tsmiCekSenet.Text = "Çek-Senet";
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
            this.tsmiKayitCaridenEvrakAl,
            this.tsmiKayitCariyeCiroEvrakCik,
            this.tsmiKayitCariyeBorcEvrakCik,
            this.tsmiSeperator,
            this.tsmiKayitPortfoydekiEvraklar,
            this.bordroListesiToolStripMenuItem});
            this.tsmiKayit.Image = global::WindowsFormUI.Properties.Resources.Kaydet24x24;
            this.tsmiKayit.Name = "tsmiKayit";
            this.tsmiKayit.Size = new System.Drawing.Size(61, 20);
            this.tsmiKayit.Text = "Kayıt";
            // 
            // tsmiKayitCaridenEvrakAl
            // 
            this.tsmiKayitCaridenEvrakAl.Image = global::WindowsFormUI.Properties.Resources.Senet_Kendi32x32;
            this.tsmiKayitCaridenEvrakAl.Name = "tsmiKayitCaridenEvrakAl";
            this.tsmiKayitCaridenEvrakAl.Size = new System.Drawing.Size(220, 22);
            this.tsmiKayitCaridenEvrakAl.Text = "Cariden Evrak Al";
            this.tsmiKayitCaridenEvrakAl.Click += new System.EventHandler(this.TsmiKayitMusteridenEvrakAl_Click);
            // 
            // tsmiKayitCariyeCiroEvrakCik
            // 
            this.tsmiKayitCariyeCiroEvrakCik.Image = global::WindowsFormUI.Properties.Resources.Cek_Cariye32x32;
            this.tsmiKayitCariyeCiroEvrakCik.Name = "tsmiKayitCariyeCiroEvrakCik";
            this.tsmiKayitCariyeCiroEvrakCik.Size = new System.Drawing.Size(220, 22);
            this.tsmiKayitCariyeCiroEvrakCik.Text = "Portföyden Cariye Evrak Çık";
            this.tsmiKayitCariyeCiroEvrakCik.Click += new System.EventHandler(this.TsmiKayitMusteriyeEvrakCik_Click);
            // 
            // tsmiKayitCariyeBorcEvrakCik
            // 
            this.tsmiKayitCariyeBorcEvrakCik.Image = global::WindowsFormUI.Properties.Resources.Cek_Kendi32x32;
            this.tsmiKayitCariyeBorcEvrakCik.Name = "tsmiKayitCariyeBorcEvrakCik";
            this.tsmiKayitCariyeBorcEvrakCik.Size = new System.Drawing.Size(220, 22);
            this.tsmiKayitCariyeBorcEvrakCik.Text = "Cariye Borç Evrağı Çık";
            this.tsmiKayitCariyeBorcEvrakCik.Click += new System.EventHandler(this.TsmiKayitCariyeBorcEvrakCik_Click);
            // 
            // tsmiSeperator
            // 
            this.tsmiSeperator.Name = "tsmiSeperator";
            this.tsmiSeperator.Size = new System.Drawing.Size(217, 6);
            // 
            // tsmiKayitPortfoydekiEvraklar
            // 
            this.tsmiKayitPortfoydekiEvraklar.Image = global::WindowsFormUI.Properties.Resources.Cek_Bordo32x32;
            this.tsmiKayitPortfoydekiEvraklar.Name = "tsmiKayitPortfoydekiEvraklar";
            this.tsmiKayitPortfoydekiEvraklar.Size = new System.Drawing.Size(220, 22);
            this.tsmiKayitPortfoydekiEvraklar.Text = "Portföydeki Evraklar";
            this.tsmiKayitPortfoydekiEvraklar.Click += new System.EventHandler(this.TsmiKayitPortfoydekiEvraklar_Click);
            // 
            // bordroListesiToolStripMenuItem
            // 
            this.bordroListesiToolStripMenuItem.Image = global::WindowsFormUI.Properties.Resources.Cek32x32;
            this.bordroListesiToolStripMenuItem.Name = "bordroListesiToolStripMenuItem";
            this.bordroListesiToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.bordroListesiToolStripMenuItem.Text = "Bordro Listesi";
            this.bordroListesiToolStripMenuItem.Click += new System.EventHandler(this.TsmiKayitBordroListeler_Click);
            // 
            // FrmCekSenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msDegerliEvraklarMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msDegerliEvraklarMenu;
            this.Name = "FrmCekSenet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek-Senet Modül - Mustafa VURAL Ön Muhasebe 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msDegerliEvraklarMenu.ResumeLayout(false);
            this.msDegerliEvraklarMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msDegerliEvraklarMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCekSenet;
        private System.Windows.Forms.ToolStripMenuItem tsmiDegerliEvrakCikis;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCariyeCiroEvrakCik;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCaridenEvrakAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitPortfoydekiEvraklar;
        private System.Windows.Forms.ToolStripSeparator tsmiSeperator;
        private System.Windows.Forms.ToolStripMenuItem bordroListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKayitCariyeBorcEvrakCik;
    }
}
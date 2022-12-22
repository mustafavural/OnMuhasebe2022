using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormUI.Views
{
    public class FrmBase : Form
    {
        private IContainer components = null;
        public FrmBase()
        {
            SuspendLayout();
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(415, 325);
            this.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Mustafa VURAL Ön Muhasebe 2022";
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
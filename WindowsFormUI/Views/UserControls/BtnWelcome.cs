using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormUI.Views.UserControls
{
    public class BtnWelcome : Button
    {
        public BtnWelcome()
        {
            this.BackColor = Color.Cyan;
            this.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.Black;
            this.Location = new Point(116, 66);
            this.Name = "btnWelcome";
            this.Size = new Size(164, 40);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = false;
        }
    }
}
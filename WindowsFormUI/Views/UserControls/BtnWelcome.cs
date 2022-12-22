using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormUI.Views.UserControls
{
    public class BtnWelcome : Button
    {
        public BtnWelcome()
        {
            BackColor = Color.Cyan;
            FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.Black;
            Location = new Point(116, 66);
            Name = "btnWelcome";
            Size = new Size(164, 40);
            TabIndex = 0;
            UseVisualStyleBackColor = false;
        }
    }
}
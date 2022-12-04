using System;
using System.Windows.Forms;

namespace WindowsFormUI.Views.UserControls
{
    public partial class UscFormButtons : UserControl
    {
        public event EventHandler ClickClear;
        public event EventHandler ClickSave;
        public event EventHandler ClickCancel;


        public bool BtnClear_Visible { get => BtnClear.Visible; set => BtnClear.Visible = value; }
        public bool BtnDelete_Enable { get => BtnDelete.Enabled; set => BtnDelete.Enabled = value; }
        public string BtnDelete_Text { get => BtnDelete.Text; set => BtnDelete.Text = value; }
        public bool BtnSave_Enable { get => BtnSave.Enabled; set => BtnSave.Enabled = value; }
        public string BtnSave_Text { get => BtnSave.Text; set => BtnSave.Text = value; }
        public string LblStatus_Text { get => lblStatus.Text; set => lblStatus.Text = value; }

        public UscFormButtons()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            this.BtnClear.Click += (o, e) => { this.ClickClear?.Invoke(o, e); };
            this.BtnDelete.Click += (o, e) => { this.ClickCancel?.Invoke(o, e); };
            this.BtnSave.Click += (o, e) => { this.ClickSave?.Invoke(o, e); };
        }
    }
}

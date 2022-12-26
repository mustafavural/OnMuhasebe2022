using Core.Business.Abstract;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Companies
{
    public partial class FrmUserList : FrmBase
    {
        private readonly IUserService _userService;
        public FrmUserList(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _userService.GetList().Data.Select(s => new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                s.Email
            }).ToList();
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var secilenUser = _userService.GetByMail(dgvUsers.Rows[e.RowIndex].Cells["colEmail"].Value.ToString()).Data;
                StaticPrimitives.SecilenUserId = secilenUser.Id;
                this.Close();
            }
        }
    }
}
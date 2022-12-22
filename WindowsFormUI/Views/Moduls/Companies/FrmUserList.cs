using Core.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvUsers.DataSource = _userService.GetList();
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var secilenUser = _userService.GetByMail(dgvUsers.Rows[e.RowIndex].Cells["colEmail"].Value.ToString());
            }
        }
    }
}
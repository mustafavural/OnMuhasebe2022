using Core.Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Users
{
    public partial class FrmClaim : FrmBase
    {
        private readonly IUserService _userService;
        private List<OperationClaim> _userClaims;
        private OperationClaim _secilenClaim;
        private bool _ciftTiklandiMi;
        public bool SecimIcin { get; set; }

        public FrmClaim(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void FrmClaim_Load(object sender, EventArgs e)
        {
            if (SecimIcin)
            {
                uscClaims.Visible = false;
                lblStatusBar.Visible = false;
                grpEkleGuncelle.Height = 55;
            }
            this.ClearScreen();
        }

        private void ClearScreen()
        {
            try
            {
                _secilenClaim = null;
                _userClaims = _userService.GetClaimList();
                txtClaimName.Text = "";
                uscClaims.BtnDelete_Enable = false;
                uscClaims.BtnSave_Enable = false;
                uscClaims.BtnSave_Text = "Kaydet";
                lblStatusBar.Text = "";
                dgvClaims.DataSource = _userClaims.OrderByDescending(s => s.Id).ToList();
            }
            catch (UnauthorizedAccessException err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                this.BeginInvoke(new MethodInvoker(Close));
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void WriteToScreen(OperationClaim operationClaim)
        {
            if (!SecimIcin)
            {
                txtClaimName.Text = operationClaim.Name;
                _secilenClaim = operationClaim;
                uscClaims.BtnDelete_Enable = true;
                uscClaims.BtnSave_Enable = true;
                uscClaims.BtnSave_Text = "Güncelle";
                lblStatusBar.Text = "";
            }
        }

        private void UscClaims_EkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            if (_secilenClaim == null)
            {
                _secilenClaim = new OperationClaim { Name = txtClaimName.Text };
                result = _userService.AddClaim(_secilenClaim);
            }
            else
            {
                _secilenClaim.Name = txtClaimName.Text;
                result = _userService.UpdateClaim(_secilenClaim);
            }
            this.ClearScreen();
            lblStatusBar.Text = result.Message;
        }

        private void UscClaims_GrupSil(object sender, EventArgs e)
        {
            IResult result;
            result = _userService.DeleteClaim(_secilenClaim);
            this.ClearScreen();
            lblStatusBar.Text = result.Message;
        }

        private void UscClaims_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void TxtClaimName_TextChanged(object sender, EventArgs e)
        {
            var result = _userClaims.Where(s => s.Name.ToLower().Contains(txtClaimName.Text.ToLower()));
            uscClaims.BtnSave_Enable = txtClaimName.Text.Length > 2;
            lblStatusBar.Text = "";
            dgvClaims.DataSource = result.OrderByDescending(s => s.Id).ToList();
        }

        private void DgvClaims_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int claimId = (int)dgvClaims.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenClaim = _userClaims.Where(s => s.Id == claimId).Single();
                if (SecimIcin)
                {
                    StaticPrimitives.SecilenClaimId = _secilenClaim.Id;
                    _ciftTiklandiMi = true;
                    this.Close();
                }
                else
                    this.WriteToScreen(_secilenClaim);
            }
        }

        private void FrmClaim_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenClaimId = 0;
        }
    }
}
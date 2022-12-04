using Autofac;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Stoklar
{
    public partial class FrmStokKart : FrmBase
    {
        private readonly IStokService _stokService;
        private readonly IStokHareketService _stokHareketService;
        private Stok _secilenStok = null;

        public FrmStokKart(IStokService stokService, IStokHareketService stokHareketService)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokHareketService = stokHareketService;
            this.ClearScreen();
        }

        #region Events

        private void TxtStokKod_Leave(object sender, EventArgs e)
        {
            if (txtStokKod.Text.Length != 0)
            {
                var result = _stokService.GetByKod(txtStokKod.Text);
                if (result.Data != null)
                {
                    _secilenStok = result.Data;
                    WriteToScreen(_secilenStok);
                }
                else
                {
                    var txt = txtStokKod.Text;
                    ClearScreen();
                    txtStokKod.Text = txt;
                    uscStokEkleSilButon.BtnClear_Visible = true;
                    txtStokKod.Enabled = false;
                    uscStokEkleSilButon.BtnSave_Enable = true;
                }
            }
        }

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var frmliste= Program.Container.Resolve<FrmStokListe>();
            frmliste.SecimIcin = true;
            frmliste.ShowDialog();

            if (StaticPrimitives.SecilenStokId > 0)
            {
                _secilenStok = _stokService.GetById(StaticPrimitives.SecilenStokId).Data;
                WriteToScreen(_secilenStok);
            }
        }

        private void UscStokEkleSilButon_ClickEkraniTemizle(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var frmliste = Program.Container.Resolve<FrmStokGrup>();
            frmliste.SecimIcin = true;
            frmliste.ShowDialog();

            try
            {
                if (StaticPrimitives.SecilenStokCategoryId > 0)
                {
                    var result = _stokService.AddCategoryToStok(new StokGrup
                    {
                        StokId = _secilenStok.Id,
                        StokCategoryId = StaticPrimitives.SecilenStokCategoryId
                    });

                    uscStokEkleSilButon.LblStatus_Text = result.Message;
                    dgvGrupView.DataSource = _secilenStok.StokCategoryler;
                    btnGrupEkle.Focus();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnGrupSil_Click(object sender, EventArgs e)
        {
            try
            {
                var stokGrup = _stokService.GetStokGrup(_secilenStok.Id, StaticPrimitives.SecilenStokCategoryId).Data;
                var result = _stokService.DeleteCategoryFromStok(stokGrup);

                uscStokEkleSilButon.LblStatus_Text = result.Message;

                btnGrupSil.Enabled = false;
                StaticPrimitives.SecilenStokCategoryId = 0;
                dgvGrupView.DataSource = _secilenStok.StokCategoryler;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscStokEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            var readStok = ReadStokFromForm();
            IResult result;
            if (_secilenStok == null)
                result = _stokService.Add(readStok);
            else
            {
                readStok.Id = _secilenStok.Id;
                result = _stokService.Update(readStok);
            }

            this.ClearScreen();
            uscStokEkleSilButon.LblStatus_Text = result.Message;
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            foreach (var item in _secilenStok.StokCategoryler)
            {
                var stokGrup = _stokService.GetStokGrup(_secilenStok.Id, item.Id).Data;
                _stokService.DeleteCategoryFromStok(stokGrup);
            }
            var result = _stokService.Delete(_secilenStok);

            if (result.IsSuccess)
                this.ClearScreen();
            uscStokEkleSilButon.LblStatus_Text = result.Message;
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int secilenStokId = (int)dgvStokListe.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenStok = _stokService.GetById(secilenStokId).Data;
                WriteToScreen(_secilenStok);
            }
        }

        private void DgvGrupView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaticPrimitives.SecilenStokCategoryId = (int)dgvGrupView.Rows[e.RowIndex].Cells["colGrupId"].Value;
            btnGrupSil.Enabled = true;
        }

        private void DgvGrupView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGrupSil.Enabled = false;
        }

        private void HarfEngelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
        #endregion

        #region PrivateMethods
        private Stok ReadStokFromForm() => new()
        {
            Kod = txtStokKod.Text,
            Barkod = txtStokBarkod.Text,
            Ad = txtStokAd.Text,
            Kdv = Convert.ToInt32(txtStokKDV.Text ?? "0"),
            Birim = txtStokBirim.Text
        };

        private void WriteToScreen(Stok secilenStok)
        {
            txtStokKod.Text = secilenStok.Kod;
            txtStokBarkod.Text = secilenStok.Barkod;
            txtStokAd.Text = secilenStok.Ad;
            txtStokKDV.Text = secilenStok.Kdv.ToString();
            txtStokBirim.Text = secilenStok.Birim;

            dgvGrupView.DataSource = secilenStok.StokCategoryler;

            btnGrupEkle.Enabled = true;
            btnGrupSil.Enabled = true;
            uscStokEkleSilButon.BtnClear_Visible = true;
            uscStokEkleSilButon.BtnDelete_Enable = true;
            uscStokEkleSilButon.BtnSave_Enable = true;
            uscStokEkleSilButon.BtnSave_Text = "Güncelle";
            uscStokEkleSilButon.LblStatus_Text = "";



            if (!tabFrmStok.TabPages.Contains(tabStokHareket))
            {
                tabFrmStok.TabPages.Insert(tabFrmStok.TabPages.Count, tabStokHareket);
            }
            var result = _stokHareketService.GetListByStokId(secilenStok.Id).Data;
            dgvStokHareketler.DataSource = result;
            grpStokHareketler.Text = $"{secilenStok.Ad} ------------------ Kalan Stok Miktarı : {result.Sum(s => s.Miktar)} - {secilenStok.Birim}";
        }

        private void ClearScreen()
        {
            txtStokKod.Enabled = true;
            txtStokKod.Text = "";
            txtStokBarkod.Text = "";
            txtStokAd.Text = "";
            txtStokKDV.Text = "";
            txtStokBirim.Text = "";

            dgvGrupView.DataSource = new List<StokCategory>();

            btnGrupEkle.Enabled = false;
            btnGrupSil.Enabled = false;
            uscStokEkleSilButon.BtnClear_Visible = false;
            uscStokEkleSilButon.BtnDelete_Enable = false;
            uscStokEkleSilButon.BtnSave_Enable = false;
            uscStokEkleSilButon.BtnSave_Text = "Ekle";
            uscStokEkleSilButon.LblStatus_Text = "";
            _secilenStok = null;
            dgvStokListe.DataSource = _stokService.GetList().Data.OrderByDescending(s => s.Id).ToList();

            if (tabFrmStok.TabPages.Contains(tabStokHareket))
            {
                tabFrmStok.TabPages.Remove(tabStokHareket);
            }
        }
        #endregion
    }
}
using Autofac;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Stoklar
{
    public partial class FrmStokListe : FrmBase
    {
        private readonly IStokService _stokService;
        private readonly IStokCategoryService _stokCategoryService;
        private readonly IStokHareketService _stokHareketService;
        private readonly List<Stok> _stoklar;
        private bool _ciftTiklandiMi = false;

        public bool SecimIcin { get; set; }

        public FrmStokListe(IStokService stokService, IStokCategoryService stokCategoryService, IStokHareketService stokHareketService)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokHareketService = stokHareketService;
            _stokCategoryService = stokCategoryService;
            _stoklar = new();
        SecimIcin = false;
        }

        private void FrmStokListe_Load(object sender, EventArgs e)
        {
            try
            {
                _stoklar.AddRange(_stokService.GetList().Data);
                WriteToScreen(_stoklar);
                txtStokKod.Focus();
            }
            catch (UnauthorizedAccessException err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void WriteToScreen(List<Stok> _stoklar)
        {
            dgvStokListe.DataSource = _stoklar.Select(s => new
            {
                s.Id,
                s.Kod,
                s.Barkod,
                s.Ad,
                s.Kdv,
                MevcutBakiye = _stokHareketService.GetStokBakiye(s.Kod).Data.ToString(),
                s.Birim
            }).ToList();
        }

        #region GrupFiltreleri
        private void BtnStokGrupEkle_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmStokGrup>();
            form.SecimIcin = true;
            form.ShowDialog();

            if (StaticPrimitives.SecilenStokCategoryId > 0)
            {
                var secilenStokCategory = _stokCategoryService.GetById(StaticPrimitives.SecilenStokCategoryId).Data;
                if (!lsbCategoryler.Items.Contains(secilenStokCategory.Ad))
                    lsbCategoryler.Items.Add(secilenStokCategory.Ad);
                TxtStokBilgiler_TextChanged(sender, e);

                StaticPrimitives.SecilenStokCategoryId = 0;
            }
        }

        private void BtnStokGrupSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbCategoryler.SelectedItem != null)
                {
                    lsbCategoryler.Items.Remove(lsbCategoryler.SelectedItem);
                    TxtStokBilgiler_TextChanged(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private bool SecilenGruplaraUyuyorMu(string kod)
        {
            if (lsbCategoryler.Items.Count > 0)
            {
                var list = _stokService.GetByKod(kod).Data.StokCategoryler;
                foreach (var item in list)
                    if (lsbCategoryler.Items.Contains(item.Ad))
                        return true;
                return false;
            }
            return true;
        }
        #endregion

        private void TxtStokBilgiler_TextChanged(object sender, EventArgs e)
        {
            var result = _stoklar.Where(s => s.Kod.ToLower().Contains(txtStokKod.Text.ToLower()) &&
                                             s.Barkod.ToLower().Contains(txtStokBarkod.Text.ToLower()) &&
                                             s.Ad.ToLower().Contains(txtStokAd.Text.ToLower()) &&
                                             s.Kdv.ToString().Contains(txtStokKDV.Text.ToLower()) &&
                                             s.Birim.ToLower().Contains(txtStokBirim.Text.ToLower()) &&
                                             SecilenGruplaraUyuyorMu(s.Kod));
            WriteToScreen(result.ToList());
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenId = (int)dgvStokListe.SelectedRows[0].Cells["colId"].Value;
            if (secilenId > 0)
            {
                StaticPrimitives.SecilenStokId = secilenId;
                _ciftTiklandiMi = true;
                if (SecimIcin)
                    this.Close();
            }
        }

        private void FrmStokListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenStokId = 0;
        }

        private void TsmiShowColumn_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            var column = tsmi.Name[8..];
            dgvStokListe.Columns["col" + column].Visible = !tsmi.Checked;
            tsmi.Checked = !tsmi.Checked;
        }
    }
}
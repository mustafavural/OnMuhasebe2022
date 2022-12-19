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

namespace WindowsFormUI.Views.Moduls.Cariler
{
    public partial class FrmCariListe : FrmBase
    {
        private readonly ICariService _cariService;
        private readonly ICariCategoryService _cariCategoryService;
        private readonly ICariHareketService _cariHareketService;
        private CariCategory _secilenCariCategory;
        private bool _ciftTiklandiMi = false;
        private List<Cari> _cariler;
        private List<CariCategory> _cariCategoryler;

        public bool SecimIcin { get; set; }

        public FrmCariListe(ICariService cariService, ICariCategoryService cariCategoryService, ICariHareketService cariHareketService)
        {
            InitializeComponent();
            _cariService = cariService;
            _cariCategoryService = cariCategoryService;
            _cariHareketService = cariHareketService;
            SecimIcin = false;
        }

        private void FrmCariListe_Load(object sender, EventArgs e)
        {
            try
            {
                _cariler = _cariService.GetList().Data;
                _cariCategoryler = _cariCategoryService.GetList().Data;
                WriteToScreen(_cariler);
                txtCariKod.Focus();
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

        private void WriteToScreen(List<Cari> cariler)
        {
            dgvCariListe.DataSource = cariler.Select(s => new
            {
                s.Id,
                s.Kod,
                s.Unvan,
                s.VergiDairesi,
                s.VergiNo,
                s.Adres.Telefon,
                s.Adres.Telefon2,
                s.Adres.Fax,
                s.Adres.Web,
                s.Adres.Eposta,
                Il = s.Adres.Ilce.Sehir.Ad,
                Ilce = s.Adres.Ilce.Ad,
                s.Adres.AcikAdres,
                Bakiye = _cariHareketService.GetCariBakiye(s.Kod).Data
            }).ToList();
        }

        #region GrupFiltreleri
        private void BtnCariGrupEkle_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariGrup>();
            form.SecimIcin = true;
            form.ShowDialog();

            try
            {
                if (StaticPrimitives.SecilenCariCategoryId > 0)
                {
                    _secilenCariCategory = _cariCategoryler.Where(cg => cg.Id == StaticPrimitives.SecilenCariCategoryId).Single();
                    if (lsbCategoryler.Items.Contains(_secilenCariCategory.Ad))
                        return;

                    lsbCategoryler.Items.Add(_secilenCariCategory.Ad);
                    TxtCariBilgiler_TextChanged(sender, e);


                    StaticPrimitives.SecilenCariCategoryId = 0;
                    _secilenCariCategory = null;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnCariGrupSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbCategoryler.SelectedItem != null)
                    lsbCategoryler.Items.Remove(lsbCategoryler.SelectedItem);
                TxtCariBilgiler_TextChanged(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool SecilenGruplaraUyuyorMu(string kod)
        {
            if (lsbCategoryler.Items.Count == 0)
                return true;
            else
            {
                var list = _cariService.GetByKod(kod).Data.CariCategoryler;
                foreach (var item in list)
                    if (lsbCategoryler.Items.Contains(item.Ad))
                        return true;
                return false;
            }
        }
        #endregion

        private void TxtCariBilgiler_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _cariler.Where(s => s.Kod.ToLower().Contains(txtCariKod.Text.ToLower()) &&
                                                 s.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                                                 s.VergiDairesi.ToLower().Contains(txtCariVergiDairesi.Text.ToLower()) &&
                                                 s.VergiNo.ToString().Contains(txtCariVergiNo.Text) &&

                                                 (s.Adres.Telefon.ToLower().Contains(txtCariTelefon.Text.ToLower()) ||
                                                 s.Adres.Telefon2.ToLower().Contains(txtCariTelefon.Text.ToLower()) ||
                                                 s.Adres.Fax.ToLower().Contains(txtCariTelefon.Text.ToLower())) &&

                                                 s.Adres.Web.ToLower().Contains(txtCariWeb.Text.ToLower()) &&
                                                 s.Adres.Eposta.ToLower().Contains(txtCariEposta.Text.ToLower().ToLower()) &&
                                                 s.Adres.Ilce.Sehir.Ad.ToLower().Contains(txtCariIl.Text.ToLower()) &&
                                                 s.Adres.Ilce.Ad.ToLower().Contains(txtCariIlce.Text.ToLower().ToLower()) &&
                                                 (SecilenGruplaraUyuyorMu(s.Kod))).ToList();

                WriteToScreen(result);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvCariListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int secilenCariId = (int)dgvCariListe.SelectedRows[0].Cells["colId"].Value;
                StaticPrimitives.SecilenCariId = secilenCariId;
                _ciftTiklandiMi = true;
                if (SecimIcin) this.Close();
            }
        }

        private void FrmCariListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenCariId = 0;
        }

        private void TsmiShowColumn_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itsm = (ToolStripMenuItem)sender;
            var column = itsm.Name[8..];
            dgvCariListe.Columns["col" + column].Visible = !itsm.Checked;
            itsm.Checked = !itsm.Checked;
        }
    }
}
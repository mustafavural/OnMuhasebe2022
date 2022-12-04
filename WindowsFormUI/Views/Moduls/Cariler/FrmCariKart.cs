using Autofac;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Cariler
{
    public partial class FrmCariKart : FrmBase
    {
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;
        private Cari _secilenCari;

        public FrmCariKart(ICariService cariService, ICariHareketService cariHareketService)
        {
            InitializeComponent();
            _cariService = cariService;
            _cariHareketService = cariHareketService;
        }

        #region Events
        private void FrmCariKart_Load(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void TxtCariKod_Leave(object sender, EventArgs e)
        {
            if (txtCariKod.Text.Length != 0)
            {
                txtCariKod.Leave -= TxtCariKod_Leave;
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data != null)
                {
                    _secilenCari = result.Data;
                    WriteToScreen(_secilenCari);
                }
                else
                {
                    var txt = txtCariKod.Text;
                    ClearScreen();
                    txtCariKod.Text = txt;
                    uscCariEkleSilButon.BtnClear_Visible = true;
                    txtCariKod.Enabled = false;
                    uscCariEkleSilButon.BtnSave_Enable = true;
                }
                txtCariKod.Leave += TxtCariKod_Leave;
            }
        }

        private void BtnCariBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariListe>();
            form.SecimIcin = true;
            form.Show();

            try
            {
                if (StaticPrimitives.SecilenCariId > 0)
                {
                    _secilenCari = _cariService.GetById(StaticPrimitives.SecilenCariId).Data;
                    WriteToScreen(_secilenCari);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscCariEkleSilButon_ClickEkraniTemizle(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariGrup>();
            form.SecimIcin = true;
            form.Show();

            try
            {
                if (StaticPrimitives.SecilenCariCategoryId > 0)
                {
                    var result = _cariService.AddCategoryToCari(new CariGrup
                    {
                        CariId = _secilenCari.Id,
                        CariCategoryId = StaticPrimitives.SecilenCariCategoryId
                    });

                    uscCariEkleSilButon.LblStatus_Text = result.Message;
                    dgvGrupView.DataSource = _cariService.GetByKod(_secilenCari.Kod).Data.CariCategoryler;
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
                var cariGrup = _cariService.GetCariGrup(_secilenCari.Id, StaticPrimitives.SecilenCariCategoryId).Data;
                var result = _cariService.DeleteCategoryFromCari(cariGrup);

                uscCariEkleSilButon.LblStatus_Text = result.Message;

                btnGrupSil.Enabled = false;
                StaticPrimitives.SecilenCariCategoryId = 0;
                dgvGrupView.DataSource = _cariService.GetByKod(_secilenCari.Kod).Data.CariCategoryler;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscCariEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            try
            {
                this.ReadFromScreen(out Cari cari);

                var result = cari.Id == 0 ? _cariService.Add(cari) : _cariService.Update(cari);

                this.ClearScreen();
                uscCariEkleSilButon.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscCariEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            try
            {
                var result = _cariService.Delete(_secilenCari);

                this.ClearScreen();
                uscCariEkleSilButon.LblStatus_Text = result.Message;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvCariListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilenCariId = (int)dgvCariListe.Rows[e.RowIndex]?.Cells["colId"].Value;
                _secilenCari = _cariService.GetById(secilenCariId).Data;
                WriteToScreen(_secilenCari);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvGrupView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaticPrimitives.SecilenCariCategoryId = (int)dgvGrupView.Rows[e.RowIndex]?.Cells["colGrupId"].Value;
            btnGrupSil.Enabled = true;
        }

        private void DgvGrupView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGrupSil.Enabled = false;
        }
        #endregion

        #region KeyEvents
        private void HarfEngelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
        #endregion

        #region PrivateMethods
        private void ReadFromScreen(out Cari cari)
        {
            cari = new Cari
            {
                Id = _secilenCari == null ? 0 : _secilenCari.Id,
                Kod = txtCariKod.Text,
                Unvan = txtUnvan.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                Adres = new Adres
                {
                    Telefon = txtTelefon.Text,
                    Web = txtWeb.Text,
                    Eposta = txtEposta.Text,
                    AcikAdres = txtAcikAdres.Text,
                    Ilce = new Ilce
                    {
                        Ad = txtIlce.Text,
                        Sehir = new Sehir
                        {
                            Ad = txtIl.Text
                        }
                    }
                }
            };
        }

        private void WriteToScreen(Cari secilenCari)
        {
            txtCariKod.Text = secilenCari.Kod;
            txtUnvan.Text = secilenCari.Unvan;
            txtVergiDairesi.Text = secilenCari.VergiDairesi;
            txtVergiNo.Text = secilenCari.VergiNo;
            txtTelefon.Text = secilenCari.Adres.Telefon;
            txtWeb.Text = secilenCari.Adres.Web;
            txtEposta.Text = secilenCari.Adres.Eposta;
            txtAcikAdres.Text = secilenCari.Adres.AcikAdres;
            txtIlce.Text = secilenCari.Adres.Ilce.Ad;
            txtIl.Text = secilenCari.Adres.Ilce.Sehir.Ad;

            dgvGrupView.DataSource = _cariService.GetByKod(secilenCari.Kod).Data.CariCategoryler;

            btnGrupEkle.Enabled = true;
            btnGrupEkle.Enabled = true;
            uscCariEkleSilButon.BtnClear_Visible = true;
            uscCariEkleSilButon.BtnDelete_Enable = true;
            uscCariEkleSilButon.BtnSave_Enable = true;
            uscCariEkleSilButon.BtnSave_Text = "Güncelle";
            uscCariEkleSilButon.LblStatus_Text = "";



            if (!tabCariControl.TabPages.Contains(tabCariHareket))
            {
                tabCariControl.TabPages.Insert(tabCariControl.TabPages.Count, tabCariHareket);
            }
            var result = _cariHareketService.GetListByCariId(secilenCari.Id).Data;
            dgvCariHareketler.DataSource = result.ToList();
            grpCariHareketler.Text = $"{secilenCari.Unvan} ------------------ Mevcut Bakiye : {result.Sum(s => s.Tutar)}";
        }

        private void ClearScreen()
        {
            txtCariKod.Enabled = true;
            txtCariKod.Text = "";
            txtUnvan.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtTelefon.Text = "";
            txtWeb.Text = "";
            txtEposta.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtAcikAdres.Text = "";

            dgvGrupView.DataSource = new List<StokCategory>();

            btnGrupEkle.Enabled = false;
            btnGrupSil.Enabled = false;
            uscCariEkleSilButon.BtnClear_Visible = false;
            uscCariEkleSilButon.BtnDelete_Enable = false;
            uscCariEkleSilButon.BtnSave_Enable = false;
            uscCariEkleSilButon.BtnSave_Text = "Ekle";
            uscCariEkleSilButon.LblStatus_Text = "";
            _secilenCari = null;
            dgvCariListe.DataSource = _cariService.GetList().Data.OrderByDescending(s => s.Id).ToList();

            if (tabCariControl.TabPages.Contains(tabCariHareket))
            {
                tabCariControl.TabPages.Remove(tabCariHareket);
            }
            txtCariKod.Focus();
        }
        #endregion
    }
}
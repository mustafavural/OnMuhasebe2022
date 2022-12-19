using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.UserExtensions;

namespace WindowsFormUI.Views.Moduls.Faturalar
{
    public partial class FrmFaturaListe : FrmBase
    {

        private readonly IFaturaService _faturaService;
        private List<Fatura> _faturalar;

        public FaturaTurleri FaturaTur { get; set; }

        public bool SecimIcin => (int)FaturaTur > 0;

        public FrmFaturaListe(IFaturaService faturaService)
        {
            InitializeComponent();
            _faturaService = faturaService;
            FaturaTur = FaturaTurleri.Hepsi;
        }

        private void FrmFaturaListe_Load(object sender, EventArgs e)
        {
            try
            {
                var tur = FaturaTur.ToText();
                lblFaturaTurler.Text = tur != "" ? tur : "Tümü";
                _faturalar = _faturaService.GetList(f => f.Tur == tur || tur == "").Data;
                dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
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

        private void WriteToScreen(List<Fatura> faturalar)
        {
            try
            {
                dgvFaturaListe.DataSource = faturalar.Select(s => new
                {
                    s.Id,
                    s.No,
                    s.Tur,
                    s.Cari.Unvan,
                    Tutar = s.StokHareketler.Sum(a => a.NetTutar),
                    s.Tarih,
                    s.Aciklama
                }).ToList();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void FaturaListe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _faturalar.Where(s =>
                                                   s.No.ToLower().Contains(txtFaturaNo.Text.ToLower()) &&
                                                   (s.Tur == FaturaTur.ToText() || FaturaTur.ToText() == "") &&
                                                   s.Cari.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                                                   txtTutarEnAz.Text.ToDecimal() <= s.StokHareketler.Sum(a => a.NetTutar) &&
                                                   txtTutarEnCok.Text.ToDecimal(1) >= s.StokHareketler.Sum(a => a.NetTutar) &&
                                                   dtpTarihIlk.Value <= s.Tarih && s.Tarih <= dtpTarihSon.Value
                                                   ).ToList();
                WriteToScreen(result);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DgvFaturaListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && SecimIcin)
            {
                StaticPrimitives.SecilenFaturaId = (int)dgvFaturaListe.Rows[e.RowIndex].Cells["colFaturaId"].Value;
                this.Close();
            }
        }
    }
}
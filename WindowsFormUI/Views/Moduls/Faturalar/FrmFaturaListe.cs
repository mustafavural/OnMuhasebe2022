using Business.Abstract;
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
            dtpTarihBaslangic.Value = DateTime.Today.AddDays(-10);
        }

        private void FrmFaturaListe_Load(object sender, EventArgs e)
        {
            lblFaturaTurler.Text = FaturaTur.ToText() ?? "Tümü";

            _faturalar = _faturaService.GetList(f => f.Tur == FaturaTur.ToText()).Data;
            FaturaListe_TextChanged(sender, e);
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
                ErrorMessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void FaturaListe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //var result = _faturalar.Where(s => s.Tur == (FaturaTur.ToText()??"") &&
                //                                   s.No.ToLower().Contains(txtFaturaNo.Text.ToLower()) &&
                //                                   s.Cari.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                //                                   s.Tarih >= dtpTarihBaslangic.Value &&
                //                                   s.Tarih <= dtpTarihBitis.Value).ToList();

                //WriteToScreen(result);
            }
            catch (Exception err)
            {
                ErrorMessageHelper.ErrorMessageBuilder(err);
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
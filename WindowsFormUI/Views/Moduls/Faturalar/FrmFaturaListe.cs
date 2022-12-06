using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Faturalar
{
    public partial class FrmFaturaListe : FrmBase
    {

        private readonly IFaturaService _faturaService;
        private readonly ICariService _cariService;
        private readonly List<Fatura> _faturalar;

        private bool _ciftTiklandiMi = false;

        public FaturaTurleri FaturaTur { get; set; }

        public bool SecimIcin => (int)FaturaTur > 0;

        public FrmFaturaListe(IFaturaService faturaService, ICariService cariService)
        {
            InitializeComponent();
            _faturaService = faturaService;
            _cariService = cariService;
            FaturaTur = FaturaTurleri.Hepsi;
            _faturalar = _faturaService.GetList().Data;
        }

        private void WriteToScreen(List<Fatura> faturalar)
        {
            dgvFaturaListe.DataSource = faturalar.Select(s => new
            {
                s.Id,
                s.No,
                s.Tur,
                _cariService.GetById(s.CariId).Data.Unvan,
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void FrmFaturaListe_Load(object sender, EventArgs e)
        {
            dtpTarihBaslangic.Value = DateTime.Today.Add(new TimeSpan(-10, 0, 0, 0));
            if (SecimIcin) 
                lblFaturaTurler.Text = FaturaTur == FaturaTurleri.Satis ? "Satış Faturası" : "Alış Faturası";
            else
                lblFaturaTurler.Text = "Tümü";

            WriteToScreen(_faturalar);

            FaturaListe_TextChanged(sender, e);
        }

        private void FaturaListe_TextChanged(object sender, EventArgs e)
        {
            string tur = FaturaTur == FaturaTurleri.Satis ? "Satış Faturası" : "Alış Faturası";
            try
            {
                var result = _faturalar.Where(s => s.No.ToLower().Contains(txtFaturaNo.Text.ToLower()) &&
                                                   SecimIcin ? s.Tur == tur : true &&
                                                   _cariService.GetById(s.CariId).Data.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                                                   s.Tarih >= dtpTarihBaslangic.Value &&
                                                   s.Tarih <= dtpTarihBitis.Value).ToList();

                WriteToScreen(result);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvFaturaListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                StaticPrimitives.SecilenFaturaId = (int)dgvFaturaListe.Rows[e.RowIndex].Cells["colFaturaId"].Value;
                _ciftTiklandiMi = true;
            }
            if (SecimIcin) this.Close();
        }

        private void FrmFaturaListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenFaturaId = 0;
        }
    }
}
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
        private readonly bool _secimIcin = false;

        private bool _ciftTiklandiMi = false;
        private List<Fatura> _faturalar;

        public FaturaTurleri FaturaTur { get; set; }

        public FrmFaturaListe(IFaturaService faturaService, ICariService cariService)
        {
            InitializeComponent();
            _faturaService = faturaService;
            _cariService = cariService;
            FaturaTur = FaturaTurleri.Hepsi;
            _secimIcin = (int)FaturaTur > 0;
            _faturalar = _faturaService.GetList().Data;
        }

        private void WriteToScreen(List<Fatura> faturalar)
        {
            dgvFaturaListe.DataSource = faturalar.Select(s => new
            {
                s.Id,
                s.No,
                FaturaTur = s.Tur,
                _cariService.GetById(s.CariId).Data.Unvan,
                s.Tarih
            }).ToList();
        }

        private void FrmFaturaListe_Load(object sender, EventArgs e)
        {
            dtpTarihBaslangic.Value = DateTime.Today.Add(new TimeSpan(-10, 0, 0, 0));
            cmbFaturaTur.SelectedIndex = (int)FaturaTur;
            if (_secimIcin) cmbFaturaTur.Enabled = false;

            WriteToScreen(_faturalar);

            FaturaListe_TextChanged(sender, e);
        }

        private void FaturaListe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string faturaTur = cmbFaturaTur.Text == "<<tümünü seç>>" ? "" : cmbFaturaTur.Text;
                var result = _faturalar.Where(s => s.No.ToLower().Contains(txtFaturaNo.Text.ToLower()) &&
                                                   s.Tur.ToLower().Contains(faturaTur.ToLower()) &&
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
            StaticPrimitives.SecilenFaturaId = e.RowIndex > -1 ? (int)dgvFaturaListe.SelectedRows[0].Cells["colFaturaId"].Value : 0;
            _ciftTiklandiMi = true;
            if (_secimIcin) this.Close();
        }

        private void FrmFaturaListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenFaturaId = 0;
        }
    }
}
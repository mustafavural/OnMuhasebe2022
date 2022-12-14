using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmPortfoydekiEvraklar : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;
        private readonly List<CekSenetMusteri> _portfoydekiEvraklar;
        public bool SecimIcin { get;set; }

        public FrmPortfoydekiEvraklar(ICekSenetBordroService cekSenetBordroService, ICekSenetMusteriService cekSenetMusteriService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cekSenetMusteriService = cekSenetMusteriService;
            _portfoydekiEvraklar = _cekSenetMusteriService.GetListPortfoydekiler().Data;
            SecimIcin = false;
        }

        private void FrmPortfoydekiEvraklar_Load(object sender, EventArgs e)
        {
            dtpVadeIlk.Value = DateTime.Today.AddDays(-10);
        }

        private void WriteToScreen(List<CekSenetMusteri> portfoydekiler)
        {
            try
            {
                dgvEvrakListe.DataSource = portfoydekiler.Select(s => new
                {
                    s.Id,
                    s.No,
                    _cekSenetBordroService.GetById(s.BordroTahsilatId).Data.Cari.Unvan,
                    s.AsilBorclu,
                    s.Vade,
                    s.Tutar,
                    s.Aciklama
                }).ToList();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _portfoydekiEvraklar.Where(s =>
                                                   s.No.ToLower().Contains(txtEvrakNo.Text.ToLower()) &&
                                                   _cekSenetBordroService.GetById(s.BordroTahsilatId).Data.Cari.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                                                   s.AsilBorclu.ToLower().Contains(txtAsilBorclu.Text.ToLower()) &&
                                                   txtTutarEnAz.Text.ToDecimal() <= s.Tutar &&
                                                   txtTutarEnCok.Text.ToDecimal(1) >= s.Tutar &&
                                                   dtpVadeIlk.Value <= s.Vade && s.Vade <= dtpVadeSon.Value &&
                                                   s.Aciklama.ToLower().Contains(txtAciklama.Text.ToLower())
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
                StaticPrimitives.SecilenMusteriEvrakId = (int)dgvEvrakListe.Rows[e.RowIndex].Cells["colId"].Value;
                this.Close();
            }
        }
    }
}
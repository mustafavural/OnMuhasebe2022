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

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmBordroListe : FrmBase
    {
        private readonly ICekSenetBordroService _bordroService;
        private List<CekSenetBordro> _bordrolar;

        public BordroTurleri BordroTur { get; set; }

        public bool SecimIcin => (int)BordroTur > 0;

        public FrmBordroListe(ICekSenetBordroService bordroService)
        {
            InitializeComponent();
            _bordroService = bordroService;
        }

        private void FrmBordroListe_Load(object sender, EventArgs e)
        {
            var tur = BordroTur.ToText();
            lblBordroTurler.Text = tur != "" ? tur : "Tümü";
            _bordrolar = _bordroService.GetList(f => f.Tur == tur || tur == "").Data;
            dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
        }

        private void WriteToScreen(List<CekSenetBordro> kiymetliEvrakBordrolar)
        {
            try
            {
                dgvBordroListe.DataSource = kiymetliEvrakBordrolar.Select(s => new
                {
                    s.Id,
                    s.No,
                    s.Tur,
                    s.Cari.Unvan,
                    Tutar = s.CekSenetBorclar.Sum(a => a.Tutar),
                    s.Tarih,
                    s.Aciklama
                }).ToList();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void BordroListe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _bordrolar.Where(s =>
                                                   s.No.ToLower().Contains(txtBordroNo.Text.ToLower()) &&
                                                   (s.Tur == BordroTur.ToText() || BordroTur.ToText() == "") &&
                                                   s.Cari.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                                                   txtTutarEnAz.Text.ToDecimal() <= (s.CekSenetMusteriler.Count != 0 ? s.CekSenetMusteriler.Sum(a => a.Tutar) : s.CekSenetBorclar.Sum(a => a.Tutar)) &&
                                                   txtTutarEnCok.Text.ToDecimal(1) >= (s.CekSenetMusteriler.Count != 0 ? s.CekSenetMusteriler.Sum(a => a.Tutar) : s.CekSenetBorclar.Sum(a => a.Tutar)) &&
                                                   dtpTarihIlk.Value <= s.Tarih && s.Tarih <= dtpTarihSon.Value
                                                   ).ToList();
                WriteToScreen(result);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DgvBordroListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && SecimIcin)
            {
                StaticPrimitives.SecilenBordroId = (int)dgvBordroListe.Rows[e.RowIndex].Cells["colBordroId"].Value;
                this.Close();
            }
        }
    }
}
using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Properties;

namespace WindowsFormUI.Views.Moduls.Kasalar
{
    public partial class FrmKasaListe : FrmBase
    {
        private IKasaHareketService _kasaHareketService;
        private ICariService _cariService;
        private bool _ciftTiklandiMi = false;
        private List<KasaHareket> _kasaHareketler;
        private List<Cari> _cariler;

        public bool SecimIcin { get; set; }

        public FrmKasaListe(ICariService cariService, IKasaHareketService kasaHareketService)
        {
            InitializeComponent();
            _cariService = cariService;
            SecimIcin = false;
            _kasaHareketler = _kasaHareketService.GetList().Data;
            _cariler = _cariService.GetList().Data;
            this.Icon = Resources.Kasa_Hareket32x321;
            this.Text = "Kasa Hareket Listesi";
            this.dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
            _kasaHareketService = kasaHareketService;
        }

        private void FrmKasaListe_Load(object sender, EventArgs e)
        {
            WriteToScreen(_kasaHareketler);
            txtEvrakNo.Focus();
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _kasaHareketler.Where(s =>
                    s.EvrakNo.ToLower().Contains(txtEvrakNo.Text.ToLower()) &&
                    _cariler.Where(c => c.Id == s.CariId).Select(c => c.Unvan).Single().ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
                    txtMiktarEnAz.Text.ToDecimal(0) <= s.GirenCikanMiktar &&
                    s.GirenCikanMiktar <= txtMiktarEnCok.Text.ToDecimal(1) &&
                    dtpTarihIlk.Value <= s.Tarih && s.Tarih <= dtpTarihSon.Value &&
                    s.Aciklama.ToLower().Contains(txtAciklama.Text.ToLower())
                    ).ToList();

                WriteToScreen(result);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void WriteToScreen(List<KasaHareket> result)
        {
            dgvEvrakListe.DataSource = result.Select(s => new
            {
                s.Id,
                s.KasaId,
                s.CariId,
                s.EvrakNo,
                s.GirenCikanMiktar,
                CariAd = _cariler.Where(c => c.Id == s.CariId).Select(c => c.Unvan).Single(),
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void DgvEvrakListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                StaticPrimitives.SecilenKasaHareketId = (int)dgvEvrakListe.SelectedRows[0].Cells["colId"].Value;
                _ciftTiklandiMi = true;
                if (SecimIcin) this.Close();
            }
        }

        private void FrmEvrakListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_ciftTiklandiMi)
                StaticPrimitives.SecilenKasaHareketId = 0;
        }
    }
}
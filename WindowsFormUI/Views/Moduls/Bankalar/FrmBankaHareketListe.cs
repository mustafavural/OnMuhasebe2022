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
using WindowsFormUI.Properties;

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public partial class FrmBankaHareketListe : FrmBase
    {
        private readonly IBankaHareketService _bankaHareketService;
        private readonly List<BankaHareket> _bankaHareketler;
        public BankaIslemTurleri BankaIslemTuru { get; set; }
        public bool SecimIcin => BankaIslemTuru > 0;

        public FrmBankaHareketListe(IBankaHareketService bankaHareketService)
        {
            InitializeComponent();
            _bankaHareketService = bankaHareketService;
            BankaIslemTuru = BankaIslemTurleri.Hepsi;
            this.Icon = Resources.Banka_Hareket32x321;
            _bankaHareketler = new();
            dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
        }

        private void FrmBankaListe_Load(object sender, EventArgs e)
        {
            try
            {
                _bankaHareketler.AddRange(_bankaHareketService.GetList().Data);
                if (SecimIcin)
                    this.Text = BankaIslemTuru == BankaIslemTurleri.Tahsilat ? "Banka Tahsilat Listesi" : "Banka Tediye Listesi";

                _TextChanged(sender, e);
                txtEvrakNo.Focus();
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

        private void _TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _bankaHareketler.Where(s =>
                    s.EvrakNo.ToLower().Contains(txtEvrakNo.Text.ToLower()) &&
                    s.CariHareket.Cari.Unvan.ToLower().Contains(txtCariUnvan.Text.ToLower()) &&
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

        private void WriteToScreen(List<BankaHareket> bankaHareketler)
        {
            dgvEvrakListe.DataSource = bankaHareketler.Select(s => new
            {
                s.Id,
                s.EvrakNo,
                s.CariHareket.Cari.Unvan,
                s.GirenCikanMiktar,
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void DgvEvrakListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && SecimIcin)
            {
                StaticPrimitives.SecilenBankaHareketId = (int)dgvEvrakListe.Rows[e.RowIndex].Cells["colId"].Value;
                this.Close();
            }
        }
    }
}
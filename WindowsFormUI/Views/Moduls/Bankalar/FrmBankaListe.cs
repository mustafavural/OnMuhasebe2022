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

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public partial class FrmBankaListe : FrmBase
    {
        private readonly IBankaHareketService _bankaHareketService;
        private readonly List<BankaHareket> _bankaHareketler;
        public BankaIslemTuru BankaIslemTuru { get; set; }
        public bool SecimIcin => BankaIslemTuru > 0;

        public FrmBankaListe(IBankaHareketService bankaHareketService)
        {
            InitializeComponent();
            _bankaHareketService = bankaHareketService;
            BankaIslemTuru = BankaIslemTuru.Hepsi;
            _bankaHareketler = _bankaHareketService.GetList().Data;
            this.Icon = Resources.Banka_Hareket32x321;
            dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
        }

        private void FrmBankaListe_Load(object sender, EventArgs e)
        {
            if (!SecimIcin)
                this.Text = "Banka Hareket Listesi";
            else
                this.Text = BankaIslemTuru == BankaIslemTuru.Tahsilat ? "Banka Tahsilat Listesi" : "Banka Tediye Listesi";

            _TextChanged(sender, e);
            txtEvrakNo.Focus();
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
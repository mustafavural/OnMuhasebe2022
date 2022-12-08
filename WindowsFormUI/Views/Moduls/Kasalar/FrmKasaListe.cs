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
        private readonly IKasaHareketService _kasaHareketService;
        private readonly List<KasaHareket> _kasaHareketler;
        public KasaIslemTuru KasaIslemTuru { get; set; }
        public bool SecimIcin => KasaIslemTuru > 0;

        public FrmKasaListe(IKasaHareketService kasaHareketService)
        {
            InitializeComponent();
            _kasaHareketService = kasaHareketService;
            KasaIslemTuru = KasaIslemTuru.Hepsi;
            _kasaHareketler = _kasaHareketService.GetList().Data;
            this.Icon = Resources.Kasa_Hareket32x321;
            dtpTarihIlk.Value = DateTime.Today.AddDays(-10);
        }

        private void FrmKasaListe_Load(object sender, EventArgs e)
        {
            if (!SecimIcin)
                this.Text = "Kasa Hareket Listesi";
            else
                this.Text = KasaIslemTuru == KasaIslemTuru.Tahsilat ? "Kasa Tahsilat Listesi" : "Kasa Tediye Listesi";

            _TextChanged(sender, e);
            txtEvrakNo.Focus();
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _kasaHareketler.Where(s =>
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

        private void WriteToScreen(List<KasaHareket> kasaHareketler)
        {
            dgvEvrakListe.DataSource = kasaHareketler.Select(s => new
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
                StaticPrimitives.SecilenKasaHareketId = (int)dgvEvrakListe.Rows[e.RowIndex].Cells["colId"].Value;
                this.Close();
            }
        }
    }
}
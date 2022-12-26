using Autofac;
using Core.Business.Abstract;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Companies
{
    public partial class FrmCompanyTransfer : FrmBase
    {
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;
        private Company _selectedCompany;
        private int _addedCompanyId;

        public FrmCompanyTransfer(ICompanyService companyService, IUserService userService)
        {
            InitializeComponent();
            _companyService = companyService;
            _userService = userService;
        }

        private void FrmCompanyTransfer_Load(object sender, EventArgs e)
        {
            cmbCompanyList.Items.Add("<<<Şirket Seçiniz>>>");
            var companyNameList = _companyService.GetList(s => s.Status).Data.Select(c => c.Name);
            cmbCompanyList.Items.AddRange(companyNameList.ToArray());

            cmbCompanyList.SelectedIndex = 0;

            txtNewName.Enabled = false;
            txtNewDetail.Enabled = false;
            txtNewYear.Enabled = false;

            btnEdit.Enabled = false;
            uscTansfer.BtnSave_Enable = false;
        }

        private void CmbCompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyList.SelectedIndex > 0)
            {
                _selectedCompany = _companyService.GetByName(cmbCompanyList.SelectedItem.ToString()).Data;
                txtNewYear.Text = (_selectedCompany.Year.ToInt() + 1).ToString();
                txtNewDetail.Text = _selectedCompany.Detail;
                txtNewName.Text = _selectedCompany.Name + txtNewYear.Text;

                btnEdit.Enabled = true;
                uscTansfer.BtnSave_Enable = true;
            }
        }

        private void CmbCompanyList_Leave(object sender, EventArgs e)
        {
            if (cmbCompanyList.SelectedIndex > 0)
            {
                cmbCompanyList.Enabled = false;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtNewYear.Enabled = true;
            txtNewName.Enabled = true;
            txtNewDetail.Enabled = true;

            btnEdit.Enabled = false;
        }

        private IResult AddCompanyToMasterDB()
        {
            Company company = new()
            {
                Id = 0,
                Name = txtNewName.Text,
                Status = true,
                Year = txtNewYear.Text,
                Detail = txtNewDetail.Text
            };

            var result = _companyService.Add(company);
            _addedCompanyId = company.Id;
            return result;
        }

        private void UscTransfer_Devret(object sender, EventArgs e)
        {
            var result = AddCompanyToMasterDB();
            if (result.IsSuccess)
            {
                var userList = _userService.GetListByCompanyId(_selectedCompany.Id);
                foreach (var item in userList.Data)
                    _companyService.AddUserToCompany(new UserCompany { UserId = item.Id, CompanyId = _addedCompanyId });

                var createDatabaseResult = CreateNewCompanyDatabase(txtNewName.Text);
                if (createDatabaseResult.IsSuccess)
                {
                    var transferResult = TransferCompanyToNewOne(_selectedCompany);
                    if (transferResult.IsSuccess)
                    {
                        MessageHelper.InformationMessageBuilder("Uygulama yeniden başlatılacaktır.", "Transfer Başarılı");
                        Application.Restart();
                    }
                }

            }
            else
                MessageHelper.ErrorMessageBuilder(result.Message, "Hata !!!");
        }

        private void UscTansfer_Vazgec(object sender, EventArgs e)
        {
            this.Close();
        }

        private IResult CreateNewCompanyDatabase(string newCompanyName)
        {
            try
            {
                DataAccess.Properties.Statics.DatabaseName = newCompanyName;
                using SIRKETLERContext context = new();
                context.Database.EnsureCreated();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            return new SuccessResult("Veritabanı başarıyla oluşturuldu.");
        }

        private IResult TransferCompanyToNewOne(Company selectedCompany)
        {
            List<Sehir> sehirler;
            List<Ilce> ilceler;
            List<CekSenetMusteri> portfoydekiEvraklar;
            
            List<CariHareket> cariHareketler;
            List<StokHareket> stokHareketler;
            List<BankaHareket> bankaHareketler;
            List<KasaHareket> kasaHareketler;

            DataAccess.Properties.Statics.DatabaseName = selectedCompany.Name;

            using (var source = new SIRKETLERContext())
            {
                string sqlCommand = $"BACKUP DATABASE [{selectedCompany.Name}] TO  DISK = N'D:\\dbbackup.bak' WITH NOFORMAT, NOINIT,  NAME = N'MyAir-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                source.Database.ExecuteSqlRaw(sqlCommand);

                string sqlRestoreCommand = $"RESTORE DATABASE [{txtNewName.Text}] FROM  DISK = N'D:\\dbbackup.bak' WITH  FILE = 1,  MOVE N'SIRKET' TO N'C:\\Users\\musta\\{txtNewName.Text}.mdf',  MOVE N'SIRKET_log' TO N'C:\\Users\\musta\\{txtNewName.Text}_log.ldf',  NOUNLOAD,  STATS = 5";
                source.Database.ExecuteSqlRaw(sqlRestoreCommand);


                sehirler = source.Sehirler.Select(s => new Sehir { Ad = s.Ad }).OrderBy(b => b.Ad).ToList();
                ilceler = source.Ilceler.Select(s => new Ilce { Ad = s.Ad, SehirId = s.SehirId }).ToList();
                portfoydekiEvraklar = source.CekSenetMusteriler.Where(s => s.BordroTediyeId < 1).ToList();

                cariHareketler = source.CariHareketler.GroupBy(g => g.CariId).Select(s =>
                new CariHareket
                {
                    CariId = s.Key,
                    Tutar = s.Sum(t => t.Tutar),
                    Tarih = DateTime.Today,
                    Aciklama = "<<devirden>>"
                }).ToList();

                stokHareketler = source.StokHareketler.GroupBy(g => g.StokId).Select(s =>
                new StokHareket
                {
                    StokId = s.Key,
                    Birim = source.Stoklar.Where(w => w.Id == s.Key).Select(b => b.Birim).Single(),
                    Fiyat = 0,
                    Kdv = 0,
                    FaturaId = 0,
                    BrutTutar = 0,
                    NetTutar = 0,
                    Miktar = s.Sum(t => t.Miktar),
                    Tarih = DateTime.Today,
                    Aciklama = "<<devirden>>"
                }).ToList();

                bankaHareketler = source.BankaHareketler.Include(i => i.CariHareket).GroupBy(g => g.BankaId).Select(s =>
                new BankaHareket
                {
                    BankaId = s.Key,
                    Aciklama = "<<devirden>>",
                    Tarih = DateTime.Today,
                    EvrakNo = "DEVIRDEN",
                    GirenCikanMiktar = s.Sum(t => t.GirenCikanMiktar)
                }).ToList();

                kasaHareketler = source.KasaHareketler.Include(i=>i.CariHareket).GroupBy(g => g.KasaId).Select(s =>
                new KasaHareket
                {
                    KasaId = s.Key,
                    Aciklama = "<<devirden>>",
                    Tarih = DateTime.Today,
                    EvrakNo = "DEVIRDEN",
                    GirenCikanMiktar = s.Sum(t => t.GirenCikanMiktar)
                }).ToList();
            }

            DataAccess.Properties.Statics.DatabaseName = txtNewName.Text;

            using (var target = new SIRKETLERContext())
            {


                target.Sehirler.AddRange(sehirler.ToArray());

                target.SaveChanges();

                target.Ilceler.AddRange(ilceler.ToArray());
                
                target.SaveChanges();

                target.CekSenetMusteriler.AddRange(portfoydekiEvraklar.ToArray());

                target.SaveChanges();

                target.CariHareketler.AddRange(cariHareketler.ToArray());
                target.StokHareketler.AddRange(stokHareketler.ToArray());
                target.KasaHareketler.AddRange(kasaHareketler.ToArray());
                target.BankaHareketler.AddRange(bankaHareketler.ToArray());
            }
            return new SuccessResult();
        }
    }
}
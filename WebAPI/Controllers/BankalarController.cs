using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankalarController : ControllerBase
    {
        private readonly IBankaService _bankaService;
        private readonly IBankaHareketService _bankaHareketService;

        public BankalarController(IBankaService bankaService, IBankaHareketService bankaHareketService)
        {
            _bankaService = bankaService;
            _bankaHareketService = bankaHareketService;
        }

        [HttpGet("GetHesapById")]
        public IActionResult GetHesapById(int hesapId)
        {
            var result = _bankaService.GetById(hesapId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapByHesapNo")]
        public IActionResult GetHesapByHesapNo(string hesapNo)
        {
            var result = _bankaService.GetByHesapNo(hesapNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapBakiye")]
        public IActionResult GetHesapBakiye(int hesapId)
        {
            var result = _bankaService.GetHesapBakiye(hesapId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapListByBankaAd")]
        public IActionResult GetHesapListByBankaAd(string hesapAd)
        {
            var result = _bankaService.GetListByBankaAd(hesapAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapListByBankaSubeAd")]
        public IActionResult GetHesapListByBankaSubeAd(string hesapAd)
        {
            var result = _bankaService.GetListByBankaSubeAd(hesapAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapList")]
        public IActionResult GetHesapList()
        {
            var result = _bankaService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("AddHesap")]
        public IActionResult AddHesap(Banka banka)
        {
            var result = _bankaService.Add(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteHesap")]
        public IActionResult DeleteHesap(Banka banka)
        {
            var result = _bankaService.Delete(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("UpdateHesap")]
        public IActionResult UpdateHesap(Banka banka)
        {
            var result = _bankaService.Update(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketById")]
        public IActionResult GetHareketById(int hareketId)
        {
            var result = _bankaHareketService.GetById(hareketId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketByEvrakNo")]
        public IActionResult GetHareketByEvrakNo(string evrakNo)
        {
            var result = _bankaHareketService.GetByEvrakNo(evrakNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketListByCariId")]
        public IActionResult GetHareketListByCariId(int cariId)
        {
            var result = _bankaHareketService.GetListByCariId(cariId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketListByBankaId")]
        public IActionResult GetHareketListByBankaId(int hesapId)
        {
            var result = _bankaHareketService.GetListByBankaHesapId(hesapId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketListBetweenFiyatlar")]
        public IActionResult GetHareketListBetweenFiyatlar(decimal[] minMax)
        {
            var result = _bankaHareketService.GetListBetweenFiyatlar(minMax[0], minMax[1]);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketListBetweenTarihler")]
        public IActionResult GetHareketListBetweenTarihler(DateTime[] minMax)
        {
            var result = _bankaHareketService.GetListBetweenTarihler(minMax[0], minMax[1]);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHareketList")]
        public IActionResult GetHareketList()
        {
            var result = _bankaHareketService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("AddHareket")]
        public IActionResult AddHesap(BankaHareket banka)
        {
            var result = _bankaHareketService.Add(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteHareket")]
        public IActionResult DeleteHesap(BankaHareket banka)
        {
            var result = _bankaHareketService.Delete(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("UpdateHareket")]
        public IActionResult UpdateHesap(BankaHareket banka)
        {
            var result = _bankaHareketService.Update(banka);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
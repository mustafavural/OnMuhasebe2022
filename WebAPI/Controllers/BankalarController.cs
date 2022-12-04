using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankalarController : ControllerBase
    {
        private readonly IBankaHesapService _bankaHesapService;
        private readonly IBankaHareketService _bankaHareketService;

        public BankalarController(IBankaHesapService bankaHesapService, IBankaHareketService bankaHareketService)
        {
            _bankaHesapService = bankaHesapService;
            _bankaHareketService = bankaHareketService;
        }

        [HttpGet("GetHesapById")]
        public IActionResult GetHesapById(int hesapId)
        {
            var result = _bankaHesapService.GetById(hesapId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapByHesapNo")]
        public IActionResult GetHesapByHesapNo(string hesapNo)
        {
            var result = _bankaHesapService.GetByHesapNo(hesapNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapBakiye")]
        public IActionResult GetHesapBakiye(int hesapId)
        {
            var result = _bankaHesapService.GetHesapBakiye(hesapId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapListByBankaAd")]
        public IActionResult GetHesapListByBankaAd(string hesapAd)
        {
            var result = _bankaHesapService.GetListByBankaAd(hesapAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapListByBankaSubeAd")]
        public IActionResult GetHesapListByBankaSubeAd(string hesapAd)
        {
            var result = _bankaHesapService.GetListByBankaSubeAd(hesapAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetHesapList")]
        public IActionResult GetHesapList()
        {
            var result = _bankaHesapService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("AddHesap")]
        public IActionResult AddHesap(BankaHesap bankaHesap)
        {
            var result = _bankaHesapService.Add(bankaHesap);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteHesap")]
        public IActionResult DeleteHesap(BankaHesap bankaHesap)
        {
            var result = _bankaHesapService.Delete(bankaHesap);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("UpdateHesap")]
        public IActionResult UpdateHesap(BankaHesap bankaHesap)
        {
            var result = _bankaHesapService.Update(bankaHesap);
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
        [HttpGet("GetHareketListByBankaHesapId")]
        public IActionResult GetHareketListByBankaHesapId(int hesapId)
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
        public IActionResult AddHesap(BankaHareket bankaHesap)
        {
            var result = _bankaHareketService.Add(bankaHesap);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteHareket")]
        public IActionResult DeleteHesap(BankaHareket bankaHesap)
        {
            var result = _bankaHareketService.Delete(bankaHesap);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("UpdateHareket")]
        public IActionResult UpdateHesap(BankaHareket bankaHesap)
        {
            var result = _bankaHareketService.Update(bankaHesap);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
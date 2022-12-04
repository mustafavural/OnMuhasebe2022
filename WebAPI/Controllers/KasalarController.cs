using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KasalarController : ControllerBase
    {
        private readonly IKasaService _kasaService;
        private readonly IKasaHareketService _kasaHareketService;

        public KasalarController(IKasaService kasaService, IKasaHareketService kasaHareketService)
        {
            _kasaService = kasaService;
            _kasaHareketService = kasaHareketService;
        }

        [HttpGet("GetKasaById")]
        public IActionResult GetKasaById(int kasaId)
        {
            var result = _kasaService.GetById(kasaId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetKasaByAd")]
        public IActionResult GetKasaByAd(string kasaAd)
        {
            var result = _kasaService.GetByAd(kasaAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetKasaList")]
        public IActionResult GetKasaList()
        {
            var result = _kasaService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("AddKasa")]
        public IActionResult AddKasa(Kasa kasa)
        {
            var result = _kasaService.Add(kasa);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("DeleteKasa")]
        public IActionResult DeleteKasa(Kasa kasa)
        {
            var result = _kasaService.Delete(kasa);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("UpdateKasa")]
        public IActionResult UpdateKasa(Kasa kasa)
        {
            var result = _kasaService.Update(kasa);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int hareketId)
        {
            var result = _kasaHareketService.GetById(hareketId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetByEvrakNo")]
        public IActionResult GetByEvrakNo(string evrakNo)
        {
            var result = _kasaHareketService.GetByEvrakNo(evrakNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByCariId")]
        public IActionResult GetListByCariId(int cariId)
        {
            var result = _kasaHareketService.GetListByCariId(cariId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByKasaId")]
        public IActionResult GetListByKasaId(int cariId)
        {
            var result = _kasaHareketService.GetListByKasaId(cariId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListBetweenTarihler")]
        public IActionResult GetListBetweenTarihler(DateTime first, DateTime last)
        {
            var result = _kasaHareketService.GetListBetweenTarihler(first, last);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListBetweenFiyatlar")]
        public IActionResult GetListBetweenFiyatlar(int min, int max)
        {
            var result = _kasaHareketService.GetListBetweenFiyatlar(min, max);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _kasaHareketService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetKasaBakiye")]
        public IActionResult GetKasaBakiye(int kasaId)
        {
            var result = _kasaHareketService.GetKasaBakiye(kasaId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(KasaHareket kasaHareket)
        {
            var result = _kasaHareketService.Add(kasaHareket);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(KasaHareket kasaHareket)
        {
            var result = _kasaHareketService.Delete(kasaHareket);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(KasaHareket kasaHareket)
        {
            var result = _kasaHareketService.Update(kasaHareket);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }
    }
}
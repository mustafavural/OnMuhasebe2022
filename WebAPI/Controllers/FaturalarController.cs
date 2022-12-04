using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaturalarController : ControllerBase
    {
        private readonly IFaturaService _faturaService;

        public FaturalarController(IFaturaService faturaService)
        {
            _faturaService = faturaService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int faturaId)
        {
            var result = _faturaService.GetById(faturaId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetByNo")]
        public IActionResult GetByNo(string faturaNo)
        {
            var result = _faturaService.GetByNo(faturaNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByTur")]
        public IActionResult GetListByTur(string faturaTur)
        {
            var result = _faturaService.GetListByTur(faturaTur);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByCariKod")]
        public IActionResult GetListByCariKod(string cariKod)
        {
            var result = _faturaService.GetListByCariKod(cariKod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListBetweenTarihler")]
        public IActionResult GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            var result = _faturaService.GetListBetweenTarihler(ilk, son);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListBetweenKayitTarihler")]
        public IActionResult GetListBetweenKayitTarihler(DateTime ilk, DateTime son)
        {
            var result = _faturaService.GetListBetweenKayitTarihler(ilk, son);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _faturaService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetFaturaKalemler")]
        public IActionResult GetFaturaKalemler(string faturaNo)
        {
            var result = _faturaService.GetFaturaKalemler(faturaNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetFaturaKdvler")]
        public IActionResult GetFaturaKdvler(string faturaNo)
        {
            var result = _faturaService.GetFaturaKdvler(faturaNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetBrutToplam")]
        public IActionResult GetBrutToplam(string faturaNo)
        {
            var result = _faturaService.GetBrutToplam(faturaNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetNetToplam")]
        public IActionResult GetNetToplam(string faturaNo)
        {
            var result = _faturaService.GetNetToplam(faturaNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Fatura fatura)
        {
            var result = _faturaService.Add(fatura);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Fatura fatura)
        {
            var result = _faturaService.Delete(fatura);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(Fatura fatura)
        {
            var result = _faturaService.Update(fatura);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Message);
        }
    }
}
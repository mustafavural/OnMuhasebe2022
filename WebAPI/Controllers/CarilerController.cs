using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarilerController : ControllerBase
    {
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;

        public CarilerController(ICariService cariService, ICariHareketService cariHareketService)
        {
            _cariService = cariService;
            _cariHareketService = cariHareketService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int cariId)
        {
            var result = _cariService.GetById(cariId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByKod")]
        public IActionResult GetByKod(string cariKod)
        {
            var result = _cariService.GetByKod(cariKod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByVergiNo")]
        public IActionResult GetByVergiNo(string vergiNo)
        {
            var result = _cariService.GetByVergiNo(vergiNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetCariBakiye")]
        public IActionResult GetCariBakiye(string kod)
        {
            var result = _cariHareketService.GetCariBakiye(kod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetCariGrup")]
        public IActionResult GetCariGrup(int cariId, int categoryId)
        {
            var result = _cariService.GetCariGrup(cariId, categoryId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByTelNo")]
        public IActionResult GetByTelNo(string telNo)
        {
            var result = _cariService.GetByTelNo(telNo);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByWeb")]
        public IActionResult GetByWeb(string webUrl)
        {
            var result = _cariService.GetByWeb(webUrl);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByEposta")]
        public IActionResult GetByEposta(string eposta)
        {
            var result = _cariService.GetByEposta(eposta);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetListByIlce")]
        public IActionResult GetListByIlce(string ilceAd)
        {
            var result = _cariService.GetListByIlce(ilceAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetListBySehir")]
        public IActionResult GetListBySehir(string sehirAd)
        {
            var result = _cariService.GetListBySehir(sehirAd);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _cariService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("AddCategoryToCari")]
        public IActionResult AddCategoryToCari(CariGrup cariGrup)
        {
            var result = _cariService.AddCategoryToCari(cariGrup);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteCategoryFromCari")]
        public IActionResult DeleteCategoryFromCari(CariGrup cariGrup)
        {
            var result = _cariService.DeleteCategoryFromCari(cariGrup);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Add")]
        public IActionResult Add(Cari cari)
        {
            var result = _cariService.Add(cari);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int cariId)
        {
            var result = _cariService.Delete(new Cari { Id = cariId });
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public IActionResult Update(Cari cari)
        {
            var result = _cariService.Update(cari);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
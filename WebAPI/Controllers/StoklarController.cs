using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoklarController : ControllerBase
    {
        private readonly IStokService _stokService;
        private readonly IStokHareketService _stokHareketService;
        public StoklarController(IStokService stokService, IStokHareketService stokHareketService)
        {
            _stokService = stokService;
            _stokHareketService = stokHareketService;
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int stokId)
        {
            var result = _stokService.GetById(stokId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByKod")]
        public IActionResult GetByKod(string stokKod)
        {
            var result = _stokService.GetByKod(stokKod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetStokBakiye")]
        public IActionResult GetStokBakiye(string stokKod)
        {
            var result = _stokHareketService.GetStokBakiye(stokKod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetStokGrup")]
        public IActionResult GetStokGrup(int stokId, int categoryId)
        {
            var result = _stokService.GetStokGrup(stokId, categoryId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _stokService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("AddCategoryToStok")]
        public IActionResult AddCategoryToStok(StokGrup stokGrup)
        {
            var result = _stokService.AddCategoryToStok(stokGrup);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("DeleteCategoryFromStok")]
        public IActionResult DeleteCategoryFromStok(int stokId, int stokCategoryId)
        {
            var stokGrup = _stokService.GetStokGrup(stokId, stokCategoryId).Data;
            var result = _stokService.DeleteCategoryFromStok(stokGrup);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Add")]
        public IActionResult Add(Stok stok)
        {
            var result = _stokService.Add(stok);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Stok stok)
        {
            var result = _stokService.Delete(stok);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public IActionResult Update(Stok stok)
        {
            var result = _stokService.Update(stok);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
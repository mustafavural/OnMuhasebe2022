using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegerliEvraklarController : ControllerBase
    {
        IDegerliEvrakService _degerliEvrakService;

        public DegerliEvraklarController(IDegerliEvrakService degerliEvrakService)
        {
            _degerliEvrakService = degerliEvrakService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _degerliEvrakService.GetById(id);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByKod")]
        public IActionResult GetByKod(string kod)
        {
            var result = _degerliEvrakService.GetByKod(kod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByVerilenCariId")]
        public IActionResult GetListByVerilenCariId(int id)
        {
            var result = _degerliEvrakService.GetListByVerilenCariId(id);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByVade")]
        public IActionResult GetListByVade(DateTime vade)
        {
            var result = _degerliEvrakService.GetListByVade(vade);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByCikisTarihi")]
        public IActionResult GetListByCikisTarihi(DateTime tarih)
        {
            var result = _degerliEvrakService.GetListByCikisTarihi(tarih);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _degerliEvrakService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(DegerliEvrak degerliEvrak)
        {
            var result = _degerliEvrakService.Add(degerliEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(DegerliEvrak degerliEvrak)
        {
            var result = _degerliEvrakService.Delete(degerliEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(DegerliEvrak degerliEvrak)
        {
            var result = _degerliEvrakService.Update(degerliEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
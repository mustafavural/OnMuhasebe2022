using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriEvraklarController : ControllerBase
    {
        IMusteriEvrakService _musteriEvrakService;

        public MusteriEvraklarController(IMusteriEvrakService musteriEvrakService)
        {
            _musteriEvrakService = musteriEvrakService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _musteriEvrakService.GetById(id);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetByKod")]
        public IActionResult GetByKod(string kod)
        {
            var result = _musteriEvrakService.GetByKod(kod);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByAlinanCariId")]
        public IActionResult GetListByAlinanCariId(int id)
        {
            var result = _musteriEvrakService.GetListByAlinanCariId(id);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByVerilenCariId")]
        public IActionResult GetListByVerilenCariId(int id)
        {
            var result = _musteriEvrakService.GetListByVerilenCariId(id);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByAsilBorclu")]
        public IActionResult GetListByAsilBorclu(string name)
        {
            var result = _musteriEvrakService.GetListByAsilBorclu(name);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByVade")]
        public IActionResult GetListByVade(DateTime vade)
        {
            var result = _musteriEvrakService.GetListByVade(vade);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByAlisTarihi")]
        public IActionResult GetListByAlisTarihi(DateTime tarih)
        {
            var result = _musteriEvrakService.GetListByAlisTarihi(tarih);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetListByCikisTarihi")]
        public IActionResult GetListByCikisTarihi(DateTime tarih)
        {
            var result = _musteriEvrakService.GetListByCikisTarihi(tarih);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _musteriEvrakService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(MusteriEvrak musteriEvrak)
        {
            var result = _musteriEvrakService.Add(musteriEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(MusteriEvrak musteriEvrak)
        {
            var result = _musteriEvrakService.Delete(musteriEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(MusteriEvrak musteriEvrak)
        {
            var result = _musteriEvrakService.Update(musteriEvrak);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}

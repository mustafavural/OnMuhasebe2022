using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StokCategorylerController : ControllerBase
    {
        IStokCategoryService _stokCategoryService;
        public StokCategorylerController(IStokCategoryService stokCategoryService)
        {
            _stokCategoryService = stokCategoryService;
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int categoryId)
        {
            var result = _stokCategoryService.GetById(categoryId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _stokCategoryService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("Add")]
        public IActionResult Add(StokCategory stokCategory)
        {
            var result = _stokCategoryService.Add(stokCategory);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(StokCategory stokCategory)
        {
            var result = _stokCategoryService.Delete(stokCategory);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public IActionResult Update(StokCategory stokCategory)
        {
            var result = _stokCategoryService.Update(stokCategory);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}
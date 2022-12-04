using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CariCategorylerController : ControllerBase
    {
        ICariCategoryService _cariCategoryService;

        public CariCategorylerController(ICariCategoryService cariCategoryService)
        {
            _cariCategoryService = cariCategoryService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int categoryId)
        {
            var result = _cariCategoryService.GetById(categoryId);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _cariCategoryService.GetList();
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
        [HttpPost("Add")]
        public IActionResult Add(CariCategory cariCategory)
        {
            var result = _cariCategoryService.Add(cariCategory);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int categoryId)
        {
            var result = _cariCategoryService.Delete(new CariCategory { Id = categoryId });
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public IActionResult Update(CariCategory cariCategory)
        {
            var result = _cariCategoryService.Update(cariCategory);
            return result.IsSuccess ? Ok(result.Message) : BadRequest(result.Message);
        }
    }
}

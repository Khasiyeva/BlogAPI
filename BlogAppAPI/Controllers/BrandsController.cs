using BlogApp.Business.DTOs.BrandDtos;
using BlogApp.Business.Services.Interfaces;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandsController(IBrandService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands =await _service.GetAllAsync();
            return Ok(brands);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateBrandDto brand)
        {
            await _service.Create(brand);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}

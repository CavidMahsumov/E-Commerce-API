using E_CommerceAPI.Application.Repositories;
using E_CommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task  Get()
        {
          //await  _productWriteRepository.AddRangeAsync(new()
          //  {
          //      new(){ Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
          //      new(){ Id=Guid.NewGuid(),Name="Product2",Price=200,CreatedDate=DateTime.UtcNow,Stock=60},
          //      new(){ Id=Guid.NewGuid(),Name="Product3",Price=300,CreatedDate=DateTime.UtcNow,Stock=20},
          //  });
          //  await _productWriteRepository.SaveAsync();

           Product product= await _productReadRepository.GetByIdAsync("52007e9b-aee1-4834-b63e-277a10331e69")
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
           Product product= await _productReadRepository.GetByIdAsync(id);
            return Ok(product);

        }


    }
}

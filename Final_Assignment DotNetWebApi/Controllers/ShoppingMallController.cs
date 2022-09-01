using AutoMapper;
using Database_Connection.Entities;
using DatabaseLibrary;
using Final_Assignment_DotNetWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Assignment_DotNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingMallController : ControllerBase
    {
        private readonly DbContextShoppingMall _contextShoppingMall;
        private readonly IMapper _mapper;

        public ShoppingMallController(DbContextShoppingMall contextShoppingMall, IMapper mapper)
        {
            _contextShoppingMall = contextShoppingMall;
            _mapper = mapper;
        }
        [HttpGet]

        public async Task<IActionResult> GetDetails()
        {
            if (_contextShoppingMall.ShoppingMallDetails == null)
            {
                return NoContent();
            }
            var details = await _contextShoppingMall.ShoppingMallDetails.ToListAsync();
            return Ok(details);
        }
        [HttpPost]

        public async Task<IActionResult> PostShoppingMallDetails(ShoppingMallModel shoppingMallModel)
        {
            if (shoppingMallModel == null)
            {
                return BadRequest();
            }
            var details = _mapper.Map<ShoppingMallDetails>(shoppingMallModel);
            if (_contextShoppingMall.ShoppingMallDetails == null)
            {
                return NoContent();
            }
            _contextShoppingMall.ShoppingMallDetails.Add(details);
           
            await _contextShoppingMall.SaveChangesAsync();
            return Ok(_contextShoppingMall.ShoppingMallDetails);
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> PutDetailsById(int id, ShoppingMallModel shoppingMallModel)
        {
            if (shoppingMallModel == null)
            {
                return BadRequest();
            }
            if (_contextShoppingMall.ShoppingMallDetails == null)
            {
                return NoContent();
            }
            var detailsInDatabase = await _contextShoppingMall.ShoppingMallDetails.FindAsync(id);
            if (detailsInDatabase == null)
            {
                return NotFound();
            }
            _mapper.Map(shoppingMallModel, detailsInDatabase);
            detailsInDatabase.Id = id;
            _contextShoppingMall.ShoppingMallDetails.Update(detailsInDatabase);
            await _contextShoppingMall.SaveChangesAsync();
            return Ok(_contextShoppingMall.ShoppingMallDetails);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            if (_contextShoppingMall.ShoppingMallDetails == null)
            {
                return NoContent();
            }
            var details = await _contextShoppingMall.ShoppingMallDetails.FindAsync(id);
            if (details == null)
            {
                return NotFound();
            }
            _contextShoppingMall.ShoppingMallDetails.Remove(details);
            _contextShoppingMall.SaveChanges();
            return Ok(_contextShoppingMall.ShoppingMallDetails);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (_contextShoppingMall.ShoppingMallDetails == null)
            {
                return NoContent();
            }
            var details = await _contextShoppingMall.ShoppingMallDetails.FindAsync(id);
            if (details == null)
            {
                return NotFound();
            }
            return Ok(details);
        }


    }
}

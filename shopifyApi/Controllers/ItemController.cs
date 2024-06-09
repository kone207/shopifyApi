using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopifyApi.Data;
using shopifyApi.Models;
using shopifyApi.Services;

namespace shopifyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<ItemPayload>> GetItems()
        {
            var results = _itemService.GetItems();
            if(results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var results = await _itemService.GetItem(id);
            if(results == null)
            {
                return NotFound();
            }
            return Ok(results);
        }
    }
}

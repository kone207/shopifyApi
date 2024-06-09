using shopifyApi.Data;
using shopifyApi.Models;
using shopifyApi.Services.Interfaces;

namespace shopifyApi.Services
{
    public class ItemService: IitemService
    {
        private readonly ShopifyDbContext _shopifyDbContext;

        public ItemService(ShopifyDbContext shopifyDbContext)
        {
            _shopifyDbContext = shopifyDbContext;
        }

        public async Task<ItemPayload> GetItems()
        {
            int count = _shopifyDbContext.Items.Count();
            List<Item> list = _shopifyDbContext.Items.ToList();

            return new ItemPayload(list, count);
        }

        public async Task<Item> GetItem(int id)
        {
            var item = await _shopifyDbContext.Items.FindAsync(id);
            if (item == null)
            {
                return null;
            }
            return item;
        }

    }
}

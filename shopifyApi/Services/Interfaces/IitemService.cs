using shopifyApi.Models;

namespace shopifyApi.Services.Interfaces
{
    public interface IitemService
    {
        Task<ItemPayload> GetItems();
        Task<Item> GetItem(int id);
    }
}

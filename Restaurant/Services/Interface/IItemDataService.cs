using System.Data;

namespace Restaurant.Models.Services.Interface
{
    public interface IItemDataService
    {
        void Add(Item item);
        void Update(Item item);
        DataTable Get();
        DataTable GetById(string id);
        void Delete(string id);
    }
}

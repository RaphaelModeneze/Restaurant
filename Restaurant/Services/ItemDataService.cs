using DAL;
using Restaurant.Models.Services.Interface;
using System;
using System.Data;

namespace Restaurant.Models.Services
{
    internal class ItemDataService : IItemDataService
    {
        private DalHelper _dataContext { get; set; }

        public ItemDataService(DalHelper dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Item item)
        {
            _dataContext.Add(item.Name, item.Price, item.Active);
        }

        public void Update(Item item)
        {
            _dataContext.Update(item.ID, item.Name, item.Price, item.Active);
        }

        DataTable IItemDataService.Get()
        {
            return _dataContext.GetAllItems();
        }

        DataTable IItemDataService.GetById(string id)
        {
            return _dataContext.GetItem(id);
        }

        public void Delete(string id)
        {
            try
            {
                _dataContext.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover:" + e.Message);
            }
        }

    }
}

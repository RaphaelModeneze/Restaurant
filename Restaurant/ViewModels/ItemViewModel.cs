using Restaurant.Models.Services.Interface;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    public class ItemViewModel
    {
        private ICommand saveItemCommand;

        public IItemDataService ItemRepository { get; }


        public ItemViewModel(IItemDataService itemRepository)
        {
            ItemRepository = itemRepository;
        }

        public ICommand SaveItemCommand
        {
            get
            {
                ItemRepository.Add(new Models.Item());

                return saveItemCommand;
            }
        }

    }
}

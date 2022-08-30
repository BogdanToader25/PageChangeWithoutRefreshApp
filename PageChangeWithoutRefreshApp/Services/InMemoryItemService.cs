using PageChangeWithoutRefreshApp.Models;
using PageChangeWithoutRefreshApp.Repositories;

namespace PageChangeWithoutRefreshApp.Services
{
    public class InMemoryItemService : IItemService
    {

        private readonly IItemRepository _itemRepository;

        public InMemoryItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<MyItem> GetAllItems()
        {
            return _itemRepository.GetItems();
        }

        public MyItem GetAnItem()
        {
            return _itemRepository.GetItem();
        }

        public List<MyItem> GetItemsWithProperty3AboveValue(int value)
        {
            return _itemRepository.GetItems().Where(x=>x.MyProperty3 > value).ToList();
        }
    }
}

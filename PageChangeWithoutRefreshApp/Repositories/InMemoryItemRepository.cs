using PageChangeWithoutRefreshApp.Data;
using PageChangeWithoutRefreshApp.Models;

namespace PageChangeWithoutRefreshApp.Repositories
{
    public class InMemoryItemRepository : IItemRepository
    {
        public MyItem GetItem()
        {
            return ItemStorage.GetAllItems().FirstOrDefault();
        }

        public List<MyItem> GetItems()
        {
            return ItemStorage.GetAllItems();
        }
    }
}

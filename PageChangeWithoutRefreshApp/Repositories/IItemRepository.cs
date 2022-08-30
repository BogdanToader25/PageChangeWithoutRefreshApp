using PageChangeWithoutRefreshApp.Models;

namespace PageChangeWithoutRefreshApp.Repositories
{
    public interface IItemRepository
    {
        MyItem GetItem();
        List<MyItem> GetItems();
    }
}

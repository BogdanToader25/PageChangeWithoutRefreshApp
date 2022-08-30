using PageChangeWithoutRefreshApp.Models;

namespace PageChangeWithoutRefreshApp.Services
{
    public interface IItemService
    {
        MyItem GetAnItem();
        List<MyItem> GetAllItems();
        List<MyItem> GetItemsWithProperty3AboveValue(int value);

    }
}

using PageChangeWithoutRefreshApp.Models;

namespace PageChangeWithoutRefreshApp.Data
{
    public class ItemStorage
    {
        private static List<MyItem> _itemStorage = new List<MyItem>() { new MyItem("prop1value1","prop2value1", 1), new MyItem("prop1value2", "prop2value2", 2), new MyItem("prop1value3", "prop2value3", 3) };

       public static List<MyItem> GetAllItems()
        {
            return _itemStorage;
        }
    }
}

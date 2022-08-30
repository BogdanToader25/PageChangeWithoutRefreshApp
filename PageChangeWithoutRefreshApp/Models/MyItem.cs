namespace PageChangeWithoutRefreshApp.Models
{
    public class MyItem
    {
        public MyItem(string myProperty1, string myProperty2, int myProperty3)
        {
            MyProperty1 = myProperty1;
            MyProperty2 = myProperty2;
            MyProperty3 = myProperty3;
        }

        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }
}

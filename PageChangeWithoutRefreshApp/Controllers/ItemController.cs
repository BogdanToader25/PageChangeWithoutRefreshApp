using Microsoft.AspNetCore.Mvc;
using PageChangeWithoutRefreshApp.Services;

namespace PageChangeWithoutRefreshApp.Controllers
{
    public class ItemController : Controller
    {
        private IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var model = _itemService.GetAllItems();
            return View(model);
        }

        [HttpGet]
        [Route("Item/GetFilteredItems/{value}")]
        public PartialViewResult GetFilteredItems(int value)
        {
            var model = _itemService.GetItemsWithProperty3AboveValue(value);
            return PartialView("FilteredItems", model);
        }
    }
}

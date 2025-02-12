using ASPDotNet_Core_MVC_Tuto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNet_Core_MVC_Tuto.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
    }
}

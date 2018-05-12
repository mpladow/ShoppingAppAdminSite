using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore_ADMIN.Entities;
using OnlineStore_ADMIN.ViewModels;

namespace OnlineStore_ADMIN.Controllers
{
    public class InventoryController : Controller
    {
        OrderingSystemEntities1 os = new OrderingSystemEntities1();
        // GET: Inventory
        public ActionResult Index()
        {
            var inventory = os.Products
                .Where(x => x.DeletedAt == null)
                .ToList();
            return View(inventory);
        }
        public ActionResult Edit(int id)
        {
            var productInDb = os.Products
                .FirstOrDefault(x => x.OrderID == id);
            if (productInDb == null)
            {
                return HttpNotFound();
            }
            else
            {
                InventoryVM vm = new InventoryVM()
                {

                }
                return View(productInDb);
            }
        }
    }
}
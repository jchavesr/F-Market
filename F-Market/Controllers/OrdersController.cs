using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using F_Market.Models;
using F_Market.ViewModels;

namespace F_Market.Controllers
{
    public class OrdersController : Controller
    {
        F_MarketContext db = new F_MarketContext();
        // GET: Orders
        public ActionResult NewOrder()
        {
            var orderView = new OrderView
            {
                Customer = new Customer(),
                Products = new List<ProductOrder>()
            };
            //
            77

            //var list = db.Customers.ToList();
            //list.Add(new Customer { CustomerId = 0, FullName = "[Seleccione un cliente.]" });
            //list = list.OrderBy(c => c.FullName).ToList();
            //ViewBag.DocumentTypeId = new SelectList(list, "DocumentTypeId", "Description");

            var list = db.Customers.ToList();
            //list.Add(new Customer { CustomerId = 0, FullName = "[Seleccione un cliente.]" });
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");

            return View(orderView);
        }

        [HttpPost]
        public ActionResult NewOrder(OrderView orderView)
        {
            var list = db.Customers.ToList();
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");

            return View(orderView);
        }

        public ActionResult AddProduct(ProductOrder productOrder)
        {
            return View(productOrder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
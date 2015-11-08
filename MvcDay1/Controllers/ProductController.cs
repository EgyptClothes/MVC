using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDay1.Models;

namespace MvcDay1.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public static List<Product> _products = new List<Product>()
        {
            new Product(){Id = 1, Name = "Nokia", Price = 120},
            new Product(){Id = 2, Name = "Alcatel", Price = 450},
            new Product(){Id = 3, Name = "Samsung", Price = 1200}
        }; 
        public ActionResult Index()
        {
            return View(_products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int Id, string Name, double Price)
        {
            Product pro = new Product() {Id = Id, Name = Name, Price = Price};
            _products.Add(pro);
            return RedirectToAction("Index");
        }

    }
}

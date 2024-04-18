﻿using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly DatabaseContext db;
        public PurchaseController(DatabaseContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart() 
        {
            return View();
        }

        public IActionResult ViewCart()
        {
            return View();
        }

        public IActionResult PastPurchase()
        {
            ISession session = HttpContext.Session;
            string? userId = session.GetString("userId");
            if(userId != null)
            {
                var purchases = db.GetPastPurchase2(userId);








                return View(purchases);
            }
            return View();
        }
      
    }
}

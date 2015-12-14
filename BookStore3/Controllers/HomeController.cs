using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore3.Models;

namespace BookStore3.Controllers
{
    public class HomeController : Controller
    {
        public IRepository repo;

        public HomeController(IRepository r)
        {
            repo = r;
        }
        public HomeController()
        {
            repo = new BookRepository();
        }
        
        public ActionResult Index2()
        {
            return View(db.Books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        // создаем контекст данных
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var model = repo.GetBookList();
            //if (model.Count > 0)
            //    ViewBag.Message = String.Format("В базе данных {0} объект", model.Count);
            //return View(model);
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
        public string Square(int a, int h)
        {
            double s = a * h / 2;
            return "<h2>Площадь треугольника с основанием " + a +
                    " и высотой " + h + " равна " + s + "</h2>";
        }
    }
}
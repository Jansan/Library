using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            var book = new Book()
            {
                Name = "This is book"
            };
            return View(book);
        }
    }
}
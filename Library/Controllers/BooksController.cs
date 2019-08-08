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
            var books = GetBooks();
            return View(books);
        }
        public ActionResult Random()
        {
           


            return View();
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
               new Book {Id = 1, Name = "Karn"},
               new Book {Id = 2, Name = "Lalla"}
            };
        }
    }
}
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Books
        public ActionResult Index()
        {
            var books = _context.Books.Include(b => b.Genre).ToList();
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
        //private IEnumerable<Book> GetBooks()
        //{
        //    return new List<Book>
        //    {
        //       new Book {Id = 1, Name = "Karn"},
        //       new Book {Id = 2, Name = "Lalla"}
        //    };
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourBook.Models;
using YourBook.ViewModels;
using System.Data.Entity;

namespace YourBook.Controllers
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

        public ViewResult Index()
        {
            var books = _context.Books.Include(m => m.Genre).ToList();

            return View(books);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Books.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        }

    }

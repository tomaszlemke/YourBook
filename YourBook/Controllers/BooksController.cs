﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using YourBook.Models;
using YourBook.ViewModels;
using System.Net;

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
            /*if (User.IsInRole(RoleName.CanManageBooks))
                return View("List");*/

            return View(_context.Books);
        }


        //  [Authorize(Roles = RoleName.CanManageBooks)]
        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new BookFormViewModel
            {
                Genres = genres
            };

            return View("BookForm", viewModel);
        }

        // [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel(book)
            {
                Genres = _context.Genres.ToList()
            };

            return View("BookForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (book == null)
                return HttpNotFound();

            return View(book);
        }


        // GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);
        }

        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                book.DateAdded = DateTime.Now;
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(m => m.Id == book.Id);
                bookInDb.Name = book.Name;
                bookInDb.GenreId = book.GenreId;
                bookInDb.NumberInStock = book.NumberInStock;
                bookInDb.ReleaseDate = book.ReleaseDate;
                bookInDb.Author = book.Author;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        // GET: Gras/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = _context.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Gras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
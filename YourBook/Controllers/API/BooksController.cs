using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using YourBook.Dtos;
using System.Data.Entity;
using YourBook.Models;

namespace YourBook.Controllers.Api
{
    public class BooksController : ApiController
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        
        public IEnumerable<BookDto> GetBooks()
        {
            return _context.Books
               .Include(m => m.Genre)
               .ToList()
               .Select(Mapper.Map<Book, BookDto>);
        }
     
        public IHttpActionResult GetBook(int id)
        {
            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (book == null)
                return NotFound();

            return Ok(Mapper.Map<Book, BookDto>(book));
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult CreateBook(BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var book = Mapper.Map<BookDto, Book>(bookDto);
            _context.Books.Add(book);
            _context.SaveChanges();

            bookDto.Id = book.Id;
            return Created(new Uri(Request.RequestUri + "/" + book.Id), bookDto);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult UpdateBook(int id, BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var bookInDb = _context.Books.SingleOrDefault(c => c.Id == id);

            if (bookInDb == null)
                return NotFound();

            Mapper.Map(bookDto, bookInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult DeleteBook(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(c => c.Id == id);

            if (bookInDb == null)
                return NotFound();

            _context.Books.Remove(bookInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}


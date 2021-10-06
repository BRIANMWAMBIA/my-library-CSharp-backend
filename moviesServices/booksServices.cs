using moviesData;
using moviesData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesServices
{
    public class booksServices : IBook
    {
        private LibraryContext _context;
        public booksServices (LibraryContext context)
        {
            _context = context;
        }
        public void AddNew(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();

        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }

        public Book GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(asset => asset.Id == id);
        }

        public Book GetByTitle(string title)
        {
          return  GetAll()
                 .FirstOrDefault(asset => asset.Title == title);
        }

        public string GetType(int id)
        {
         return  GetAll()
                .FirstOrDefault(asset => asset.Id == id).Type;
        }

        public string GetTitle(int id)
        {
            return GetAll()
                 .FirstOrDefault(asset => asset.Id == id).Title;
        }

        public void Update(int id, Book book)
        {
            Book bk = GetById(id);
            bk.Id = id;
            bk.Author = book.Author;
            bk.Title = book.Title;
            bk.Type = book.Type;
            bk.About = book.About;
            bk.Pages = book.Pages;


            _context.Update(bk);
            _context.SaveChanges();
        }
    }
}

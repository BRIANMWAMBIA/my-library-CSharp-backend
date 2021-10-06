using moviesData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesData
{
   public interface IBook
   {
        void AddNew(Book book);
       IEnumerable<Book> GetAll();
        Book GetById(int id);
        void Delete(Book book);
        void Update(int id, Book book);
        Book GetByTitle(string title);
        string GetTitle(int id);
        string GetType(int id);




   }
}

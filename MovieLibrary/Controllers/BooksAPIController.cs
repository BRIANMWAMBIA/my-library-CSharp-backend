using Microsoft.AspNetCore.Mvc;
using moviesData;
using moviesData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksAPIController : ControllerBase

    {
        private IBook _bookServices;
        public BooksAPIController(IBook bookService)
        {
            _bookServices = bookService;
        }
        // GET: api/<BooksAPIController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookServices.GetAll();
        }

        // GET api/<BooksAPIController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookServices.GetById(id);
        }

        // POST api/<BooksAPIController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _bookServices.AddNew(book);
        }

        // PUT api/<BooksAPIController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Book book)
        {
            _bookServices.Update(book.Id, book);
        }

        // DELETE api/<BooksAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookServices.Delete(_bookServices.GetById(id));
        }
    }
}

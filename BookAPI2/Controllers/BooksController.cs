using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using BookAPI2.Managers;
using ClassLibraryMandatory2;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksManager bookManager = new BooksManager();
        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<string> GetAll()
        {
            string jsontext = JsonSerializer.Serialize(bookManager.GetAll());
            return Ok(jsontext);
        }

        // GET api/<BooksController>/5
        [HttpGet("{ISBN}")]
        public ActionResult<string> Get(string ISBN)
        {
            if (Managers.BooksManager.booksTest.ContainsKey(ISBN))
            {
                string jsontext = JsonSerializer.Serialize(bookManager.GetBook(ISBN));
            return Ok(jsontext);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<BooksController>
        [HttpPost]
        public ActionResult Post([FromBody] Book value)
        {
            if (Managers.BooksManager.booksTest.ContainsKey(value.ISBN))
            {
                return BadRequest();
            }
            else
            {
                bookManager.CreateBook(value);
                return NoContent();//book was added, nothing is displayed
            }
        }

        // PUT api/<BooksController>/5
        [HttpPut("{ISBN}")]
        public ActionResult Put(string ISBN, [FromBody] Book value)
        {
            if (Managers.BooksManager.booksTest.ContainsKey(ISBN))
            {
                bookManager.UpdateBook(ISBN,value);
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{ISBN}")]
        public ActionResult Delete(string ISBN)
        {
            if (Managers.BooksManager.booksTest.ContainsKey(ISBN))
            {
                bookManager.DeleteBook(ISBN);
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

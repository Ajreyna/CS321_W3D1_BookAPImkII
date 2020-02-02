using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W3D1_BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W3D1_BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
            
        }
        // GET api/books
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.GetAll());
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/books
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

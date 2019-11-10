using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosPets.Api.Data;
using ContosPets.Api.Models;

namespace ContosPets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ContosPetsContext _context;

        public ProductsController(ContosPetsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll() =>
            _context.Products.ToList();

        // GET by ID action

        // POST action

        // PUT action

        // DELETE action
    }
}
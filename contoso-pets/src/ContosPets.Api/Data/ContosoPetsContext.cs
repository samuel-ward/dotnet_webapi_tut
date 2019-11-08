using Microsoft.EntityFrameworkCore;
using ContosPets.Api.Models;

namespace ContosPets.Api.Data
{
    public class ContosPetsContext : DbContext
    {
        public ContosPetsContext(DbContextOptions<ContosPetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products {get;set;}
    }
}
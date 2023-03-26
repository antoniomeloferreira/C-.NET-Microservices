using Mango.Services.ProductAPI.DbContexts.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //Products --> it will be the name of the table
        public DbSet<Product> Products { get; set; }
    }
}

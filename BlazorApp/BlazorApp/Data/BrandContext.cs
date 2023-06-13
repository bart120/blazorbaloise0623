using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Models;

namespace BlazorApp.Data
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options): base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
    }
}

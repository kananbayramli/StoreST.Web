using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {     
    }

    DbSet<Product> Products => Set<Product>();
}
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {     
    }

    public DbSet<Product> Products => Set<Product>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>(){
                new () {Id=1,Name="Samsung S24",Description="Cox gozel telefon",Price=1500,Category="Telefon"},                   
                new () {Id=2,Name="Samsung S25",Description="Cox gozel telefon",Price=2000,Category="Telefon"},                           
                new () {Id=3,Name="Samsung S26",Description="Cox gozel telefon",Price = 2500,Category = "Telefon"},
                new () {Id=4,Name="IPhone 11 pro",Description="Cox gozel telefon",Price=2500,Category="Telefon"},
                new () {Id=5,Name="IPhone 12 pro Max",Description="Cox gozel telefon",Price=2800,Category="Telefon"},
                new () {Id=6,Name="IPhone 15 pro Max",Description="Cox serfeli telefon",Price=3800,Category="Telefon"}
            }
        );

    }
}
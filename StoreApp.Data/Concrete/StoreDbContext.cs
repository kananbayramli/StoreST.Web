using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {     
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity<ProductCategory>();
        

        modelBuilder.Entity<Category>()
                .HasIndex(u => u.Url)
                .IsUnique();

        modelBuilder.Entity<Product>().HasData(
            new List<Product>(){
                new () {Id=1,Name="Samsung S24",Description="Cox gozel telefon",Price=1500},                   
                new () {Id=2,Name="Samsung S25",Description="Cox gozel telefon",Price=2000},                           
                new () {Id=3,Name="Samsung S26",Description="Cox gozel telefon",Price = 2500},
                new () {Id=4,Name="IPhone 11 pro",Description="Cox gozel telefon",Price=2500},
                new () {Id=5,Name="IPhone 12 pro Max",Description="Cox gozel telefon",Price=2800},
                new () {Id=6,Name="IPhone 15 pro Max",Description="Cox serfeli telefon",Price=3800},
                new () {Id=7,Name="Apple Mac Book",Description="Cox bahali notebook",Price=4800},
                new () {Id=8,Name="Asus Excalibur",Description="Cox guclu notebook",Price=4500},
                new () {Id=9,Name="Air Drop Apple",Description="Cox guclu sesi var",Price=280},
                new () {Id=10,Name="HP OMEN blue",Description="Cox gozel qulagciq",Price=300},
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new List<Category>(){
                new () { Id = 1, Name = "Telefon", Url = "telefon"},
                new () { Id = 2, Name = "Notebook", Url = "notebook"},
                new () { Id = 3, Name = "MP3 Player", Url = "mp3-player"},  //slug dotnet bibliotek
            }
        );


        modelBuilder.Entity<ProductCategory>().HasData(
            new List<ProductCategory>(){
                new() {ProductId=1, CategoryId = 1},
                new() {ProductId=2, CategoryId = 1},
                new() {ProductId=3, CategoryId = 1},
                new() {ProductId=4, CategoryId = 1},
                new() {ProductId=5, CategoryId = 1},
                new() {ProductId=6, CategoryId = 1},
                new() {ProductId=7, CategoryId = 2},
                new() {ProductId=8, CategoryId = 2},
                new() {ProductId=9, CategoryId = 3},
                new() {ProductId=10, CategoryId = 3},
            }
        );
    }
}
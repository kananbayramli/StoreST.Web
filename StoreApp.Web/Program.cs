using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(options =>{
    options.UseSqlite(builder.Configuration["ConnectionStrings:StoreDbConnection"], b=> b.MigrationsAssembly("StoreApp.Web"));
});


builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

app.UseStaticFiles();


//products/telefon => category products list
app.MapControllerRoute("products_in_category", "products/{category?}", 
new{controller="Home",action="Index"});

//samsung-s24 => product details
app.MapControllerRoute("product_details", "{name}", new{controller="Home", action="Details"});


app.MapDefaultControllerRoute();

app.Run();
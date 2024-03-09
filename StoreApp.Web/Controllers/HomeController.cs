using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    private IStoreRepository _storeRepository;
    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public IActionResult Index()
    {
        var products = _storeRepository.Products.Select(p => new ProductViewModel{
            Id = p.Id,
            Price = p.Price,
            Category = p.Category,
            Name = p.Name,
            Description = p.Description
        }).ToList();
        
        return View(new ProductListViewModel{
            Products = products
        });
    }
}
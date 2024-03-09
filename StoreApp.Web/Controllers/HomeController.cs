using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    public int pageSize = 3;
    private IStoreRepository _storeRepository;
    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public IActionResult Index(int page = 1)
    {
        var products = _storeRepository
        .Products
        .Skip((page -1) * pageSize)  // 1-1=>0*3 =0 ; //2-1=>1*3= 3; //3-1 =>2*3 = 6;
        .Select(p => 
                new ProductViewModel{
                    Id = p.Id,
                    Price = p.Price,
                    Category = p.Category,
                    Name = p.Name,
                    Description = p.Description
                }).Take(pageSize);

        return View(new ProductListViewModel{
            Products = products
        });
    }
}
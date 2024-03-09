using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Concrete;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    private EFStoreRepository _storeRepository;
    public HomeController(EFStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public IActionResult Index() => View();
}
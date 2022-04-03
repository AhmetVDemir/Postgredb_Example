using DataAccess;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        public PGContext _pGContext;
        public ProductController(PGContext pGContext)
        {
            _pGContext = pGContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            _pGContext.Add(new Product { Name = "Boing 737", Brand = "Boing", CategoryId = 0, Stok = 5, UnitPrice = 5.5m });
            _pGContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}

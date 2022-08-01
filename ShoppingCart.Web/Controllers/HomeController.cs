using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.DataAccess;
using ShoppingCart.DataAccess.Data;

namespace ShoppingCart.Web
{
    [Area("main")]
    public class HomeController : Controller
    {
        ApplicationDBContext _db;
        public HomeController(ApplicationDBContext db)
        {
            _db = db;
        }
        IQueryable<Category> q;
        public IActionResult Index()
        {            
            q = _db.Categories;
            var ss =q.FirstOrDefault(s => s.Id == 4);
            return View(ss);
        }
    }
}

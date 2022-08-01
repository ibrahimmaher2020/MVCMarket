using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Data;
using ShoppingCart.DataAccess.Repostoires;
using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;

namespace ShoppingCart.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private IUnitOfWork _uintOfWork;
        ApplicationDBContext _db;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _uintOfWork = unitOfWork;
            
        }
        public IActionResult Index()
        {
            CategoryVM categoryVM = new CategoryVM();
            categoryVM.Categories = _uintOfWork.Category.GetAll();
            return View(categoryVM);
            
        }

    }
}

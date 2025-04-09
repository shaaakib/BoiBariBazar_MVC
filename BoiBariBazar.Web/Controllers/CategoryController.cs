using BoiBariBazar.DataAccess.Data;
using BoiBariBazar.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoiBariBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> CategoryList = _db.Categories.ToList();
            return View(CategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

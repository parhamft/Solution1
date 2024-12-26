using cw__17.Models.Contract.CategoryContract;
using cw__17.Models.Entities;
using cw__17.Service;
using Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cw__17.Controllers
{

    public class CategoryController : Controller
    {
        ICategoryService categoryService = new CategoryService();
        public IActionResult Index()
        {
            if (Auth.CurrentUser == null) { return Redirect("/authentication/login"); }
            var cats = categoryService.GetAll();

            return View(cats);
        }
        [HttpPost]
        public IActionResult Add(string Title)
        {
            Category category = new Category() { Title = Title };
            categoryService.Creat(category);
            return RedirectToAction("Index");

        }

    }
}

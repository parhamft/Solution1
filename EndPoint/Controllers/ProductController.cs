using cw__17.Models.Contract.ProductContract;
using cw__17.Service;
using Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cw__17.Controllers
{
    
    public class ProductController : Controller
    {


        IProductService _productService = new ProductService();
        public IActionResult Index()
        { 
            if (Auth.CurrentUser==null) { return Redirect("/authentication/login"); }
            var pro = _productService.GetAll();

            return View(pro);
        }
    }
}

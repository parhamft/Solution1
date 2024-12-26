using domain.Contracts.UserContract;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

using Service.Service;

namespace EndPoint.Controllers
{
    public class AuthenticationController : Controller
    {
        IAuthenticationService authenticationService = new AuthenticationService();
        public IActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult login(string username, string password)
        {

            if (authenticationService.Login(username, password)== false)
            {
                TempData["Message"] = "Something is Wrong";
                TempData["AlertType"] = "danger"; 
                return View();
            }
            
            TempData["Message"] = "Logged in succesfully";
            TempData["AlertType"] = "success"; 
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string username,String password)
        {
            if (authenticationService.IsUsed(username) == true) 
            {
                TempData["Message"] = "That UserName Is Taken.";
                TempData["AlertType"] = "danger";
                return View();
            }
            authenticationService.Register(username, password);
            TempData["Message"] = "Registered in succesfully";
            TempData["AlertType"] = "success";
            return View();
        }
        public IActionResult LogOut() 
        {
            Auth.CurrentUser = null;
            return Redirect("/authentication/login");
        }
    }
}

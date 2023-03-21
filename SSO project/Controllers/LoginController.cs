using Microsoft.AspNetCore.Mvc;
using SSO_project.Models;

namespace SSO_project.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        //GET
        public ActionResult Login()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account account)
        {
           if(ModelState.IsValid)
           {
                return View("Login");
           }
           return View("Index");
            
        }
        
    }
}

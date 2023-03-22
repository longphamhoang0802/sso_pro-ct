using Microsoft.AspNetCore.Mvc;
using SSO_project.Data;
using SSO_project.Models;

namespace SSO_project.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Show()
        {
            var accounts = _dbContext.Account.ToList();

            return View(accounts);
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
                var objs = new List<Account>(){  new Account() {userName = account.userName ,password = account.password}};
                if (account.userName == "long" && account.password == "123")
                {
                    return View("Login", objs);
                }
                
           }
           return View("Index");
            
        }
        
    }
}

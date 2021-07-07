using FindHome.Models;
using FindHome.Web.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace FindHome.Web.Controllers
{
    public class UsersController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        
        


        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
           
        }


        [HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginInputModel model)   
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                await userManager.AddToRoleAsync(user, "User");
                
               
                
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterInputModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult MyFavorite()
        {
            return this.View();
        }
    }
}

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
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<IdentityUser> signInManager;




        public UsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginInputModel model)   
        {
            
                //var user = new IdentityUser { UserName = model.Email , Email = model.Email, EmailConfirmed = true};
                //var result = await userManager.CreateAsync(user, model.Password);
                //if (result.Succeeded)
                //{
                    //IdentityRole role = new IdentityRole
                    //{
                    //    Name = "User"
                    //};
                    //await roleManager.CreateAsync(role);

                    //await userManager.AddToRoleAsync(user, "User");

                    //await signInManager.SignInAsync(user, isPersistent: false);

                await signInManager.PasswordSignInAsync(model.Email,
                           model.Password, false, true );



                //}


                //await userManager.AddToRoleAsync(user, "User");

                //await signInManager.SignInAsync(user, isPersistent: false);


                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError(string.Empty, error.Description);
                //}
            

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterInputModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            await userManager.CreateAsync(user, model.Password);
            await userManager.AddToRoleAsync(user, "User");

            return RedirectToAction("Login", "Users");
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

using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace EShop.Controllers {
    [Route("[controller]")]
    public class AccountController : Controller {
        GenericContext db;
        public AccountController(GenericContext context) {
            db = context;
        }
        /// <summary>
        /// Navigate to login page
        /// </summary>
        [Route("~/Login")]
        [Route("Login")]
        [HttpGet]
        public IActionResult Login() {
            return View("~/Views/Login.cshtml");
        }

        /// <summary>
        /// Post login model
        /// </summary>
        /// <param name="model"></param>
        [Route("Login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model) {
            if (db.Users.Any()) {
                if (ModelState.IsValid) {
                    User user = await db.Users.FirstOrDefaultAsync(u => u.Name == model.Name && u.Password == model.Password);
                    if (user != null) {
                        await Authenticate(model.Name);
                        return Redirect("~/Index");
                    }
                    ModelState.AddModelError("LoginError", "User not found");
                    return View("~/Views/Login.cshtml", model);
                }
                else {
                    return View("~/Views/Login.cshtml");
                }
            }
            else {
                ModelState.AddModelError("LoginError", "User not found");
                return View("~/Views/Login.cshtml");
            }
        }
        /// <summary>
        /// Navigate to register page
        /// </summary>
        [Route("~/Register")]
        [Route("Register")]
        [HttpGet]
        public IActionResult Register() {
            return View("~/Views/Register.cshtml");
        }
        /// <summary>
        /// Post register model
        /// </summary>
        /// <param name="model"></param>
        [Route("Register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model) {
            if (ModelState.IsValid) {
                User userName = await db.Users.FirstOrDefaultAsync(u => u.Name == model.Name);
                User userEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (userName != null) {
                    ModelState.AddModelError("RegisterErrorName", "Username is already in use.");
                    return View("~/Views/Register.cshtml", model);
                }
                if (userEmail != null) {
                    ModelState.AddModelError("RegisterErrorEmail", "Email is already in use.");
                    return View("~/Views/Register.cshtml", model);
                }
                db.Users.Add(new User { Name = model.Name, Email = model.Email, Password = model.Password });
                await db.SaveChangesAsync();
                await Authenticate(model.Name);
                return Redirect("~/");

            }
            else {
                return View("~/Views/Register.cshtml");
            }
        }
        /// <summary>
        /// Navigate to account page
        /// </summary>
        [Authorize]
        [Route("View")]
        [HttpGet]
        public IActionResult ViewAcc() {
            return View("~/Views/Account.cshtml", Startup.cart);
        }
        /// <summary>
        /// Navigate to update-account page
        /// </summary>
        [Route("Update")]
        [HttpGet]
        public IActionResult Update() {
            try {
                var username = User.Identity.Name;
                User user = db.Users.Where(i => (i.Name == username)).First();
                if (user == null) {
                    return NotFound();
                }
                ViewBag.User = user;
                return View("~/Views/AccountUpdate.cshtml");
            }
            catch {
                ModelState.AddModelError("UpdateAccountError", "Something happened");
                return Redirect("~/Index");
            }
        }
        /// <summary>
        /// Post model to update account
        /// </summary>
        /// <param name="model"></param>
        [Authorize]
        [Route("Update")]
        [HttpPost]
        public async Task<IActionResult> Update(RegisterModel model) {
            if (ModelState.IsValid) {
                User userEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (userEmail != null) {
                    ModelState.AddModelError("UpdateAccountErrorEmail", "Email is already in use.");
                    return View("~/Views/AccountUpdate.cshtml", model);
                }
                else {
                    User user = db.Users.Where(i => (i.Name == model.Name)).First();
                    user.Email = model.Email;
                    user.Password = model.Password;
                    await db.SaveChangesAsync();
                    await Authenticate(model.Name);
                    return Redirect("~/Account/View");
                }
            }
            else {
                return View("~/Views/AccountUpdate.cshtml");
            }
        }
        /// <summary>
        /// Submit cart
        /// </summary>
        /// <param name="submit"></param>
        [Authorize]
        [Route("Submit")]
        [HttpPost]
        public IActionResult Submit(bool submit) {
            Startup.cart.Clear();
            return Redirect(string.Format("{0}?{1}", Request.Headers["Referer"], "submit=true"));
        }

        private async Task Authenticate(string userName) {
            var claims = new List<Claim> {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        /// <summary>
        /// Log out
        /// </summary>
        [Route("Logout")]
        [HttpGet]
        public async Task<IActionResult> Logout() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/Index");
        }
    }
}

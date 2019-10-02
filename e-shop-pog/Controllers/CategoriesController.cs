using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShop.Controllers {
    [Route("[controller]")]
    public class CategoriesController : Controller {
        GenericContext db;
        public CategoriesController(GenericContext context) {
            db = context;
            if (!db.Categories.Any()) {
                db.Categories.Add(new Category { Name = "Processors" });
                db.Categories.Add(new Category { Name = "Videocards" });
                db.Categories.Add(new Category { Name = "Memory" });
                db.Categories.Add(new Category { Name = "Motherboards" });
                db.Categories.Add(new Category { Name = "Storage" });
                db.Categories.Add(new Category { Name = "Power Supplies" });
                db.Categories.Add(new Category { Name = "Cooling" });
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Navigate to start page
        /// </summary>
        [Route("~/")]
        [Route("~/Index")]
        [Route("View")]
        [HttpGet]
        public IActionResult Index() {
            return View("~/Views/Index.cshtml", db.Categories.ToList());
        }
    }
}

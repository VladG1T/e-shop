using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers {
    [Route("[controller]")]
    public class CartController: Controller {
        GenericContext db;
        public CartController(GenericContext context) {
            db = context;
        }
        /// <summary>
        /// Add item to cart
        /// </summary>
        [Authorize]
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(string name, string imgURL, double price, string category) {
            Startup.cart.Add(new Item { Name = name, ImgURL = imgURL, Price = price, Category = category });
            if (Request.Headers["Referer"].FirstOrDefault().Contains("success")) {
                return Redirect(Request.Headers["Referer"]);
            }
            else {
                if (Request.Headers.Count == 0) {
                    return Redirect(string.Format("{0}?{1}", Request.Headers["Referer"], "success=true"));
                }
                else {
                    return Redirect(string.Format("{0}&{1}", Request.Headers["Referer"], "success=true"));
                }
            }
        }
        /// <summary>
        /// Remove item from cart
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [Route("Remove/{id}")]
        [HttpGet]
        public IActionResult Remove(int id) {
            Startup.cart.RemoveAt(id);
            if (Request.Headers["Referer"].FirstOrDefault().Contains("success")) {
                return Redirect(Request.Headers["Referer"]);
            }
            else {
                return Redirect(string.Format("{0}?{1}", Request.Headers["Referer"], "success=true"));
            }
        }
    }
}

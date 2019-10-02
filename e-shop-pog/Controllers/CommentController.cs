using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EShop.Controllers {
    [Route("[controller]")]
    public class CommentController : Controller {
        GenericContext db;
        public CommentController(GenericContext context) {
            db = context;
        }
        /// <summary>
        /// Navigate to comment page
        /// </summary>
        [Route("Post")]
        [Authorize]
        [HttpGet]
        public IActionResult Post() {
            return View("~/Views/Comment.cshtml");
        }
        /// <summary>
        /// Post comment
        /// </summary>
        /// <param name="model"></param>
        /// <param name="returnUrl"></param>
        [Route("Post")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(CommentModel model, string returnUrl) {
            try {
                db.Comments.Add(new Comment { Username = model.Username, Body = model.Body, Date = DateTime.Now, CategoryName = model.CategoryName, ItemId = model.ItemId });
                await db.SaveChangesAsync();
                return Redirect(returnUrl);
            }
            catch {
                ModelState.AddModelError("CommentError", "Something happened");
                return Redirect("~/Index");
            }
        }
    }
}

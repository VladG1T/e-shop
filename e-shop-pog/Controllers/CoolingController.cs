using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EShop.Helpers;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShop.Controllers {
    [Route("[controller]")]
    public class CoolingController : Controller {
        GenericContext db;
        public CoolingController(GenericContext context) {
            db = context;
            if (!db.Cooling.Any()) {
                db.Cooling.Add(new Cooling { Name = "CoolerMaster Hyper TX3", Type = "Air", RPM = 2800, AirFlow = 43.1, NoiseLevel = 30.0, Price = 21.11, ImgURL = "/Images/cooling-air.jpg" });
                db.Cooling.Add(new Cooling { Name = "Xilence XC051", Type = "Air", RPM = 1600, AirFlow = 70, NoiseLevel = 32.5, Price = 34.54, ImgURL = "/Images/cooling-air.jpg" });
                db.Cooling.Add(new Cooling { Name = "CoolerMaster ML360R", Type = "Liquid", RPM = 2000, AirFlow = 73.11, NoiseLevel = 36.0, Price = 190.97, ImgURL = "/Images/cooling-liquid.jpg" });
                db.Cooling.Add(new Cooling { Name = "NZXT Kraken M22", Type = "Liquid", RPM = 2800, AirFlow = 43.1, NoiseLevel = 30.0, Price = 93.63, ImgURL = "/Images/cooling-liquid.jpg" });
                db.Cooling.Add(new Cooling { Name = "Arctic Alpine AM4", Type = "Passive", RPM = 0, AirFlow = 0.0, NoiseLevel = 0.0, Price = 17.34, ImgURL = "/Images/cooling-passive.jpg" });
                db.Cooling.Add(new Cooling { Name = "Supermicro SNK", Type = "Passive", RPM = 0, AirFlow = 0.0, NoiseLevel = 0.0, Price = 37.29, ImgURL = "/Images/cooling-passive.jpg" });
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Get cooling systems list
        /// </summary>
        /// <param name="cooling_type"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(string cooling_type = "All", double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<Cooling> cooling = db.Cooling;
            if (cooling_type != null && cooling_type != "All") {
                cooling = db.Cooling.Where(x => x.Type.Contains(cooling_type));
            }
            cooling = cooling.Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    cooling = cooling.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.NoiseLevelAsc:
                    cooling = cooling.OrderBy(s => s.NoiseLevel);
                    break;
                case SortOrder.NoiseLevelDesc:
                    cooling = cooling.OrderByDescending(s => s.NoiseLevel);
                    break;
                case SortOrder.PriceAsc:
                    cooling = cooling.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    cooling = cooling.OrderByDescending(s => s.Price);
                    break;
                default:
                    cooling = cooling.OrderBy(s => s.Name);
                    break;
            }

            int count = cooling.Count();
            var items = cooling.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<Cooling> viewModel = new IndexViewModel<Cooling> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(cooling_type: cooling_type, max_price: max_price),
                Items = items
            };

            return View("~/Views/Items/Cooling.cshtml", viewModel);
        }
        /// <summary>
        /// Get cooling system by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            Cooling cooling = db.Cooling.Where(x => x.Id == id).FirstOrDefault();
            if (cooling == null) {
                return NotFound();
            }
            ViewBag.Item = cooling;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Cooling" && x.ItemId == id));
            return View("~/Views/ItemPages/CoolingPage.cshtml", cooling);
        }
    }
}

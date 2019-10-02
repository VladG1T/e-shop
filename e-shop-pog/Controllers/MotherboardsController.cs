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
    public class MotherboardsController : Controller {
        GenericContext db;
        public MotherboardsController(GenericContext context) {
            db = context;
            if (!db.MotherBoards.Any()) {
                db.MotherBoards.Add(new MotherBoard { Name = "Gigabyte B450M", Socket = "AMD AM4", MaxMemory = 64, MaxMemoryFrequency = 3200, Channels = 2, USBConnectors = 8, HasEthernet = true, HasWiFi = true, Price = 75.11, ImgURL = "/Images/motherboard.jpg" });
                db.MotherBoards.Add(new MotherBoard { Name = "Asus ROG B360G", Socket = "AMD AM4", MaxMemory = 64, MaxMemoryFrequency = 2666, Channels = 2, USBConnectors = 6, HasEthernet = true, HasWiFi = false, Price = 114.45, ImgURL = "/Images/motherboard.jpg" });
                db.MotherBoards.Add(new MotherBoard { Name = "MSI X399 SLI", Socket = "AMD TR4", MaxMemory = 128, MaxMemoryFrequency = 3600, Channels = 4, USBConnectors = 12, HasEthernet = true, HasWiFi = true, Price = 386.98, ImgURL = "/Images/motherboard.jpg" });
                db.MotherBoards.Add(new MotherBoard { Name = "ASUS X299 Extreme", Socket = "Intel LGA2066", MaxMemory = 128, MaxMemoryFrequency = 4200, Channels = 4, USBConnectors = 8, HasEthernet = true, HasWiFi = false, Price = 206.54, ImgURL = "/Images/motherboard.jpg" });
                db.MotherBoards.Add(new MotherBoard { Name = "Gigabyte Z170X", Socket = "Intel LGA1151", MaxMemory = 64, MaxMemoryFrequency = 3866, Channels = 2, USBConnectors = 11, HasEthernet = true, HasWiFi = true, Price = 93.56, ImgURL = "/Images/motherboard.jpg" });
                db.MotherBoards.Add(new MotherBoard { Name = "AsRock H310CM", Socket = "Intel LGA1151v2", MaxMemory = 32, MaxMemoryFrequency = 2666, Channels = 2, USBConnectors = 6, HasEthernet = true, HasWiFi = false, Price = 54.17, ImgURL = "/Images/motherboard.jpg" });
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Get motherboards list
        /// </summary>
        /// <param name="has_ethernet"></param>
        /// <param name="has_wifi"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(bool? has_ethernet, bool? has_wifi, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<MotherBoard> motherboards = db.MotherBoards;
            if (has_ethernet != null) {
                motherboards = (bool) has_ethernet ? db.MotherBoards.Where(x => x.HasEthernet == has_ethernet) : db.MotherBoards;
            }
            if (has_wifi != null) {
                motherboards = (bool) has_wifi ? motherboards.Where(x => x.HasWiFi == has_wifi) : motherboards;
            }
            motherboards = motherboards.Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    motherboards = motherboards.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.MotherboardChannelsAsc:
                    motherboards = motherboards.OrderBy(s => s.Channels);
                    break;
                case SortOrder.MotherboardChannelsDesc:
                    motherboards = motherboards.OrderByDescending(s => s.Channels);
                    break;
                case SortOrder.PriceAsc:
                    motherboards = motherboards.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    motherboards = motherboards.OrderByDescending(s => s.Price);
                    break;
                default:
                    motherboards = motherboards.OrderBy(s => s.Name);
                    break;
            }

            int count = motherboards.Count();
            var items = motherboards.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<MotherBoard> viewModel = new IndexViewModel<MotherBoard> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(max_price: max_price, has_ethernet: has_ethernet, has_wifi: has_wifi),
                Items = items
            };

            return View("~/Views/Items/Motherboards.cshtml", viewModel);
        }
        /// <summary>
        /// Get motherboard by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            MotherBoard motherboard = db.MotherBoards.Where(x => x.Id == id).FirstOrDefault();
            if (motherboard == null) {
                return NotFound();
            }
            ViewBag.Item = motherboard;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Motherboards" && x.ItemId == id));
            return View("~/Views/ItemPages/MotherboardPage.cshtml", motherboard);
        }
    }
}

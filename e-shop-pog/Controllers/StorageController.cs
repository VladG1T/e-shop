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
    public class StorageController : Controller {
        GenericContext db;
        public StorageController(GenericContext context) {
            db = context;
            if (!db.Storage.Any()) {
                db.Storage.Add(new Storage { Name = "Kingston A400", Type = "SSD", ReadSpeed = 500, WriteSpeed = 320, Buffer = 120, FormFactor = "2.5'", Price = 23.12, ImgURL = "/Images/ssd.jpg" });
                db.Storage.Add(new Storage { Name = "Crucial MX500", Type = "SSD", ReadSpeed = 560, WriteSpeed = 510, Buffer = 500, FormFactor = "2.5'", Price = 81.10, ImgURL = "/Images/ssd.jpg" });
                db.Storage.Add(new Storage { Name = "Transcend 220S", Type = "SSD", ReadSpeed = 3500, WriteSpeed = 2800, Buffer = 256, FormFactor = "M.2", Price = 65.04, ImgURL = "/Images/ssd.jpg" });
                db.Storage.Add(new Storage { Name = "Seagate Barracuda", Type = "HDD", ReadSpeed = 500, WriteSpeed = 134, Buffer = 2048, FormFactor = "3.5'", Price = 63.87, ImgURL = "/Images/hdd.jpg" });
                db.Storage.Add(new Storage { Name = "WD Red", Type = "HDD", ReadSpeed = 150, WriteSpeed = 150, Buffer = 4096, FormFactor = "3.5'", Price = 129.55, ImgURL = "/Images/hdd.jpg" });
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Get storage devices list
        /// </summary>
        /// <param name="storage_type"></param>
        /// <param name="min_storage"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(string storage_type = "All", int min_storage = 0, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<Storage> storage = db.Storage;
            if (storage_type != null && storage_type != "All") {
                storage = db.Storage.Where(x => x.Type.Contains(storage_type));
            }
            storage = storage.Where(x => (x.Buffer >= min_storage)).Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    storage = storage.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.StorageBufferAsc:
                    storage = storage.OrderBy(s => s.Buffer);
                    break;
                case SortOrder.StorageBufferDesc:
                    storage = storage.OrderByDescending(s => s.Buffer);
                    break;
                case SortOrder.PriceAsc:
                    storage = storage.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    storage = storage.OrderByDescending(s => s.Price);
                    break;
                default:
                    storage = storage.OrderBy(s => s.Name);
                    break;
            }

            int count = storage.Count();
            var items = storage.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<Storage> viewModel = new IndexViewModel<Storage> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(max_price: max_price, min_storage: min_storage, storage_type: storage_type),
                Items = items
            };

            return View("~/Views/Items/Storage.cshtml", viewModel);
        }
        /// <summary>
        /// Get storage device by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            Storage storage = db.Storage.Where(x => x.Id == id).FirstOrDefault();
            if (storage == null) {
                return NotFound();
            }
            ViewBag.Item = storage;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Storage" && x.ItemId == id));
            return View("~/Views/ItemPages/StoragePage.cshtml", storage);
        }
    }
}

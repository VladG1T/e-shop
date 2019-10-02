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
    public class MemoryController : Controller {
        GenericContext db;
        public MemoryController(GenericContext context) {
            db = context;
            if (!db.Memory.Any()) {
                db.Memory.Add(new Memory { Name = "NCP Original", Frequency = 1333, Buffer = 2.0, Type = "DDR3", HasLED = false, Price = 14.12, ImgURL = "/Images/memory.jpg" });
                db.Memory.Add(new Memory { Name = "Kingston ValueRAM", Frequency = 1600, Buffer = 2.0, Type = "DDR3", HasLED = false, Price = 17.03, ImgURL = "/Images/memory.jpg" });
                db.Memory.Add(new Memory { Name = "Team Elite", Frequency = 1866, Buffer = 4.0, Type = "DDR3", HasLED = true, Price = 34.67, ImgURL = "/Images/memory.jpg" });
                db.Memory.Add(new Memory { Name = "Samsung", Frequency = 2400, Buffer = 8.0, Type = "DDR4", HasLED = true, Price = 78.09, ImgURL = "/Images/memory.jpg" });
                db.Memory.Add(new Memory { Name = "Hynix", Frequency = 2666, Buffer = 4.0, Type = "DDR4", HasLED = false, Price = 51.67, ImgURL = "/Images/memory.jpg" });
                db.Memory.Add(new Memory { Name = "Micron", Frequency = 3200, Buffer = 4.0, Type = "DDR4", HasLED = false, Price = 66.43, ImgURL = "/Images/memory.jpg" });
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Get RAM items list
        /// </summary>
        /// <param name="ram_type"></param>
        /// <param name="min_buffer"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(string ram_type = "All", double min_buffer = 2.0, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<Memory> memory = db.Memory;
            if (ram_type != null && ram_type != "All") {
                memory = db.Memory.Where(x => x.Type.Contains(ram_type));
            }
            memory = memory.Where(x => (x.Buffer >= min_buffer)).Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    memory = memory.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.RAMBufferAsc:
                    memory = memory.OrderBy(s => s.Buffer);
                    break;
                case SortOrder.RAMBufferDesc:
                    memory = memory.OrderByDescending(s => s.Buffer);
                    break;
                case SortOrder.PriceAsc:
                    memory = memory.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    memory = memory.OrderByDescending(s => s.Price);
                    break;
                default:
                    memory = memory.OrderBy(s => s.Name);
                    break;
            }

            int count = memory.Count();
            var items = memory.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<Memory> viewModel = new IndexViewModel<Memory> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(max_price: max_price, min_buffer: min_buffer, ram_type: ram_type),
                Items = items
            };

            return View("~/Views/Items/Memory.cshtml", viewModel);
        }
        /// <summary>
        /// Get RAM item by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            Memory memory = db.Memory.Where(x => x.Id == id).FirstOrDefault();
            if (memory == null) {
                return NotFound();
            }
            ViewBag.Item = memory;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Memory" && x.ItemId == id));
            return View("~/Views/ItemPages/MemoryPage.cshtml", memory);
        }
    }
}

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
    public class ProcessorsController : Controller {
        public GenericContext db;
        public GenericRepository<Processor> processorsRepo;
        public ProcessorsController(GenericContext context) {
            db = context;
            processorsRepo = new GenericRepository<Processor>(db);
            if (!processorsRepo.Any()) {
                processorsRepo.Insert(new Processor { Name = "Intel Core i3 2100", Frequency = 3.1, TurboFrequency = 3.1, NumCores = 2, NumThreads = 4, Cache = 3, RAMSupport = "DDR3", TDP = 65, Lithography = 32, Price = 116.12, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 2600X", Frequency = 3.8, TurboFrequency = 4.2, NumCores = 6, NumThreads = 12, Cache = 12, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 202.55, ImgURL = "/Images/amd-ryzen.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i3 4170", Frequency = 3.7, TurboFrequency = 3.7, NumCores = 2, NumThreads = 4, Cache = 3, RAMSupport = "DDR3", TDP = 54, Lithography = 22, Price = 130.77, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i3 8350k", Frequency = 4.0, TurboFrequency = 4.0, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 91, Lithography = 14, Price = 187.91, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i5 4690k", Frequency = 3.5, TurboFrequency = 3.9, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3", TDP = 88, Lithography = 22, Price = 171.03, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 1200", Frequency = 3.5, TurboFrequency = 3.7, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 118.75, ImgURL = "/Images/amd-ryzen.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 1700", Frequency = 3.7, TurboFrequency = 3.9, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 227.83, ImgURL = "/Images/amd-ryzen.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i5 6400", Frequency = 2.7, TurboFrequency = 3.3, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3, DDR4", TDP = 65, Lithography = 14, Price = 194.69, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i5 8600", Frequency = 3.1, TurboFrequency = 4.3, NumCores = 6, NumThreads = 6, Cache = 9, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 232.43, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 1200", Frequency = 3.5, TurboFrequency = 3.7, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 118.36, ImgURL = "/Images/amd-ryzen.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i7 3770k", Frequency = 3.5, TurboFrequency = 3.9, NumCores = 4, NumThreads = 8, Cache = 8, RAMSupport = "DDR3", TDP = 77, Lithography = 22, Price = 210.50, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 2700X", Frequency = 3.9, TurboFrequency = 4.3, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 284.00, ImgURL = "/Images/amd-ryzen.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i7 7700k", Frequency = 3.8, TurboFrequency = 4.2, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3L, DDR4", TDP = 91, Lithography = 14, Price = 290.78, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i7 8700", Frequency = 3.2, TurboFrequency = 4.6, NumCores = 6, NumThreads = 12, Cache = 12, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 341.07, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "Intel Core i9 9900k", Frequency = 3.6, TurboFrequency = 5.0, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 575.95, ImgURL = "/Images/intel.jpg" });
                processorsRepo.Insert(new Processor { Name = "AMD Ryzen 1500X", Frequency = 3.6, TurboFrequency = 4.0, NumCores = 4, NumThreads = 8, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 153.76, ImgURL = "/Images/amd-ryzen.jpg" });
            }
        }
        /// <summary>
        /// Get processor list
        /// </summary>
        /// <param name="vendor"></param>
        /// <param name="min_cores"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="success"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(string vendor = "All", int min_cores = 2, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5, bool success = false)  {
            IQueryable<Processor> processors = processorsRepo.dbSet;
            if (vendor != null && vendor != "All") {
                processors = processorsRepo.dbSet.Where(x => x.Name.Contains(vendor));
            }
            processors = processors.Where(x => (x.NumCores >= min_cores)).Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    processors = processors.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.TDPAsc:
                    processors = processors.OrderBy(s => s.TDP);
                    break;
                case SortOrder.TDPDesc:
                    processors = processors.OrderByDescending(s => s.TDP);
                    break;
                case SortOrder.PriceAsc:
                    processors = processors.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    processors = processors.OrderByDescending(s => s.Price);
                    break;
                default:
                    processors = processors.OrderBy(s => s.Name);
                    break;
            }

            int count = processors.Count();
            var items = processors.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            
            IndexViewModel<Processor> viewModel = new IndexViewModel<Processor> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(vendor, min_cores, max_price),
                Items = items
            };

            return View("~/Views/Items/Processors.cshtml", viewModel);
        }
        /// <summary>
        /// Get processor by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            Processor processor = processorsRepo.GetByID(id);
            if (processor == null) {
                return NotFound();
            }
            ViewBag.Item = processor;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Processor" && x.ItemId == id));
            return View("~/Views/ItemPages/ProcessorPage.cshtml", processor);
        }
    }
}

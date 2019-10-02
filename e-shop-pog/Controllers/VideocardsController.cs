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
    public class VideocardsController : Controller {
        GenericContext db;
        public VideocardsController(GenericContext context) {
            db = context;
            if (!db.VideoCards.Any()) {
                db.VideoCards.Add(new VideoCard { Name = "GeForce GTX 660 Ti", Frequency = 1032, TurboFrequency = 1111, NumCores = 1344, BusWidth = 192, VRAMBuffer = 2.0, VRAMType = "GDDR5", TDP = 150, Lithography = 28, Price = 155.02, ImgURL = "/Images/nvidia.jpg" });
                db.VideoCards.Add(new VideoCard { Name = "GeForce GTX 970", Frequency = 1140, TurboFrequency = 1279, NumCores = 1664, BusWidth = 224, VRAMBuffer = 3.5, VRAMType = "GDDR5", TDP = 145, Lithography = 28, Price = 220.20, ImgURL = "/Images/nvidia.jpg" });
                db.VideoCards.Add(new VideoCard { Name = "GeForce RTX 2080", Frequency = 1731, TurboFrequency = 1860, NumCores = 2944, BusWidth = 256, VRAMBuffer = 8.0, VRAMType = "GDDR6", TDP = 250, Lithography = 12, Price = 650.56, ImgURL = "/Images/nvidia.jpg" });
                db.VideoCards.Add(new VideoCard { Name = "AMD Radeon R9 285", Frequency = 973, TurboFrequency = 1056, NumCores = 1792, BusWidth = 256, VRAMBuffer = 2.0, VRAMType = "GDDR5", TDP = 190, Lithography = 28, Price = 190.99, ImgURL = "/Images/amd-radeon.jpg" });
                db.VideoCards.Add(new VideoCard { Name = "AMD Radeon RX 480", Frequency = 1120, TurboFrequency = 1266, NumCores = 2304, BusWidth = 256, VRAMBuffer = 8.0, VRAMType = "GDDR5", TDP = 150, Lithography = 14, Price = 235.78, ImgURL = "/Images/amd-radeon.jpg" });
                db.VideoCards.Add(new VideoCard { Name = "AMD Radeon VII", Frequency = 1400, TurboFrequency = 1750, NumCores = 3840, BusWidth = 4096, VRAMBuffer = 16.0, VRAMType = "HBM2", TDP = 300, Lithography = 7, Price = 700.61, ImgURL = "/Images/amd-radeon.jpg" });
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Get videocards list
        /// </summary>
        /// <param name="vendor"></param>
        /// <param name="min_vram"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(string vendor = "All", double min_vram = 2, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<VideoCard> videoCards = db.VideoCards;
            if (vendor != null && vendor != "All") {
                videoCards = db.VideoCards.Where(x => x.Name.Contains(vendor));
            }
            videoCards = videoCards.Where(x => (x.VRAMBuffer >= min_vram)).Where(x => (x.Price <= max_price));


            switch (sortOrder) {
                case SortOrder.NameDesc:
                    videoCards = videoCards.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.TDPAsc:
                    videoCards = videoCards.OrderBy(s => s.TDP);
                    break;
                case SortOrder.TDPDesc:
                    videoCards = videoCards.OrderByDescending(s => s.TDP);
                    break;
                case SortOrder.PriceAsc:
                    videoCards = videoCards.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    videoCards = videoCards.OrderByDescending(s => s.Price);
                    break;
                default:
                    videoCards = videoCards.OrderBy(s => s.Name);
                    break;
            }

            int count = videoCards.Count();
            var items = videoCards.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<VideoCard> viewModel = new IndexViewModel<VideoCard> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(vendor, 2 , max_price, min_vram),
                Items = items
            };

            return View("~/Views/Items/Videocards.cshtml", viewModel);
        }
        /// <summary>
        /// Get videocard by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            VideoCard videoCard = db.VideoCards.Where(x => x.Id == id).FirstOrDefault();
            if (videoCard == null) {
                return NotFound();
            }
            ViewBag.Item = videoCard;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "Videocard" && x.ItemId == id));
            return View("~/Views/ItemPages/VideocardPage.cshtml", videoCard);
        }
    }
}

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
    public class PowerSuppliesController : Controller {
        GenericContext db;
        public PowerSuppliesController(GenericContext context) {
            db = context;
            if (!db.PowerSupplies.Any()) {
                db.PowerSupplies.Add(new PowerSupply { Name = "Chieftec Proton", MaxPower = 500, MaxVoltage = 12, MaxCurrent = 41, HasOverVoltageProtection = true, Price = 56.11, ImgURL = "/Images/power-supply.jpg" });
                db.PowerSupplies.Add(new PowerSupply { Name = "be Quiet! System Power", MaxPower = 600, MaxVoltage = 12, MaxCurrent = 28, HasOverVoltageProtection = false, Price = 79.04, ImgURL = "/Images/power-supply.jpg" });
                db.PowerSupplies.Add(new PowerSupply { Name = "Corsair RM750X", MaxPower = 750, MaxVoltage = 12, MaxCurrent = 62, HasOverVoltageProtection = true, Price = 138.65, ImgURL = "/Images/power-supply.jpg" });
                db.PowerSupplies.Add(new PowerSupply { Name = "AeroCool Eco", MaxPower = 600, MaxVoltage = 12, MaxCurrent = 46, HasOverVoltageProtection = false, Price = 37.88, ImgURL = "/Images/power-supply.jpg" });
                db.PowerSupplies.Add(new PowerSupply { Name = "Seasonic Focus Plus", MaxPower = 650, MaxVoltage = 12, MaxCurrent = 64, HasOverVoltageProtection = true, Price = 146.34, ImgURL = "/Images/power-supply.jpg" });
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Get power supplies list
        /// </summary>
        /// <param name="over_volt"></param>
        /// <param name="max_power"></param>
        /// <param name="max_price"></param>
        /// <param name="sortOrder"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [Route("View")]
        [HttpGet]
        public IActionResult Get(bool? over_volt, int max_power = 0, double max_price = 9999, SortOrder sortOrder = SortOrder.NameAsc, int page = 1, int pageSize = 5) {
            IQueryable<PowerSupply> powerSupplies = db.PowerSupplies;
            if (over_volt != null) {
                powerSupplies = (bool) over_volt ? db.PowerSupplies.Where(x => x.HasOverVoltageProtection == over_volt) : db.PowerSupplies;
            }
            powerSupplies = powerSupplies.Where(x => (x.Price <= max_price)).Where(y => (y.MaxPower >= max_power));

            switch (sortOrder) {
                case SortOrder.NameDesc:
                    powerSupplies = powerSupplies.OrderByDescending(s => s.Name);
                    break;
                case SortOrder.MaxPowerAsc:
                    powerSupplies = powerSupplies.OrderBy(s => s.MaxPower);
                    break;
                case SortOrder.MaxPowerDesc:
                    powerSupplies = powerSupplies.OrderByDescending(s => s.MaxPower);
                    break;
                case SortOrder.PriceAsc:
                    powerSupplies = powerSupplies.OrderBy(s => s.Price);
                    break;
                case SortOrder.PriceDesc:
                    powerSupplies = powerSupplies.OrderByDescending(s => s.Price);
                    break;
                default:
                    powerSupplies = powerSupplies.OrderBy(s => s.Name);
                    break;
            }

            int count = powerSupplies.Count();
            var items = powerSupplies.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel<PowerSupply> viewModel = new IndexViewModel<PowerSupply> {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(max_price: max_price, over_volt: over_volt, max_power: max_power),
                Items = items
            };

            return View("~/Views/Items/PowerSupplies.cshtml", viewModel);
        }
        /// <summary>
        /// Get power supply by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="success"></param>
        [Route("View/{id}")]
        [HttpGet]
        public IActionResult Get(int? id, bool success) {
            if (!id.HasValue) {
                return BadRequest();
            }
            PowerSupply powerSupply = db.PowerSupplies.Where(x => x.Id == id).FirstOrDefault();
            if (powerSupply == null) {
                return NotFound();
            }
            ViewBag.Item = powerSupply;
            ViewBag.Comments = db.Comments.Where(x => (x.CategoryName == "PowerSupplies" && x.ItemId == id));
            return View("~/Views/ItemPages/PowerSupplyPage.cshtml", powerSupply);
        }
    }
}

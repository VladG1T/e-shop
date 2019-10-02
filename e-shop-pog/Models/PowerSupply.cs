using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class PowerSupply {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPower { get; set; }
        public int MaxVoltage { get; set; }
        public int MaxCurrent { get; set; }
        public bool HasOverVoltageProtection { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

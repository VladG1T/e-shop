using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.BLL.DTO {
    public class Cooling {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int RPM { get; set; }
        public double AirFlow { get; set; }
        public double NoiseLevel { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

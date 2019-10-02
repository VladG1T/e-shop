using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class Memory {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }
        public double Buffer { get; set; }
        public string Type { get; set; }
        public bool HasLED { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

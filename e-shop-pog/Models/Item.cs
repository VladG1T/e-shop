using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class Item {
        public string Name { get; set; }
        public string ImgURL { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}

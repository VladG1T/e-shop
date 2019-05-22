using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.DAL.Entities {
    public class Storage {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public int Buffer { get; set; }
        public string FormFactor { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

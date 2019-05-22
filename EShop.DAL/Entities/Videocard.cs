using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.DAL.Entities {
    public class VideoCard {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }
        public int TurboFrequency { get; set; }
        public int NumCores { get; set; }
        public int BusWidth { get; set; }
        public double VRAMBuffer { get; set; }
        public string VRAMType { get; set; }
        public int TDP { get; set; }
        public int Lithography { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

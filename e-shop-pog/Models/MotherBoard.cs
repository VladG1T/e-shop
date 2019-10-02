using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class MotherBoard {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Socket { get; set; }
        public int MaxMemory { get; set; }
        public int MaxMemoryFrequency { get; set; }
        public int Channels { get; set; }
        public int USBConnectors { get; set; }
        public bool HasEthernet { get; set; }
        public bool HasWiFi { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

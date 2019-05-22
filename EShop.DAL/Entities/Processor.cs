using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.DAL.Entities {
    public class Processor{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public double TurboFrequency { get; set; }
        public int NumCores { get; set; }
        public int NumThreads { get; set; }
        public int Cache { get; set; }
        public string RAMSupport { get; set; }
        public int TDP { get; set; }
        public int Lithography { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
    }
}

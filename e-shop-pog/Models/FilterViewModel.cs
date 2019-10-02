using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class FilterViewModel {
        public ArrayList Vendor_proc_list { get; set; }
        public ArrayList Vendor_video_list { get; set; }
        public ArrayList Cooling_type_list { get; set; }
        public ArrayList Min_cores_list { get; set; }
        public ArrayList Min_vram_list { get; set; }
        public ArrayList Min_buffer_list { get; set; }
        public ArrayList RAM_type_list { get; set; }
        public ArrayList Storage_type_list { get; set; }
        public ArrayList Min_storage_list { get; set; }
        public string Vendor { get; set; }
        public string RAM_type { get; set; }
        public int Min_cores { get; set; }
        public int Max_power { get; set; }
        public double Min_vram { get; set; }
        public double Min_buffer { get; set; }
        public double Max_price { get; set; }
        public string Cooling_type { get; set; }
        public string Storage_type { get; set; }
        public int Min_storage { get; set; }
        public bool? Has_ethernet { get; set; }
        public bool? Has_wifi { get; set; }
        public bool? Over_volt { get; set; }
        public FilterViewModel(string vendor = "All", int min_cores = 2, double max_price = 9999,
                               double min_vram = 2.0, string cooling_type = "All", double min_buffer = 2.0,
                               string ram_type = "All", string storage_type = "All", bool? has_ethernet = null,
                               bool? has_wifi = null, int min_storage = 0, bool? over_volt = null, int max_power = 0) {
            Vendor_proc_list = new ArrayList {
                "All", "Intel", "AMD"
            };
            Vendor_video_list = new ArrayList {
                "All", "GeForce", "AMD"
            };
            Cooling_type_list = new ArrayList {
                "All", "Air", "Liquid", "Passive"
            };
            RAM_type_list = new ArrayList {
                "All", "DDR3", "DDR4"
            };
            Storage_type_list = new ArrayList {
                "All", "HDD", "SSD"
            };
            Min_cores_list = new ArrayList {
                "All", 2, 4, 6, 8
            };
            Min_vram_list = new ArrayList {
                "All", 2, 4, 6, 8
            };
            Min_buffer_list = new ArrayList {
                "All", 2, 4, 6, 8
            };
            Min_storage_list = new ArrayList {
                "All", 120, 240, 500, 1000
            };
            Max_price = max_price;
            Vendor = vendor;
            Min_cores = min_cores;
            Min_vram = min_vram;
            Min_buffer = min_buffer;
            Cooling_type = cooling_type;
            RAM_type = ram_type;
            Storage_type = storage_type;
            Has_ethernet = has_ethernet;
            Has_wifi = has_wifi;
            Min_storage = min_storage;
            Over_volt = over_volt;
            Max_power = max_power;
        }
    }
}

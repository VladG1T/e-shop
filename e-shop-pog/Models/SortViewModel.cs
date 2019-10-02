using EShop.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class SortViewModel {
        public SortOrder NameSort { get; private set; } 
        public SortOrder TDPSort { get; private set; }   
        public SortOrder PriceSort { get; private set; }
        public SortOrder NoiseLevelSort { get; private set; }
        public SortOrder RAMBufferSort { get; private set; }
        public SortOrder StorageBufferSort { get; private set; }
        public SortOrder MotherboardChannelsSort { get; private set; }
        public SortOrder MaxPowerSort { get; private set; }
        public SortOrder Current { get; private set; }    

        public SortViewModel(SortOrder sortOrder) {
            NameSort = sortOrder == SortOrder.NameAsc ? SortOrder.NameDesc : SortOrder.NameAsc;
            TDPSort = sortOrder == SortOrder.TDPAsc ? SortOrder.TDPDesc : SortOrder.TDPAsc;
            PriceSort = sortOrder == SortOrder.PriceAsc ? SortOrder.PriceDesc : SortOrder.PriceAsc;
            NoiseLevelSort = sortOrder == SortOrder.NoiseLevelAsc ? SortOrder.NoiseLevelDesc : SortOrder.NoiseLevelAsc;
            RAMBufferSort = sortOrder == SortOrder.RAMBufferAsc ? SortOrder.RAMBufferDesc : SortOrder.RAMBufferAsc;
            StorageBufferSort = sortOrder == SortOrder.StorageBufferAsc ? SortOrder.StorageBufferDesc : SortOrder.StorageBufferAsc;
            MotherboardChannelsSort = sortOrder == SortOrder.MotherboardChannelsAsc ? SortOrder.MotherboardChannelsDesc : SortOrder.MotherboardChannelsAsc;
            MaxPowerSort = sortOrder == SortOrder.MaxPowerAsc ? SortOrder.MaxPowerDesc : SortOrder.MaxPowerAsc;
            Current = sortOrder;
        }
    }
}

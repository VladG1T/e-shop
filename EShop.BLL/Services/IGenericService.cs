using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.BLL.Services {
    public interface IGenericService {
        IEnumerable<DTO.Category> GetCategories();
        IEnumerable<DTO.User> GetUsers();
        IEnumerable<DTO.Comment> GetComments();
        IEnumerable<DTO.Processor> GetProcessors();
        IEnumerable<DTO.VideoCard> GetVideocards();
        IEnumerable<DTO.MotherBoard> GetMotherboards();
        IEnumerable<DTO.Storage> GetStorage();
        IEnumerable<DTO.PowerSupply> GetPowerSupplies();
        IEnumerable<DTO.Memory> GetMemory();
        IEnumerable<DTO.Cooling> GetCooling();
        void AddComment(DTO.Comment item);
        void AddUser(DTO.User item);
        void AddCategory(DTO.Category item);
        void AddProcessor(DTO.Processor item);
        void AddVideocard(DTO.VideoCard item);
        void AddMemory(DTO.Memory item);
        void AddStorage(DTO.Storage item);
        void AddPowerSupply(DTO.PowerSupply item);
        void AddCooling(DTO.Cooling item);
        void AddMotherboard(DTO.MotherBoard item);
        void Dispose();
    }
}

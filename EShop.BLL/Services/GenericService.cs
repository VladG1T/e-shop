using AutoMapper;
using EShop.BLL.DTO;
using EShop.DAL.Entities;
using EShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.BLL.Services {
    public class GenericService : IGenericService {
        IUnitOfWork unitOfWork { get; set; }
        public GenericService(IUnitOfWork uow) {
            unitOfWork = uow;
        }
        IMapper mapperCategories = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Category, DTO.Category>()).CreateMapper();
        IMapper mapperUsers = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.User, DTO.User>()).CreateMapper();
        IMapper mapperComments = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Comment, DTO.Comment>()).CreateMapper();
        IMapper mapperProcessors = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Processor, DTO.Processor>()).CreateMapper();
        IMapper mapperVideocards = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.VideoCard, DTO.VideoCard>()).CreateMapper();
        IMapper mapperMemory = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Memory, DTO.Memory>()).CreateMapper();
        IMapper mapperStorage = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Storage, DTO.Storage>()).CreateMapper();
        IMapper mapperPowerSupplies = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.PowerSupply, DTO.PowerSupply>()).CreateMapper();
        IMapper mapperCooling = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.Cooling, DTO.Cooling>()).CreateMapper();
        IMapper mapperMotherboards = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Entities.MotherBoard, DTO.MotherBoard>()).CreateMapper();


        public IEnumerable<DTO.Category> GetCategories() {
            return mapperCategories.Map<IEnumerable<DAL.Entities.Category>, List<DTO.Category>>(unitOfWork.CategoriesRepo.GetAll());
        }
        public IEnumerable<DTO.User> GetUsers() {
            return mapperUsers.Map<IEnumerable<DAL.Entities.User>, List<DTO.User>>(unitOfWork.UsersRepo.GetAll());
        }
        public IEnumerable<DTO.Comment> GetComments() {
            return mapperComments.Map<IEnumerable<DAL.Entities.Comment>, List<DTO.Comment>>(unitOfWork.CommentsRepo.GetAll());
        }
        public IEnumerable<DTO.Processor> GetProcessors() {
            return mapperProcessors.Map<IEnumerable<DAL.Entities.Processor>, List<DTO.Processor>>(unitOfWork.ProcessorsRepo.GetAll());
        }
        public IEnumerable<DTO.VideoCard> GetVideocards() {
            return mapperVideocards.Map<IEnumerable<DAL.Entities.VideoCard>, List<DTO.VideoCard>>(unitOfWork.VideocardsRepo.GetAll());
        }
        public IEnumerable<DTO.Memory> GetMemory() {
            return mapperMemory.Map<IEnumerable<DAL.Entities.Memory>, List<DTO.Memory>>(unitOfWork.MemoryRepo.GetAll());
        }
        public IEnumerable<DTO.Storage> GetStorage() {
            return mapperStorage.Map<IEnumerable<DAL.Entities.Storage>, List<DTO.Storage>>(unitOfWork.StorageRepo.GetAll());
        }
        public IEnumerable<DTO.PowerSupply> GetPowerSupplies() {
            return mapperPowerSupplies.Map<IEnumerable<DAL.Entities.PowerSupply>, List<DTO.PowerSupply>>(unitOfWork.PowerSuppliesRepo.GetAll());
        }
        public IEnumerable<DTO.Cooling> GetCooling() {
            return mapperCooling.Map<IEnumerable<DAL.Entities.Cooling>, List<DTO.Cooling>>(unitOfWork.CoolingRepo.GetAll());
        }
        public IEnumerable<DTO.MotherBoard> GetMotherboards() {
            return mapperMotherboards.Map<IEnumerable<DAL.Entities.MotherBoard>, List<DTO.MotherBoard>>(unitOfWork.MotherboardsRepo.GetAll());
        }


        public void AddComment(DTO.Comment item) {
            unitOfWork.CommentsRepo.Insert(mapperComments.Map<DTO.Comment, DAL.Entities.Comment>(item));
            unitOfWork.Save();
        }
        public void AddUser(DTO.User item) {
            unitOfWork.UsersRepo.Insert(mapperUsers.Map<DTO.User, DAL.Entities.User>(item));
            unitOfWork.Save();
        }
        public void AddCategory(DTO.Category item) {
            unitOfWork.CategoriesRepo.Insert(mapperUsers.Map<DTO.Category, DAL.Entities.Category>(item));
            unitOfWork.Save();
        }
        public void AddProcessor(DTO.Processor item) {
            unitOfWork.ProcessorsRepo.Insert(mapperProcessors.Map<DTO.Processor, DAL.Entities.Processor>(item));
            unitOfWork.Save();
        }
        public void AddVideocard(DTO.VideoCard item) {
            unitOfWork.VideocardsRepo.Insert(mapperVideocards.Map<DTO.VideoCard, DAL.Entities.VideoCard>(item));
            unitOfWork.Save();
        }
        public void AddCooling(DTO.Cooling item) {
            unitOfWork.CoolingRepo.Insert(mapperCooling.Map<DTO.Cooling, DAL.Entities.Cooling>(item));
            unitOfWork.Save();
        }
        public void AddMotherboard(DTO.MotherBoard item) {
            unitOfWork.MotherboardsRepo.Insert(mapperMotherboards.Map<DTO.MotherBoard, DAL.Entities.MotherBoard>(item));
            unitOfWork.Save();
        }
        public void AddMemory(DTO.Memory item) {
            unitOfWork.MemoryRepo.Insert(mapperMemory.Map<DTO.Memory, DAL.Entities.Memory>(item));
            unitOfWork.Save();
        }
        public void AddStorage(DTO.Storage item) {
            unitOfWork.StorageRepo.Insert(mapperStorage.Map<DTO.Storage, DAL.Entities.Storage>(item));
            unitOfWork.Save();
        }
        public void AddPowerSupply(DTO.PowerSupply item) {
            unitOfWork.PowerSuppliesRepo.Insert(mapperPowerSupplies.Map<DTO.PowerSupply, DAL.Entities.PowerSupply>(item));
            unitOfWork.Save();
        }
        public void Dispose() {
            unitOfWork.Dispose();
        }
    }
}

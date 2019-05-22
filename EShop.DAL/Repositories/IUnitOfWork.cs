using EShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.DAL.Repositories {
    public interface IUnitOfWork : IDisposable {
        IRepository<Category> CategoriesRepo { get; }
        IRepository<User> UsersRepo { get; }
        IRepository<Comment> CommentsRepo { get; }
        IRepository<Processor> ProcessorsRepo { get; }
        IRepository<VideoCard> VideocardsRepo { get; }
        IRepository<Memory> MemoryRepo { get; }
        IRepository<Storage> StorageRepo { get; }
        IRepository<PowerSupply> PowerSuppliesRepo { get; }
        IRepository<Cooling> CoolingRepo { get; }
        IRepository<MotherBoard> MotherboardsRepo { get; }
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using EShop.DAL.Contexts;
using EShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShop.DAL.Repositories {
    public class UnitOfWork : IUnitOfWork{
        private GenericContext context;
        public UnitOfWork(PostgreSqlConnectionStringBuilder builder) {
            context = new GenericContext(new DbContextOptionsBuilder<GenericContext>().UseNpgsql(builder.ConnectionString).Options);
        }

        private GenericRepository<Category> categoriesRepo;
        public IRepository<Category> CategoriesRepo {
            get {
                if (categoriesRepo == null)
                    categoriesRepo = new GenericRepository<Category>(context);
                return categoriesRepo;
            }
        }

        private GenericRepository<User> userRepo;
        public IRepository<User> UsersRepo {
            get {
                if (userRepo == null)
                    userRepo = new GenericRepository<User>(context);
                return userRepo;
            }
        }

        private GenericRepository<Comment> commentRepo;
        public IRepository<Comment> CommentsRepo {
            get {
                if (commentRepo == null)
                    commentRepo = new GenericRepository<Comment>(context);
                return commentRepo;
            }
        }

        private GenericRepository<Processor> processorRepo;
        public IRepository<Processor> ProcessorsRepo {
            get {
                if (processorRepo == null)
                    processorRepo = new GenericRepository<Processor>(context);
                return processorRepo;
            }
        }

        private GenericRepository<VideoCard> videocardRepo;
        public IRepository<VideoCard> VideocardsRepo {
            get {
                if (videocardRepo == null)
                    videocardRepo = new GenericRepository<VideoCard>(context);
                return videocardRepo;
            }
        }

        private GenericRepository<Cooling> coolingRepo;
        public IRepository<Cooling> CoolingRepo {
            get {
                if (coolingRepo == null)
                    coolingRepo = new GenericRepository<Cooling>(context);
                return coolingRepo;
            }
        }

        private GenericRepository<Memory> memoryRepo;
        public IRepository<Memory> MemoryRepo {
            get {
                if (memoryRepo == null)
                    memoryRepo = new GenericRepository<Memory>(context);
                return memoryRepo;
            }
        }

        private GenericRepository<MotherBoard> motherboardRepo;
        public IRepository<MotherBoard> MotherboardsRepo {
            get {
                if (motherboardRepo == null)
                    motherboardRepo = new GenericRepository<MotherBoard>(context);
                return motherboardRepo;
            }
        }

        private GenericRepository<PowerSupply> powerSupplyRepo;
        public IRepository<PowerSupply> PowerSuppliesRepo {
            get {
                if (powerSupplyRepo == null)
                    powerSupplyRepo = new GenericRepository<PowerSupply>(context);
                return powerSupplyRepo;
            }
        }

        private GenericRepository<Storage> storageRepo;
        public IRepository<Storage> StorageRepo {
            get {
                if (storageRepo == null)
                    storageRepo = new GenericRepository<Storage>(context);
                return storageRepo;
            }
        }

        public void Save() {
            context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

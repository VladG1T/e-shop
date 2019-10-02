using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EShop.Models {
    public class GenericContext: DbContext{
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<Memory> Memory { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Cooling> Cooling { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public GenericContext(DbContextOptions<GenericContext> options) : base(options) {

        }

        public bool Any() {
            return Processors.Any();
        }
    }
}

using EShop.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EShop.Models {
    public class GenericRepository<TEntity> where TEntity : class {
        static string con = "postgres://xhhlwrhoymkdmw:24947730f2ed238645449cc4acccc94653b7eaf335cbd3479bbd734b58ce104a@ec2-46-137-113-157.eu-west-1.compute.amazonaws.com:5432/d5s1tuq7s7la7u";
        static PostgreSqlConnectionStringBuilder builder = new PostgreSqlConnectionStringBuilder(con) {
            Pooling = true,
            TrustServerCertificate = true,
            SslMode = SslMode.Require
        };
        public GenericContext context = new GenericContext(new DbContextOptionsBuilder<GenericContext>().UseNpgsql(builder.ConnectionString).Options);
        public DbSet<TEntity> dbSet;
        public GenericRepository() {
        }
        public GenericRepository(GenericContext context) {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> GetAll() {
            return dbSet.ToList();
        }
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "") {
            IQueryable<TEntity> query = dbSet;

            if (filter != null) {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) {
                query = query.Include(includeProperty);
            }

            if (orderBy != null) {
                return orderBy(query).ToList();
            }
            else {
                return query.ToList();
            }
        }

        public virtual TEntity GetByID(object id) {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity) {
            dbSet.Add(entity);
        }

        public virtual bool Any() {
            return dbSet.Any();
        }

        public virtual void Delete(object id) {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete) {
            if (context.Entry(entityToDelete).State == EntityState.Detached) {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate) {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}

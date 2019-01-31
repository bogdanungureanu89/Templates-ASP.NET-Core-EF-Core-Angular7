using System.Threading.Tasks;
using Test.Data.Entities;

namespace Test.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;

    public abstract class GenericRepository 
    {
        protected GenericRepository(DbContext context)
        {
            TestContext = context;
        }

        public DbContext TestContext { get; set; }


        public async Task<TEntity> GetAsync<TEntity>(int id)
            where TEntity : BaseEntity
        {

            return await TestContext.Set<TEntity>().FindAsync(id);
        }

        public void Add<TEntity>(TEntity dataEntity)
            where TEntity : BaseEntity
        {
            if (dataEntity != null)
            {
                TestContext.Set<TEntity>().Add(dataEntity);
            }
        }

        public void Update<TEntity>(TEntity dataEntity)
            where TEntity : BaseEntity
        {
            if (dataEntity != null)
            {
                TestContext.Set<TEntity>().Update(dataEntity);
            }
        }

        public void Remove<TEntity>(int id)
            where TEntity : BaseEntity
        {
            var entity = TestContext.Set<TEntity>().Find(id);
            if (entity != null)
            {
                TestContext.Set<TEntity>().Remove(entity);
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await TestContext.SaveChangesAsync();
        }
    }
}

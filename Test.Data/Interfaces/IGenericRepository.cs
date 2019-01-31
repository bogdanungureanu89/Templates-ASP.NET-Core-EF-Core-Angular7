namespace Test.Data.Interfaces
{
    using System.Threading.Tasks;
    using Test.Data.Entities;
    public interface IGenericRepository
    {
        Task<TEntity> GetAsync<TEntity>(int id) where TEntity : BaseEntity;

        void Add<TEntity>(TEntity dataEntity) where TEntity : BaseEntity;

        void Update<TEntity>(TEntity dataEntity) where TEntity : BaseEntity;

        void Remove<TEntity>(int id) where TEntity : BaseEntity;

        Task<int> SaveChangesAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using NewShopDemo.Data;

namespace NewShopDemo.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSetEntity;

        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSetEntity = _dbContext.Set<TEntity>();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
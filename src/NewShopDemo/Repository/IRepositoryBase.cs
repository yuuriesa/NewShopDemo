namespace NewShopDemo.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        // public IQueryable<TEntity> GetAll(PaginationFilter paginationFilter);   
        public TEntity GetById(int id);
        public void Add(TEntity entity);
    }
}
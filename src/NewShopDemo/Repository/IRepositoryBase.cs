namespace NewShopDemo.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        // public IQueryable<TEntity> GetAll(PaginationFilter paginationFilter);   
        public TEntity GetById(int id);
        public void Add(TEntity entity);
        public void AddRange(IEnumerable<TEntity> entities);
        public void Update(int id, TEntity entity);
    }
}
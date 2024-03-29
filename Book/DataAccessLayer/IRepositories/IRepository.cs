﻿using HelperDatas.GlobalReferences;

namespace DataAccessLayer.IRepositories;
    public interface IRepository<TEntity, in TPrimaryKeyType> where TEntity : class
    {
    ValueTask<TEntity> GetByIdAsync(TPrimaryKeyType id);

    Task<IEnumerable<TEntity>> GetAllAsync();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
   
    Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    int Count();

    Task<PagedResult<TEntity>> SearchAndPaginateAsync(Expression<Func<TEntity, bool>> predicate, PaginationOptions options);




}


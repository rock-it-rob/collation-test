using Microsoft.EntityFrameworkCore;

namespace Repository;

public interface IRepository<TEntity, TKey>
    where TEntity : class
    where TKey : notnull
{
    public PersonContext Context { get; }

    public void Create(TEntity entity) =>
        Context.Add(entity);

    public TEntity? Read(TKey id) =>
        Context.Find<TEntity>(id);

    public void Update(TEntity entity) =>
        Context.Update(entity);

    public void Delete(TEntity entity) =>
        Context.Remove(entity);

    public int SaveChanges() =>
        Context.SaveChanges();
}
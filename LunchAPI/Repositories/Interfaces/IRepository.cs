using LunchAPI.Models;

namespace LunchAPI.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        T? Get(Guid id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Func<T, bool> predicate);

        void Add(T enity);
        void AddRange(IEnumerable<T> entities);

        T Update(T entity);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

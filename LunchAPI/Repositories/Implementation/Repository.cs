using LunchAPI.Models;
using LunchAPI.Repositories.Interfaces;

namespace LunchAPI.Repositories.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly List<T> _data;

        public Repository()
        {
            _data = new List<T>();
        }

        public void Add(T enity)
        {
            if (_data.All(x => x.Id != enity.Id))
            {
                _data.Add(enity);
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Add(entity);
            }
        }

        public IQueryable<T> GetAll()
        {
            return _data.AsQueryable();
        }

        public T? Get(Guid id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> Find(Func<T, bool> predicate)
        {
            return _data.Where(predicate).AsQueryable();
        }

        public T Update(T entity)
        {
            Remove(entity);
            Add(entity);
            return entity;
        }

        public void Remove(T entity)
        {
            _data.Remove(_data.Single(x => x.Id == entity.Id));
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Remove(entity);
            }
        }
    }
}

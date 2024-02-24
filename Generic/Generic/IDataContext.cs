using System;
namespace Generic
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public interface IRepository<T> where T : Entity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }



    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T item)
        {
            _data.Add(item);
        }

        public void Remove(T item)
        {
            var itemToRemove = _data.FirstOrDefault(e => e.Id == item.Id);
            if (itemToRemove != null)
            {
                _data.Remove(itemToRemove);
            }
        }

        public void Save()
        {
            //_data.Save();
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return _data.FirstOrDefault(e => e.Id == id);
        }
    }



}


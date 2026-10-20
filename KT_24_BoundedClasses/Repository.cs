using System.Collections.Generic;

namespace KT_24_BoundedClasses
{
    public class Repository<T> where T : Entity
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T? GetById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
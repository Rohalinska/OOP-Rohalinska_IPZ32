using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5v14.Repositories
{
    public class Repository<T>
    {
        private readonly List<T> items = new();

        public void Add(T item) => items.Add(item);
        public void Remove(T item) => items.Remove(item);
        public IEnumerable<T> All() => items;
        public IEnumerable<T> Where(Func<T, bool> predicate) => items.Where(predicate);
        public T? Find(Func<T, bool> predicate) => items.FirstOrDefault(predicate);
    }
}

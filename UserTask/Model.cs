using System;
using System.Collections.Generic;

namespace UserTask
{
    internal abstract class Model<T>
    {
        public abstract void Add(T obj);
        public abstract void Update(T obj);
        public abstract void Delete(T obj);
        public abstract List<T> Search(string text);
        public abstract List<T> GetAll();
    }
}

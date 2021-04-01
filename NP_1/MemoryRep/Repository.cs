using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NP_1
{

    public class Repository<T> : IRepository<T>
    {
        public List<T> Data { get; } = new List<T>();

        public void Add(T tmp)
        {
            Data.Add(tmp);
        }
        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
        }
    }
}


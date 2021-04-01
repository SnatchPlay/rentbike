using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public interface IRepository<T>
    {
        List<T> Data { get; }
        void Add(T tmp);
        void Remove(short ind);
    }

}

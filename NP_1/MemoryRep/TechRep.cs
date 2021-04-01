using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1
{
    public class TechRep:Repository<Technic>,ITechRep
    {
        public void Add(Technic tmp)
        {
            base.Add(tmp);
        }
        public void Remove(short i)
        {
            base.Remove(i);
        }
    }
}

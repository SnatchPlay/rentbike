using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class TechRep:Repository<Technic>
    {
        public void Add(Technic tmp)
        {
            base.Add(tmp);
        }
    }
}

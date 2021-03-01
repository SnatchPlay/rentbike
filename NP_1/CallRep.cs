using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class CallRep:Repository<Call>
    {
        public void Add(Call tmp)
        {
            base.Add(tmp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class PlaceRep:Repository<Place>
    {
        public void Add(Place tmp)
        {
            base.Add(tmp);
        }
    }
}

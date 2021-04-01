using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1
{
    public class PlaceRep:Repository<Place>,IPlaceRep
    {
        public void Add(Place tmp)
        {
            base.Add(tmp);
        }
    }
}

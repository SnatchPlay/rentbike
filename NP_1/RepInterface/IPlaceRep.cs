using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1.RepInterface
{
    public interface IPlaceRep:IRepository<Place>
    {
        void Add(Place tmp);
    }
}

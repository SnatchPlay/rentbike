using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1.Factories
{
    class MemoryFactory : IFactory
    {
        public ICallRep GetCallRep()
        {
            return new CallRep();
        }

        public IPlaceRep GetPlaceRep()
        {
            return new PlaceRep();
        }

        public ITechRep GetTechRep()
        {
            return new TechRep();
        }
    }
}

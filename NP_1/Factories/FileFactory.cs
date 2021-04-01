using NP_1.FileRep;
using NP_1.RepInterface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NP_1.Factories
{
    class FileFactory : IFactory
    {
        public ICallRep GetCallRep()
        {
            return new CallFileRep();
        }

        public IPlaceRep GetPlaceRep()
        {
            return new PlaceFileRep();
        }

        public ITechRep GetTechRep()
        {
            return new TechFileRep();
        }
    }
}

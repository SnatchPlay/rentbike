using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1.Factories
{
    public interface IFactory
    {
        ICallRep GetCallRep();
        IPlaceRep GetPlaceRep();
        ITechRep GetTechRep();
        
    }
}

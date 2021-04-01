using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using NP_1.Factories;

namespace NP_1.Factories
{
    public static class FactoryProvider
    {
        public static IFactory GetFactory()
        {
            var factoryType = ConfigurationManager.AppSettings["factoryType"];
            switch (factoryType)
            {
                case "file":
                    return new FileFactory();
                default:
                    return new MemoryFactory();
            }

        }

    }
}

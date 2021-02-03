using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzLibraries.Generatiom
{
    public interface IFactoryRandomizer
    {
        public ITypeFactory GenerateRandomFactory();
    }
}

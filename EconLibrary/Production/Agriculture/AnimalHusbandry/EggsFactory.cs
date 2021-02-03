using CruzLibraries.Generatiom;
using EconLibrary.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibraries.Production.Agriculture.AnimalHusbandry
{
    class EggFactory : ITypeFactory
    {
        public IGeneratableType Generate()
        {
            return new Eggs();
        }
    }
}

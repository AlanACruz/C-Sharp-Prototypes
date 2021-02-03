using CruzLibraries.Generatiom;
using EconLibrary.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibraries.Production.Agriculture.AnimalHusbandry
{
    class AnimalFibersFactory : ITypeFactory
    {
        public IGeneratableType Generate()
        {
            return new AnimalFibers();
        }
    }
}

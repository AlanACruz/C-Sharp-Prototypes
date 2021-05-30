using CruzLibrary.Generation;
using EconLibrary.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibrary.Production.Agriculture.AnimalHusbandry
{
    class DairyFactory : ITypeFactory
    {
        public IGeneratableType Generate()
        {
            return new Dairy();
        }
    }
}

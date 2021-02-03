using CruzLibraries.Generatiom;
using CruzLibraries.Serialiazation;
using EconLibrary.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibraries.Production.Agriculture.AnimalHusbandry
{
    public class Pasture
    {
        private ITypeFactory SelectedFactory;

        Pasture()
        {
           AnimalHusbandryFactoryRandomizer FactoryRandomizer = new AnimalHusbandryFactoryRandomizer();
           SelectedFactory = FactoryRandomizer.GenerateRandomFactory();

        }

        public IGeneratableType Produce()
        {
            return SelectedFactory.Generate();
        }
    }
}
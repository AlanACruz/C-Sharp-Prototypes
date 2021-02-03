using CruzLibraries.Generatiom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibraries.Production.Agriculture.AnimalHusbandry
{
    public class AnimalHusbandryFactoryRandomizer : IFactoryRandomizer
    {
        public ITypeFactory GenerateRandomFactory()
        {
            ITypeFactory retValue;

            Random random = new Random();
            int selector = random.Next(0, 3);

            switch (selector)
            {
                default:
                case 0:
                    retValue = new AnimalFibersFactory();
                    break;

                case 1:
                    retValue = new DairyFactory();
                    break;

                case 2:
                    retValue = new EggFactory();
                    break;

                case 3:
                    retValue = new MeatFactory();
                    break;
            }

            return retValue;
        }
    }
}

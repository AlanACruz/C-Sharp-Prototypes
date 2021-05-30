using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzLibrary.Generation
{
    public interface ITypeFactory
    { 
        public IGeneratableType Generate();
    }
}

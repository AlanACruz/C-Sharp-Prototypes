﻿using CruzLibrary.Generation;
using CruzLibrary.Serialiazation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconLibrary.Production
{
   public interface IProductFactory : ITypeFactory, IJsonable
   {
   }
}

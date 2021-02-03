﻿using System;
using System.Collections.Generic;
using EconLibraries.EconomicResource;
using CruzLibraries;

namespace EconLibraries.BusinessOrganization
{
    public interface IOrganization : IJsonable
    {
        String Name { get; }
        public List<IOwner> OwnerList { get; }
    }
}

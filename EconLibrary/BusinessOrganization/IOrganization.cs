using System;
using System.Collections.Generic;
using EconLibrary.EconomicResource.Owner;
using CruzLibrary.Serialiazation;

namespace EconLibrary.BusinessOrganization
{
    public interface IOrganization : IJsonable
    {
        public String Name { get; }
        public List<IOwner> OwnerList { get; }
    }
}

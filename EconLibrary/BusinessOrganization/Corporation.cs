using EconLibrary.EconomicResource;
using System;
using System.Collections.Generic;
using EconLibrary.EconomicResource.Owner; 

namespace EconLibrary.BusinessOrganization
{
    public class Corporation : IOrganization
    {
        public String Name { get; }
        public List<IOwner> OwnerList { get; }
    }
}

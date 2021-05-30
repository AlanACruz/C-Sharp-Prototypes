using System;
using System.Collections.Generic;
using System.Text;
using EconLibrary.EconomicResource.Owner; 

namespace EconLibrary.BusinessOrganization
{
    public class SoleProprietorship : IOrganization
    {
        public String Name { get; }
        public List<IOwner> OwnerList { get; }
    }
}

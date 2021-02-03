using System;
using System.Text.Json;

namespace CruzLibraries.Serialiazation
{
    public interface IJsonable
    {
        public String ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

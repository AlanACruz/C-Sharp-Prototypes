using System;
using System.Text.Json;

namespace CruzLibrary.Serialiazation
{
    public interface IJsonable
    {
        public String ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class languages
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "code")] public string Code { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Code})" +
                $"({Name})" ;
        }
    }
}

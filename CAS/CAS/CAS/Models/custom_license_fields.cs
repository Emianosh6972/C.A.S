namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class custom_license_fields
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "options")] public string Options { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Type})" +
                $"({Name})" +
                $"({Description})" +
                $"({Options})";
        }
    }
}

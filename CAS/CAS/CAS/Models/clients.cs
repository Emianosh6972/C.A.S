namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class clients
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "asset_tag_prefix")] public string Asset_tag_prefix { get; set; }
        [JsonProperty(PropertyName = "license_tag_prefix")] public string License_tag_prefix { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }

        public override string ToString()
        {
            return 
                $"" +
                $"({Id})" +
                $"({Name})" +
                $"({Asset_tag_prefix})" +
                $"({License_tag_prefix})" +
                $"({Notes})";
        }
    }
}

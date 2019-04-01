namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class asset_categories
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "color")] public string Color { get; set; }

        public override string ToString()
        {
            return 
                $" " +
                $"({Id}) " +
                $"({Name}) " +
                $"({Color})";
        }
    }
}

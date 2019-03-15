namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class kb_categories
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clients")] public clients[] Clients { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
    }
}

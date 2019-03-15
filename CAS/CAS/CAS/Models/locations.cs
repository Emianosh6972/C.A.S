namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class locations
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "id")] public string Name { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
    }
}

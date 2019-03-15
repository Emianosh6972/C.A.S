namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class roles
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "fcmtoken")] public string Fcmtoken { get; set; }
        //[JsonProperty(PropertyName = "perms")] public [] Perms { get; set; }
    }
}

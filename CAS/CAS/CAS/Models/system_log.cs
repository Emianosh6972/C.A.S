namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class system_log
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "peopleid")] public int peopleid { get; set; }
        [JsonProperty(PropertyName = "name")] public string Description { get; set; }
    }
}

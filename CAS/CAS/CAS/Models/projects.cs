namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class projects
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int clientid { get; set; }
        [JsonProperty(PropertyName = "tag")] public string Tag { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "startdate")] public DateTime Startdate { get; set; }
        [JsonProperty(PropertyName = "deadline")] public DateTime Deadline { get; set; }
        [JsonProperty(PropertyName = "progress")] public int Progress { get; set; }
    }
}

namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class milestones
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "duedate")] public DateTime Duedate { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }

    }
}

namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class time_log
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "staffid")] public int Staffid { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "issues")] public issues[] Issues { get; set; }
        [JsonProperty(PropertyName = "tickets")] public tickets[] Tickets { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "date")] public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "start")] public DateTime Start { get; set; }
        [JsonProperty(PropertyName = "end")] public DateTime End { get; set; }
    }
}

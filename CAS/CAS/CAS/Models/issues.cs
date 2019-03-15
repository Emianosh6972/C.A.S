namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class issues
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
        [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
        [JsonProperty(PropertyName = "issuetype")] public string Issuetype { get; set; }       // task, maintenance, bug, improvement, new feature or story
        [JsonProperty(PropertyName = "priority")] public string Priority { get; set; }        // to do, in progress, in review or done
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "duedate")] public DateTime Duedate { get; set; }
    }
}

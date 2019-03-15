namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class tickets
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "departmentid")] public int Departmentid { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
        [JsonProperty(PropertyName = "userid")] public int Userid { get; set; }
        [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
        [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "email")] public string Email { get; set; }
        [JsonProperty(PropertyName = "subject")] public string Subject { get; set; }
        [JsonProperty(PropertyName = "priority")] public string Priority { get; set; }            // Low Normal or High
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        [JsonProperty(PropertyName = "css")] public string[] Ccs { get; set; }
        [JsonProperty(PropertyName = "message")] public string Message { get; set; }
        [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
        [JsonProperty(PropertyName = "status")] public string Status { get; set; }              // open, in progress, answered, reopened, closed
    }
}

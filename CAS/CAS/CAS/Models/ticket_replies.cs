namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class ticket_replies
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "ticketid")] public int Ticketid { get; set; }
        [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
        [JsonProperty(PropertyName = "userid")] public int Userid { get; set; }
        [JsonProperty(PropertyName = "message")] public string Message { get; set; }
        [JsonProperty(PropertyName = "peopleid")] public int Peopleid { get; set; }
        [JsonProperty(PropertyName = "status")] public string Status { get; set; }              // open, in progress, answered, reopened or closed, optional to change the status of a ticket after adding the reply
        [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
    }
}

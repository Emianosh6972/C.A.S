namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class monitoring_hosts
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "address")] public string Address { get; set; }
        [JsonProperty(PropertyName = "status")] public string Status { get; set; }         // up, down, can be empty

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Clientid})" +
                $"({Name})" +
                $"({Address})" +
                $"({Status})";
        }
    }
}

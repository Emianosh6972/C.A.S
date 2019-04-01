namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class monitoring_checks
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "hostid")] public int Hostid { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
        [JsonProperty(PropertyName = "port")] public string Port { get; set; }
        [JsonProperty(PropertyName = "monitoring")] public Boolean Monitoring { get; set; }
        [JsonProperty(PropertyName = "email")] public Boolean Email { get; set; }
        [JsonProperty(PropertyName = "sms")] public Boolean Sms { get; set; }
        [JsonProperty(PropertyName = "status")] public string Status { get; set; }          // up, down, empty

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Hostid})" +
                $"({Name})" +
                $"({Type})" +
                $"({Port})" +
                $"({Monitoring})" +
                $"({Email})" +
                $"({Sms})" +
                $"({Status})";
        }
    }
}

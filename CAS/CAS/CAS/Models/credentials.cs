namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class credentials
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
        [JsonProperty(PropertyName = "username")] public string Username { get; set; }
        [JsonProperty(PropertyName = "password")] public string Password { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Clientid})" +
                $"({Assetid})" +
                $"({Type})" +
                $"({Username})" +
                $"({Password})";
        }
    }
}

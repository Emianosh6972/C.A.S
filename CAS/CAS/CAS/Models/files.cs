namespace CAS.Models
{
    using Newtonsoft.Json;
    using System;
    public class files
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "Projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "Assetid")] public int Assetid { get; set; }
        [JsonProperty(PropertyName = "Ticketreplyid")] public int Ticketreplyid { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "file")] public files[] File { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Clientid})" +
                $"({Projectid})" +
                $"({Assetid})" +
                $"({Ticketreplyid})" +
                $"({Name})" + 
                $"({File})";
        }
    }
}

namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class kb_articles
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "categoryid")] public int Categoryid { get; set; }
        [JsonProperty(PropertyName = "clients")] public clients[] Clients { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "content")] public string Content { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Categoryid})" +
                $"({Clients})" +
                $"({Name})" +
                $"({Content})";
        }
    }
}

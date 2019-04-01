namespace CAS.Models
{
    using Newtonsoft.Json;
    public class comments
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "peopleid")] public int Peopleid { get; set; }
        [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
        [JsonProperty(PropertyName = "ticketid")] public int Ticketid { get; set; }
        [JsonProperty(PropertyName = "comment")] public string Comment { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Peopleid})" +
                $"({Projectid})" +
                $"({Ticketid})" +
                $"({Comment})";
        }
    }
}

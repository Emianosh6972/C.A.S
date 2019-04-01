namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class contacts
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "email")] public string Email { get; set; }
        [JsonProperty(PropertyName = "phone")] public string Phone { get; set; }
        [JsonProperty(PropertyName = "address")] public string Address { get; set; }
        [JsonProperty(PropertyName = "webaddress")] public string Webaddress { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Name})" +
                $"({Email})" +
                $"({Phone})" +
                $"({Address})" +
                $"({Webaddress})" +
                $"({Notes})";
        }
    }
}

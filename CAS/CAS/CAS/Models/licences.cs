namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class licenses
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "statusid")] public int Statusid { get; set; }
        [JsonProperty(PropertyName = "categoryid")] public int Categoryid { get; set; }
        [JsonProperty(PropertyName = "supplierid")] public int Supplierid { get; set; }
        [JsonProperty(PropertyName = "seats")] public string Seats { get; set; }
        [JsonProperty(PropertyName = "tag")] public string Tag { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "serial")] public string Serial { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        [JsonProperty(PropertyName = "customfields")] public custom_license_fields[] Customfields { get; set; }

        public override string ToString()
        {
            return
                $"" +
                $"({Id})" +
                $"({Clientid})" +
                $"({Statusid})" +
                $"({Categoryid})" +
                $"({Supplierid})" +
                $"({Seats})" +
                $"({Tag})" +
                $"({Name})" +
                $"({Serial})" +
                $"({Notes})" +
                $"({Customfields})";
        }
    }
}

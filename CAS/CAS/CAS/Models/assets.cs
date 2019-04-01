namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class assets
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "Categoryid")] public int Categoryid { get; set; }
        [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
        [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        [JsonProperty(PropertyName = "userid")] public int Userid { get; set; }
        [JsonProperty(PropertyName = "manufacturerid")] public int Manufacturerid { get; set; }
        [JsonProperty(PropertyName = "modelid")] public int Modelid { get; set; }
        [JsonProperty(PropertyName = "supplierid")] public int Supplierid { get; set; }
        [JsonProperty(PropertyName = "statusid")] public int Statusid { get; set; }
        [JsonProperty(PropertyName = "purchase_date")] public DateTime Purchase_date { get; set; }
        [JsonProperty(PropertyName = "warranty_months")] public int Warranty_months { get; set; }
        [JsonProperty(PropertyName = "tag")] public string Tag { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "serial")] public string Serial { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        [JsonProperty(PropertyName = "locationid")] public int Locationid { get; set; }
        [JsonProperty(PropertyName = "customfields")] public custom_asset_fields[] Customfields { get; set; }
        [JsonProperty(PropertyName = "qrvalue")] public string Qrvalue { get; set; }

        public override string ToString()
        {
            return 
                $" " +
                $"({Id}) " +
                $"({Categoryid}) " +
                $"({Adminid})" +
                $"({Clientid})" +
                $"({Userid})" +
                $"({Manufacturerid})" +
                $"({Modelid})" +
                $"({Supplierid})" +
                $"({Statusid})" +
                $"({Purchase_date})" +
                $"({Warranty_months})" +
                $"({Tag})" +
                $"({Name})" +
                $"({Serial})" +
                $"({Notes})" +
                $"({Locationid})" +
                $"({Customfields})" +
                $"({Qrvalue})";
        }
    }
}

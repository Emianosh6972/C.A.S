namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class authenticate
    {
        [JsonProperty(PropertyName = "username")] public string Username { get; set; }
        [JsonProperty(PropertyName = "password")] public string Password { get; set; }
    }
}

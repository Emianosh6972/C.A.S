namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class staff
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "roleid")] public int Roleid { get; set; }
        [JsonProperty(PropertyName = "email")] public string Email { get; set; }
        [JsonProperty(PropertyName = "ldap_user")] public string Ldap_user { get; set; }
        [JsonProperty(PropertyName = "title")] public string Title { get; set; }
        [JsonProperty(PropertyName = "mobile")] public string Mobile { get; set; }
        [JsonProperty(PropertyName = "password")] public string Password { get; set; }
        [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
        [JsonProperty(PropertyName = "theme")] public string Theme { get; set; }           // skin-blue,skin-black,skin-purple,skin-green,skin-red,skin-yellow,skin-blue-light,skin-black-light,skin-purple-light,skin-green-light,skin-red-light,skin-yellow-light
        [JsonProperty(PropertyName = "sidebar")] public Boolean Sidebar { get; set; }
        [JsonProperty(PropertyName = "layout")] public Boolean Layout { get; set; }
        [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        [JsonProperty(PropertyName = "lang")] public string Lang { get; set; }
        [JsonProperty(PropertyName = "ticketsnotification")] public int Ticketsnotification { get; set; }
        [JsonProperty(PropertyName = "fcmtoken")] public string Fcmtoken { get; set; }
    }
}

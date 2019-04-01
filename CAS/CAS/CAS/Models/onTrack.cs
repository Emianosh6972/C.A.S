namespace CAS.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class onTrack 
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
       
        [JsonProperty(PropertyName = "asset_categories")] public List<asset_categories> Asset_categories { get; set; }
        [JsonProperty(PropertyName = "assets")] public List<assets> Assets { get; set; }
        [JsonProperty(PropertyName = "authenticate")] public List<authenticate> Authenticate { get; set; }
        [JsonProperty(PropertyName = "clients")] public List<clients> Clients { get; set; }
        [JsonProperty(PropertyName = "comments")] public List<comments> Comments { get; set; }
        [JsonProperty(PropertyName = "config")] public List<config> Config { get; set; }
        [JsonProperty(PropertyName = "contacts")] public List<contacts> Contacts { get; set; }
        [JsonProperty(PropertyName = "credentials")] public List<credentials> Credentials { get; set; }
        [JsonProperty(PropertyName = "custom_assets_fields")] public List<custom_asset_fields> Custom_asset_fields { get; set; }
        [JsonProperty(PropertyName = "custom_license_fields")] public List<custom_license_fields> Custom_license_fields { get; set; }
        [JsonProperty(PropertyName = "files")] public List<files> Files { get; set; }
        [JsonProperty(PropertyName = "issues")] public List<issues> Issues { get; set; }
        [JsonProperty(PropertyName = "kb_articles")] public List<kb_articles> Kb_articles { get; set; }
        [JsonProperty(PropertyName = "kb_categories")] public List<kb_categories> Kb_categories { get; set; }
        [JsonProperty(PropertyName = "languages")] public List<languages> Languages { get; set; }
        [JsonProperty(PropertyName = "licence_categories")] public List<licence_categories> Licence_categories { get; set; }
        [JsonProperty(PropertyName = "licences")] public List<licenses> Licences { get; set; }
        [JsonProperty(PropertyName = "locations")] public List<locations> Locations { get; set; }
        [JsonProperty(PropertyName = "manufacturers")] public List<manufacturers> Manufacturers { get; set; }
        [JsonProperty(PropertyName = "milestones")] public List<milestones> Milestones { get; set; }
        [JsonProperty(PropertyName = "models")] public List<models> Models { get; set; }
        [JsonProperty(PropertyName = "monitoring_checks")] public List<monitoring_checks> Monitoring_checks{ get; set; }
        [JsonProperty(PropertyName = "monitoring_hosts")] public List<monitoring_hosts> Monitoring_hosts{ get; set; }
        [JsonProperty(PropertyName = "predefined_replies")] public List<predefined_replies> Predefined_replies{ get; set; }
        [JsonProperty(PropertyName = "projects")] public List<projects> Projects { get; set; }
        [JsonProperty(PropertyName = "roles")] public List<roles> Roles { get; set; }
        [JsonProperty(PropertyName = "staff")] public List<staff> Staff { get; set; }
        [JsonProperty(PropertyName = "status_labels")] public List<status_labels> Status_labels{ get; set; }
        [JsonProperty(PropertyName = "suppliers")] public List<suppliers> Suppliers { get; set; }
        [JsonProperty(PropertyName = "system_log")] public List<system_log> System_log{ get; set; }
        [JsonProperty(PropertyName = "ticket_departments")] public List<ticket_departments> Ticket_departments { get; set; }
        [JsonProperty(PropertyName = "ticket_replies")] public List<ticket_replies> Ticket_replies { get; set; }
        [JsonProperty(PropertyName = "tickets")] public List<tickets> Tickets { get; set; }
        [JsonProperty(PropertyName = "time_log")] public List<time_log> Time_log { get; set; }
        [JsonProperty(PropertyName = "users")] public List<users> Users { get; set; }
    }
}

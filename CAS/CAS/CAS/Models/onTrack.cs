namespace CAS.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OtAssetCategories
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<asset_categories> Asset_categories { get; set; }
    }
    public class OtAsset
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<assets> Assets { get; set; }
    }
    public class OtAuthenticate
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<authenticate> Authenticate { get; set; }
    }
    public class OtClients
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<clients> Clients { get; set; }
    }
    public class OtComments
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<comments> Comments { get; set; }
    }
    public class OtConfig
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<config> Config { get; set; }
    }
    public class OtContacts
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<contacts> Contacts { get; set; }
    }
    public class OtCredentials
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<credentials> Credentials { get; set; }
    }
    public class OtCustom_assets_fields
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<custom_asset_fields> Custom_asset_fields { get; set; }
    }
    public class OtCustom_licence_fields
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<custom_license_fields> Custom_license_fields { get; set; }
    }
    public class OtFiles
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<files> Files { get; set; }
    }
    public class OtIssues
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<issues> Issues { get; set; }
    }
    public class OtKb_articles
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<kb_articles> Kb_articles { get; set; }
    }
    public class OtKb_categories
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<kb_categories> Kb_categories { get; set; }
    }
    public class OtLanguages
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<languages> Languages { get; set; }
    }
    public class OtLicence_categories
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<licence_categories> Licence_categories { get; set; }
    }
    public class OtLicences
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<licenses> Licences { get; set; }
    }
    public class OtLocations
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<locations> Locations { get; set; }
    }
    public class OtManufacturers
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<manufacturers> Manufacturers { get; set; }
    }
    public class OtMilestones
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<milestones> Milestones { get; set; }
    }
    public class OtModels
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<models> Models { get; set; }
    }
    public class OtMonitoring_checks
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<monitoring_checks> Monitoring_checks { get; set; }
    }
    public class OtMonitoring_hosts
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<monitoring_hosts> Monitoring_hosts { get; set; }
    }
    public class OtPredefined_replies
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<predefined_replies> Predefined_replies { get; set; }
    }
    public class OtProjects
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<projects> Projects { get; set; }
    }
    public class OtRoles
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<roles> Roles { get; set; }
    }
    public class OtStaff
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<staff> Staff { get; set; }
    }
    public class OtStatus_labels
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<status_labels> Status_labels { get; set; }
    }
    public class OtSuppliers
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<suppliers> Suppliers { get; set; }
    }
    public class OtSystem_log
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<system_log> System_log { get; set; }
    }
    public class OtTicket_departments
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<ticket_departments> Ticket_departments { get; set; }
    }
    public class OtTicket_replies
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<ticket_replies> Ticket_replies { get; set; }
    }
    public class OtTickets
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<tickets> Tickets { get; set; }
    }
    public class OtTime_log
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<time_log> Time_log { get; set; }
    }
    public class OtUsers
    {
        [JsonProperty(PropertyName = "status")] public int Status { get; set; }
        [JsonProperty(PropertyName = "status_message")] public string Status_message { get; set; }
        [JsonProperty(PropertyName = "result")] public List<users> Users { get; set; }
    }
}

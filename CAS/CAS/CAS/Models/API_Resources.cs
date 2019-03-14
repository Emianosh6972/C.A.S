namespace CAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class API_Resources
    {
        public enum resource
        {
            clients,
            assets,
            licenses,
            credentials,
            asset_categories,
            license_categories,
            status_labels,
            manufacturers,
            models,
            locations,
            suppliers,
            projects,
            tickets,
            ticket_replies,
            issues,
            kb_categories,
            kb_articles,
            monitoring_hosts,
            monitoring_checks,
            users,
            staff,
            roles,
            languages,
            contacts,
            comments,
            milestones,
            predefined_replies,
            custom_asset_fields,
            custom_license_fields,
            config,
            ticket_departments,
            time_log,
            system_log,
            files,
            authenticate
        }
        public class clients
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "asset_tag_prefix")] public string Asset_tag_prefix { get; set; }
            [JsonProperty(PropertyName = "license_tag_prefix")] public string License_tag_prefix { get; set; }
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        }
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
        }
        public class licenses
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            public int clientid { get; set; }
            public int statusid { get; set; }
            public int categoryid { get; set; }
            public int supplierid { get; set; }
            public string seats { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string notes { get; set; }
            public custom_license_fields[] customfields { get; set; }
        }
        public class credentials
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "username")] public string Username { get; set; }
            [JsonProperty(PropertyName = "password")] public string Password { get; set; }
        }
        public class asset_categories
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "color")] public string Color { get; set; }
        }
        public class licence_categories
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "color")] public string Color { get; set; }
        }
        public class status_labels
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "color")] public string Color { get; set; }
        }
        public class manufacturers
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        }
        public class models
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        }
        public class locations
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "id")] public string Name { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
        }
        public class suppliers
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "address")] public string Address { get; set; }
            [JsonProperty(PropertyName = "contactname")] public string Contactname { get; set; }
            [JsonProperty(PropertyName = "phone")] public string Phone { get; set; }
            [JsonProperty(PropertyName = "email")] public string Email { get; set; }
            [JsonProperty(PropertyName = "web")] public string Web { get; set; }
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        }
        public class projects
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int clientid { get; set; }
            [JsonProperty(PropertyName = "tag")] public string Tag { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }
            [JsonProperty(PropertyName = "startdate")] public DateTime Startdate { get; set; }
            [JsonProperty(PropertyName = "deadline")] public DateTime Deadline { get; set; }
            [JsonProperty(PropertyName = "progress")] public int Progress { get; set; }
        }
        public class tickets
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "departmentid")] public int Departmentid { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
            [JsonProperty(PropertyName = "userid")] public int Userid { get; set; }
            [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
            [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "email")] public string Email { get; set; }
            [JsonProperty(PropertyName = "subject")] public string Subject { get; set; }
            [JsonProperty(PropertyName = "priority")] public string Priority { get; set; }            // Low Normal or High
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
            [JsonProperty(PropertyName = "css")] public string[] Ccs { get; set; }
            [JsonProperty(PropertyName = "message")] public string Message { get; set; }
            [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }              // open, in progress, answered, reopened, closed
        }
        public class ticket_replies
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "ticketid")] public int Ticketid { get; set; }
            [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
            [JsonProperty(PropertyName = "userid")] public int Userid { get; set; }
            [JsonProperty(PropertyName = "message")] public string Message { get; set; }
            [JsonProperty(PropertyName = "peopleid")] public int Peopleid { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }              // open, in progress, answered, reopened or closed, optional to change the status of a ticket after adding the reply
            [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
        }
        public class issues
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "assetid")] public int Assetid { get; set; }
            [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "adminid")] public int Adminid { get; set; }
            [JsonProperty(PropertyName = "issuetype")] public string Issuetype { get; set; }       // task, maintenance, bug, improvement, new feature or story
            [JsonProperty(PropertyName = "priority")] public string Priority { get; set; }        // to do, in progress, in review or done
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }
            [JsonProperty(PropertyName = "duedate")] public DateTime Duedate { get; set; }
        }
        public class kb_categories
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clients")] public clients[] Clients { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        }
        public class kb_articles
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "categoryid")] public int Categoryid { get; set; }
            [JsonProperty(PropertyName = "clients")] public clients[] Clients { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "content")] public string Content { get; set; }
        }
        public class monitoring_hosts
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "address")] public string Address { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }         // up, down, can be empty
        }
        public class monitoring_checks
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "hostid")] public int Hostid { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "port")] public string Port { get; set; }
            [JsonProperty(PropertyName = "monitoring")] public Boolean Monitoring { get; set; }
            [JsonProperty(PropertyName = "email")] public Boolean Email { get; set; }
            [JsonProperty(PropertyName = "sms")] public Boolean Sms { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }          // up, down, empty
        }
        public class users
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "roleid")] public int Roleid { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "email")] public string Email { get; set; }
            [JsonProperty(PropertyName = "ldap_user")] public string Ldap_user { get; set; }
            [JsonProperty(PropertyName = "title")] public int Title { get; set; }
            [JsonProperty(PropertyName = "mobile")] public string Mobile { get; set; }
            [JsonProperty(PropertyName = "password")] public string Password { get; set; }
            [JsonProperty(PropertyName = "notification")] public Boolean Notification { get; set; }
            [JsonProperty(PropertyName = "theme")] public string Theme { get; set; }           // skin-blue,skin-black,skin-purple,skin-green,skin-red,skin-yellow,skin-blue-light,skin-black-light,skin-purple-light,skin-green-light,skin-red-light,skin-yellow-light
            [JsonProperty(PropertyName = "sidebar")] public Boolean Sidebar { get; set; }        // opened or collapsed
            [JsonProperty(PropertyName = "layout")] public Boolean Layout { get; set; }         // empty for standard, fixed or layout-boxed
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
            [JsonProperty(PropertyName = "lang")] public string Lang { get; set; }
            [JsonProperty(PropertyName = "fcmtoken")] public string Fcmtoken { get; set; }
        }
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
        public class roles
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "fcmtoken")] public string Fcmtoken { get; set; }
          //[JsonProperty(PropertyName = "perms")] public [] Perms { get; set; }
        }
        public class languages
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "code")] public string Code { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        }
        public class contacts
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "email")] public string Email { get; set; }
            [JsonProperty(PropertyName = "phone")] public string Phone { get; set; }
            [JsonProperty(PropertyName = "address")] public string Address { get; set; }
            [JsonProperty(PropertyName = "webaddress")] public string Webaddress { get; set; }
            [JsonProperty(PropertyName = "notes")] public string Notes { get; set; }
        }
        public class comments
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "peopleid")] public int Peopleid { get; set; }
            [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "ticketid")] public int Ticketid { get; set; }
            [JsonProperty(PropertyName = "comment")] public string Comment { get; set; }
        }
        public class milestones
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "duedate")] public DateTime Duedate { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }

        }
        public class predefined_replies
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "content")] public string Content { get; set; }
        }
        public class custom_asset_fields
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }
            [JsonProperty(PropertyName = "options")] public string Options { get; set; }
        }
        public class custom_license_fields
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }
            [JsonProperty(PropertyName = "options")] public string Options { get; set; }
        }
        public class ticket_departments
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "email")] public string Email { get; set; }
        }
        public class config
        {
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "value")] public string Value { get; set; }
        }
        public class time_log
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "staffid")] public int Staffid { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "issues")] public issues[] Issues { get; set; }
            [JsonProperty(PropertyName = "tickets")] public tickets[] Tickets { get; set; }
            [JsonProperty(PropertyName = "description")] public string Description { get; set; }
            [JsonProperty(PropertyName = "date")] public DateTime Date { get; set; }
            [JsonProperty(PropertyName = "start")] public DateTime Start { get; set; }
            [JsonProperty(PropertyName = "end")] public DateTime End { get; set; }
        }
        public class system_log
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "peopleid")] public int peopleid { get; set; }
            [JsonProperty(PropertyName = "name")] public string Description { get; set; }
        }
        public class files
        {
            [JsonProperty(PropertyName = "id")] public int Id { get; set; }
            [JsonProperty(PropertyName = "clientid")] public int Clientid { get; set; }
            [JsonProperty(PropertyName = "Projectid")] public int Projectid { get; set; }
            [JsonProperty(PropertyName = "Assetid")] public int Assetid { get; set; }
            [JsonProperty(PropertyName = "Ticketreplyid")] public int Ticketreplyid { get; set; }
            [JsonProperty(PropertyName = "name")] public string Name { get; set; }
            [JsonProperty(PropertyName = "file")] public files[] File { get; set; }
        }
        public class authenticate
        {
            [JsonProperty(PropertyName = "username")] public string Username { get; set; }
            [JsonProperty(PropertyName = "password")] public string Password { get; set; }
        }
    }
}

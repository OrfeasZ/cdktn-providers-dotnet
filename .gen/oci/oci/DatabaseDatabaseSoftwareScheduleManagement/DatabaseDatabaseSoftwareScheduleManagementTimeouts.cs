using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseSoftwareScheduleManagement
{
    [JsiiByValue(fqn: "oci.databaseDatabaseSoftwareScheduleManagement.DatabaseDatabaseSoftwareScheduleManagementTimeouts")]
    public class DatabaseDatabaseSoftwareScheduleManagementTimeouts : oci.DatabaseDatabaseSoftwareScheduleManagement.IDatabaseDatabaseSoftwareScheduleManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database_software_schedule_management#create DatabaseDatabaseSoftwareScheduleManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database_software_schedule_management#delete DatabaseDatabaseSoftwareScheduleManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database_software_schedule_management#update DatabaseDatabaseSoftwareScheduleManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails")]
    public class DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#time_of_last_readiness_check DatabaseDatabase#time_of_last_readiness_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfLastReadinessCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfLastReadinessCheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#time_of_status_update DatabaseDatabase#time_of_status_update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfStatusUpdate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfStatusUpdate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#time_scheduled DatabaseDatabase#time_scheduled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeScheduled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#update_readiness_status DatabaseDatabase#update_readiness_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateReadinessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateReadinessStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#update_readiness_status_details DatabaseDatabase#update_readiness_status_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateReadinessStatusDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateReadinessStatusDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#version DatabaseDatabase#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}

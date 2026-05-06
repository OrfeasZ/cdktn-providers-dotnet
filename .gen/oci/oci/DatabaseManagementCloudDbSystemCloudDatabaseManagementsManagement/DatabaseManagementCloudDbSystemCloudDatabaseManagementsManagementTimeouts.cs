using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts")]
    public class DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts : oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#create DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#delete DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#update DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

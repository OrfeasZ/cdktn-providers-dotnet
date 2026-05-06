using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement
{
    [JsiiByValue(fqn: "oci.databaseExternalNonContainerDatabaseOperationsInsightsManagement.DatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts")]
    public class DatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts : oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement.IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#create DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#delete DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#update DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

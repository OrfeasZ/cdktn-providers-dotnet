using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperations")]
    public class DatabaseManagementCloudDbSystemDiscoveryPatchOperations : oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#operation DatabaseManagementCloudDbSystemDiscovery#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#selection DatabaseManagementCloudDbSystemDiscovery#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#value DatabaseManagementCloudDbSystemDiscovery#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue\"}", isOptional: true)]
        public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue? Value
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector")]
    public class DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector : oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connector_type DatabaseManagementCloudDbSystemDiscovery#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#display_name DatabaseManagementCloudDbSystemDiscovery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#agent_id DatabaseManagementCloudDbSystemDiscovery#agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentId
        {
            get;
            set;
        }

        /// <summary>connection_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connection_info DatabaseManagementCloudDbSystemDiscovery#connection_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionInfo", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo\"}", isOptional: true)]
        public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo? ConnectionInfo
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemDiscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo")]
    public class DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo : oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#component_type DatabaseManagementExternalDbSystemDiscovery#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentType
        {
            get;
            set;
        }

        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connection_credentials DatabaseManagementExternalDbSystemDiscovery#connection_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials\"}", isOptional: true)]
        public oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials? ConnectionCredentials
        {
            get;
            set;
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connection_string DatabaseManagementExternalDbSystemDiscovery#connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString\"}", isOptional: true)]
        public oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString? ConnectionString
        {
            get;
            set;
        }
    }
}

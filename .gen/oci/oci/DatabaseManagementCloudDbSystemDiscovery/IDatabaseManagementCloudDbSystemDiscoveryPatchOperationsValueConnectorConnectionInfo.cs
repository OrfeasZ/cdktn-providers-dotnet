using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo")]
    public interface IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#component_type DatabaseManagementCloudDbSystemDiscovery#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentType
        {
            get;
        }

        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connection_credentials DatabaseManagementCloudDbSystemDiscovery#connection_credentials}
        /// </remarks>
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials? ConnectionCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connection_string DatabaseManagementCloudDbSystemDiscovery#connection_string}
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString? ConnectionString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#component_type DatabaseManagementCloudDbSystemDiscovery#component_type}.</summary>
            [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connection_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connection_credentials DatabaseManagementCloudDbSystemDiscovery#connection_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials\"}", isOptional: true)]
            public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials? ConnectionCredentials
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connection_string DatabaseManagementCloudDbSystemDiscovery#connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString\"}", isOptional: true)]
            public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString? ConnectionString
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionString?>();
            }
        }
    }
}

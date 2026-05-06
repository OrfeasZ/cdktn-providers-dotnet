using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector")]
    public interface IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connector_type DatabaseManagementExternalDbSystemDiscovery#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#display_name DatabaseManagementExternalDbSystemDiscovery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#agent_id DatabaseManagementExternalDbSystemDiscovery#agent_id}.</summary>
        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connection_info DatabaseManagementExternalDbSystemDiscovery#connection_info}
        /// </remarks>
        [JsiiProperty(name: "connectionInfo", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo? ConnectionInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connector_type DatabaseManagementExternalDbSystemDiscovery#connector_type}.</summary>
            [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#display_name DatabaseManagementExternalDbSystemDiscovery#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#agent_id DatabaseManagementExternalDbSystemDiscovery#agent_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connection_info DatabaseManagementExternalDbSystemDiscovery#connection_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionInfo", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo\"}", isOptional: true)]
            public oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo? ConnectionInfo
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfo?>();
            }
        }
    }
}

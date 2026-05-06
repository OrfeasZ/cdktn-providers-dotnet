using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemConnectorConnectionInfo), fullyQualifiedName: "oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfo")]
    public interface IDatabaseManagementCloudDbSystemConnectorConnectionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#component_type DatabaseManagementCloudDbSystemConnector#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentType
        {
            get;
        }

        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_credentials DatabaseManagementCloudDbSystemConnector#connection_credentials}
        /// </remarks>
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_string DatabaseManagementCloudDbSystemConnector#connection_string}
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemConnectorConnectionInfo), fullyQualifiedName: "oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#component_type DatabaseManagementCloudDbSystemConnector#component_type}.</summary>
            [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connection_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_credentials DatabaseManagementCloudDbSystemConnector#connection_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_string DatabaseManagementCloudDbSystemConnector#connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionString
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfo")]
    public class DatabaseManagementCloudDbSystemConnectorConnectionInfo : oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#component_type DatabaseManagementCloudDbSystemConnector#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentType
        {
            get;
            set;
        }

        private object? _connectionCredentials;

        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_credentials DatabaseManagementCloudDbSystemConnector#connection_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConnectionCredentials
        {
            get => _connectionCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectionCredentials = value;
            }
        }

        private object? _connectionString;

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_connector#connection_string DatabaseManagementCloudDbSystemConnector#connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementCloudDbSystemConnector.DatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConnectionString
        {
            get => _connectionString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementCloudDbSystemConnector.IDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectionString = value;
            }
        }
    }
}

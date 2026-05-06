using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfo")]
    public class DatabaseManagementExternalDbSystemConnectorConnectionInfo : oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#component_type DatabaseManagementExternalDbSystemConnector#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentType
        {
            get;
            set;
        }

        private object? _connectionCredentials;

        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#connection_credentials DatabaseManagementExternalDbSystemConnector#connection_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectionCredentials = value;
            }
        }

        private object? _connectionString;

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#connection_string DatabaseManagementExternalDbSystemConnector#connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectionString = value;
            }
        }
    }
}

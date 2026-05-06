using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails")]
    public class DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails : oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#credential_type DatabaseManagementExternalMySqlDatabaseConnector#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#display_name DatabaseManagementExternalMySqlDatabaseConnector#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#external_database_id DatabaseManagementExternalMySqlDatabaseConnector#external_database_id}.</summary>
        [JsiiProperty(name: "externalDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#host_name DatabaseManagementExternalMySqlDatabaseConnector#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public string HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#macs_agent_id DatabaseManagementExternalMySqlDatabaseConnector#macs_agent_id}.</summary>
        [JsiiProperty(name: "macsAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public string MacsAgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#network_protocol DatabaseManagementExternalMySqlDatabaseConnector#network_protocol}.</summary>
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#port DatabaseManagementExternalMySqlDatabaseConnector#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#ssl_secret_id DatabaseManagementExternalMySqlDatabaseConnector#ssl_secret_id}.</summary>
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SslSecretId
        {
            get;
            set;
        }
    }
}

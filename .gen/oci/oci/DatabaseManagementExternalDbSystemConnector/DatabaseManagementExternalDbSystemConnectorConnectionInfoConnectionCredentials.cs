using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemConnector
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials")]
    public class DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials : oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#credential_name DatabaseManagementExternalDbSystemConnector#credential_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#credential_type DatabaseManagementExternalDbSystemConnector#credential_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#password_secret_id DatabaseManagementExternalDbSystemConnector#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#role DatabaseManagementExternalDbSystemConnector#role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#ssl_secret_id DatabaseManagementExternalDbSystemConnector#ssl_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_connector#user_name DatabaseManagementExternalDbSystemConnector#user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserName
        {
            get;
            set;
        }
    }
}

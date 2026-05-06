using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalExadataStorageConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfo")]
    public class DatabaseManagementExternalExadataStorageConnectorCredentialInfo : oci.DatabaseManagementExternalExadataStorageConnector.IDatabaseManagementExternalExadataStorageConnectorCredentialInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#password DatabaseManagementExternalExadataStorageConnector#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#username DatabaseManagementExternalExadataStorageConnector#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_location DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStoreLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_password DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStorePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_type DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStoreType
        {
            get;
            set;
        }
    }
}

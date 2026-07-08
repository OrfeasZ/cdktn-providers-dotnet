using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataStorageConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementCloudExadataStorageConnector.DatabaseManagementCloudExadataStorageConnectorCredentialInfo")]
    public class DatabaseManagementCloudExadataStorageConnectorCredentialInfo : oci.DatabaseManagementCloudExadataStorageConnector.IDatabaseManagementCloudExadataStorageConnectorCredentialInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_connector#password DatabaseManagementCloudExadataStorageConnector#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_connector#username DatabaseManagementCloudExadataStorageConnector#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_location DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStoreLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_password DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStorePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_type DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslTrustStoreType
        {
            get;
            set;
        }
    }
}

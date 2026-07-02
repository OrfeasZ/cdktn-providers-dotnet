using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataStorageConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudExadataStorageConnectorCredentialInfo), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageConnector.DatabaseManagementCloudExadataStorageConnectorCredentialInfo")]
    public interface IDatabaseManagementCloudExadataStorageConnectorCredentialInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#password DatabaseManagementCloudExadataStorageConnector#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#username DatabaseManagementCloudExadataStorageConnector#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_location DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_location}.</summary>
        [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStoreLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_password DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_password}.</summary>
        [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStorePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_type DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_type}.</summary>
        [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStoreType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudExadataStorageConnectorCredentialInfo), fullyQualifiedName: "oci.databaseManagementCloudExadataStorageConnector.DatabaseManagementCloudExadataStorageConnectorCredentialInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudExadataStorageConnector.IDatabaseManagementCloudExadataStorageConnectorCredentialInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#password DatabaseManagementCloudExadataStorageConnector#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#username DatabaseManagementCloudExadataStorageConnector#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_location DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStoreLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_password DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStorePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_management_cloud_exadata_storage_connector#ssl_trust_store_type DatabaseManagementCloudExadataStorageConnector#ssl_trust_store_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStoreType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

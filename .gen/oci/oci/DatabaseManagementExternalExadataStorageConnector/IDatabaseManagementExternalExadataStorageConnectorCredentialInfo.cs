using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalExadataStorageConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalExadataStorageConnectorCredentialInfo), fullyQualifiedName: "oci.databaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfo")]
    public interface IDatabaseManagementExternalExadataStorageConnectorCredentialInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#password DatabaseManagementExternalExadataStorageConnector#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#username DatabaseManagementExternalExadataStorageConnector#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_location DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_location}.</summary>
        [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStoreLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_password DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_password}.</summary>
        [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStorePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_type DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_type}.</summary>
        [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslTrustStoreType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalExadataStorageConnectorCredentialInfo), fullyQualifiedName: "oci.databaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalExadataStorageConnector.IDatabaseManagementExternalExadataStorageConnectorCredentialInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#password DatabaseManagementExternalExadataStorageConnector#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#username DatabaseManagementExternalExadataStorageConnector#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_location DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStoreLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_password DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStorePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_storage_connector#ssl_trust_store_type DatabaseManagementExternalExadataStorageConnector#ssl_trust_store_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslTrustStoreType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

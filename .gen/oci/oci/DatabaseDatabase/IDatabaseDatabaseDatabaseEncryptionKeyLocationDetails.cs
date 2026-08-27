using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetails")]
    public interface IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#provider_type DatabaseDatabase#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#aws_encryption_key_id DatabaseDatabase#aws_encryption_key_id}.</summary>
        [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#azure_encryption_key_id DatabaseDatabase#azure_encryption_key_id}.</summary>
        [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#google_cloud_provider_encryption_key_id DatabaseDatabase#google_cloud_provider_encryption_key_id}.</summary>
        [JsiiProperty(name: "googleCloudProviderEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GoogleCloudProviderEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#hsm_password DatabaseDatabase#hsm_password}.</summary>
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HsmPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#provider_type DatabaseDatabase#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#aws_encryption_key_id DatabaseDatabase#aws_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#azure_encryption_key_id DatabaseDatabase#azure_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#google_cloud_provider_encryption_key_id DatabaseDatabase#google_cloud_provider_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "googleCloudProviderEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GoogleCloudProviderEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#hsm_password DatabaseDatabase#hsm_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HsmPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

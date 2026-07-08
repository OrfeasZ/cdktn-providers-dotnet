using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseEncryptionKeyLocationDetails")]
    public interface IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#provider_type DatabaseDbHome#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#aws_encryption_key_id DatabaseDbHome#aws_encryption_key_id}.</summary>
        [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#azure_encryption_key_id DatabaseDbHome#azure_encryption_key_id}.</summary>
        [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#google_cloud_provider_encryption_key_id DatabaseDbHome#google_cloud_provider_encryption_key_id}.</summary>
        [JsiiProperty(name: "googleCloudProviderEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GoogleCloudProviderEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#hsm_password DatabaseDbHome#hsm_password}.</summary>
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HsmPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseEncryptionKeyLocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbHome.IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#provider_type DatabaseDbHome#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#aws_encryption_key_id DatabaseDbHome#aws_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#azure_encryption_key_id DatabaseDbHome#azure_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#google_cloud_provider_encryption_key_id DatabaseDbHome#google_cloud_provider_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "googleCloudProviderEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GoogleCloudProviderEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_db_home#hsm_password DatabaseDbHome#hsm_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HsmPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

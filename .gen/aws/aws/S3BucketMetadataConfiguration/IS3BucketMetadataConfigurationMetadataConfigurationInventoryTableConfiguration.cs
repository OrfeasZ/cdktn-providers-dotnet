using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration")]
    public interface IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#configuration_state S3BucketMetadataConfiguration#configuration_state}.</summary>
        [JsiiProperty(name: "configurationState", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationState
        {
            get;
        }

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#encryption_configuration S3BucketMetadataConfiguration#encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#configuration_state S3BucketMetadataConfiguration#configuration_state}.</summary>
            [JsiiProperty(name: "configurationState", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationState
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#encryption_configuration S3BucketMetadataConfiguration#encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EncryptionConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

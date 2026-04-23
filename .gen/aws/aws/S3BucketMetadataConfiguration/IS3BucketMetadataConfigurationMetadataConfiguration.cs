using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfiguration")]
    public interface IS3BucketMetadataConfigurationMetadataConfiguration
    {
        /// <summary>inventory_table_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#inventory_table_configuration S3BucketMetadataConfiguration#inventory_table_configuration}
        /// </remarks>
        [JsiiProperty(name: "inventoryTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InventoryTableConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>journal_table_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#journal_table_configuration S3BucketMetadataConfiguration#journal_table_configuration}
        /// </remarks>
        [JsiiProperty(name: "journalTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JournalTableConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inventory_table_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#inventory_table_configuration S3BucketMetadataConfiguration#inventory_table_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inventoryTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InventoryTableConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>journal_table_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#journal_table_configuration S3BucketMetadataConfiguration#journal_table_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "journalTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JournalTableConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

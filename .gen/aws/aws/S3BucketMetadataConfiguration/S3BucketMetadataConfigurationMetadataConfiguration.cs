using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfiguration")]
    public class S3BucketMetadataConfigurationMetadataConfiguration : aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfiguration
    {
        private object? _inventoryTableConfiguration;

        /// <summary>inventory_table_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#inventory_table_configuration S3BucketMetadataConfiguration#inventory_table_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inventoryTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InventoryTableConfiguration
        {
            get => _inventoryTableConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inventoryTableConfiguration = value;
            }
        }

        private object? _journalTableConfiguration;

        /// <summary>journal_table_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#journal_table_configuration S3BucketMetadataConfiguration#journal_table_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "journalTableConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JournalTableConfiguration
        {
            get => _journalTableConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _journalTableConfiguration = value;
            }
        }
    }
}

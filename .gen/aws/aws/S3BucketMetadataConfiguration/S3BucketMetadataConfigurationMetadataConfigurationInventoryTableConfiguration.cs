using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration")]
    public class S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration : aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#configuration_state S3BucketMetadataConfiguration#configuration_state}.</summary>
        [JsiiProperty(name: "configurationState", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigurationState
        {
            get;
            set;
        }

        private object? _encryptionConfiguration;

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#encryption_configuration S3BucketMetadataConfiguration#encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EncryptionConfiguration
        {
            get => _encryptionConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _encryptionConfiguration = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration")]
    public interface IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_metadata_configuration#expiration S3BucketMetadataConfiguration#expiration}.</summary>
        [JsiiProperty(name: "expiration", typeJson: "{\"primitive\":\"string\"}")]
        string Expiration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_metadata_configuration#days S3BucketMetadataConfiguration#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_metadata_configuration#expiration S3BucketMetadataConfiguration#expiration}.</summary>
            [JsiiProperty(name: "expiration", typeJson: "{\"primitive\":\"string\"}")]
            public string Expiration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_metadata_configuration#days S3BucketMetadataConfiguration#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

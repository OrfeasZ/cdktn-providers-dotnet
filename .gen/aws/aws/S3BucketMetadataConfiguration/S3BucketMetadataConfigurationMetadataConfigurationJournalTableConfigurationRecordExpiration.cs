using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration")]
    public class S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration : aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationRecordExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#expiration S3BucketMetadataConfiguration#expiration}.</summary>
        [JsiiProperty(name: "expiration", typeJson: "{\"primitive\":\"string\"}")]
        public string Expiration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#days S3BucketMetadataConfiguration#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}

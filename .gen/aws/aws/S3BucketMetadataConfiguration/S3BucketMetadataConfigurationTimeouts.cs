using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationTimeouts")]
    public class S3BucketMetadataConfigurationTimeouts : aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_metadata_configuration#create S3BucketMetadataConfiguration#create}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}

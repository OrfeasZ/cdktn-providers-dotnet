using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold")]
    public class S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold : aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#days S3BucketObjectLockConfigurationA#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#years S3BucketObjectLockConfigurationA#years}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Years
        {
            get;
            set;
        }
    }
}

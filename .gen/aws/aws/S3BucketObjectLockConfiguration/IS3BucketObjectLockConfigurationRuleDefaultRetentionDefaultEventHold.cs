using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold")]
    public interface IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#days S3BucketObjectLockConfigurationA#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#years S3BucketObjectLockConfigurationA#years}.</summary>
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Years
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#days S3BucketObjectLockConfigurationA#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#years S3BucketObjectLockConfigurationA#years}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Years
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

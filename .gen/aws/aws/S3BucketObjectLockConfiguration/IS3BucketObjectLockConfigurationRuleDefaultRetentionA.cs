using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetentionA), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA")]
    public interface IS3BucketObjectLockConfigurationRuleDefaultRetentionA
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

        /// <summary>default_event_hold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#default_event_hold S3BucketObjectLockConfigurationA#default_event_hold}
        /// </remarks>
        [JsiiProperty(name: "defaultEventHold", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold? DefaultEventHold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#mode S3BucketObjectLockConfigurationA#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
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

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetentionA), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA
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

            /// <summary>default_event_hold block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#default_event_hold S3BucketObjectLockConfigurationA#default_event_hold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEventHold", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold\"}", isOptional: true)]
            public aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold? DefaultEventHold
            {
                get => GetInstanceProperty<aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionDefaultEventHold?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/s3_bucket_object_lock_configuration#mode S3BucketObjectLockConfigurationA#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
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

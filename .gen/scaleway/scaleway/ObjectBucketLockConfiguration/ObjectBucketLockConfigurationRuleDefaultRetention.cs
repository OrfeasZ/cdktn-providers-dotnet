using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketLockConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention")]
    public class ObjectBucketLockConfigurationRuleDefaultRetention : scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention
    {
        /// <summary>The default Object Lock retention mode you want to apply to new objects placed in the specified bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_lock_configuration#mode ObjectBucketLockConfiguration#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>The number of days that you want to specify for the default retention period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_lock_configuration#days ObjectBucketLockConfiguration#days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        /// <summary>The number of years that you want to specify for the default retention period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_lock_configuration#years ObjectBucketLockConfiguration#years}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Years
        {
            get;
            set;
        }
    }
}

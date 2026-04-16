using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketLockConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRule")]
    public class ObjectBucketLockConfigurationRule : scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#default_retention ObjectBucketLockConfiguration#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention\"}")]
        public scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention DefaultRetention
        {
            get;
            set;
        }
    }
}

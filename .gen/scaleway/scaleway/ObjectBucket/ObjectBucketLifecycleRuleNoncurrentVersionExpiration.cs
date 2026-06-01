using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiByValue(fqn: "scaleway.objectBucket.ObjectBucketLifecycleRuleNoncurrentVersionExpiration")]
    public class ObjectBucketLifecycleRuleNoncurrentVersionExpiration : scaleway.ObjectBucket.IObjectBucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Number of noncurrent versions Scaleway Object Storage will retain. Must be a non-zero positive integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#newer_noncurrent_versions ObjectBucket#newer_noncurrent_versions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newerNoncurrentVersions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NewerNoncurrentVersions
        {
            get;
            set;
        }

        /// <summary>Number of days an object is noncurrent before Scaleway Object Storage can perform the associated action.</summary>
        /// <remarks>
        /// Must be a positive integer
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#noncurrent_days ObjectBucket#noncurrent_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NoncurrentDays
        {
            get;
            set;
        }
    }
}

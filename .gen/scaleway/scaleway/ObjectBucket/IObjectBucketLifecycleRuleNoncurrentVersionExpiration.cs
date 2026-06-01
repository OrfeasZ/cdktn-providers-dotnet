using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleNoncurrentVersionExpiration")]
    public interface IObjectBucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Number of noncurrent versions Scaleway Object Storage will retain. Must be a non-zero positive integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#newer_noncurrent_versions ObjectBucket#newer_noncurrent_versions}
        /// </remarks>
        [JsiiProperty(name: "newerNoncurrentVersions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NewerNoncurrentVersions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of days an object is noncurrent before Scaleway Object Storage can perform the associated action.</summary>
        /// <remarks>
        /// Must be a positive integer
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#noncurrent_days ObjectBucket#noncurrent_days}
        /// </remarks>
        [JsiiProperty(name: "noncurrentDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NoncurrentDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleNoncurrentVersionExpiration")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketLifecycleRuleNoncurrentVersionExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of noncurrent versions Scaleway Object Storage will retain. Must be a non-zero positive integer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#newer_noncurrent_versions ObjectBucket#newer_noncurrent_versions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newerNoncurrentVersions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NewerNoncurrentVersions
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

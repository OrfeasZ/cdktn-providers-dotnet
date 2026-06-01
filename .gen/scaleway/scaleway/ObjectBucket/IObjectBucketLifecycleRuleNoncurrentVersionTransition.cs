using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLifecycleRuleNoncurrentVersionTransition), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleNoncurrentVersionTransition")]
    public interface IObjectBucketLifecycleRuleNoncurrentVersionTransition
    {
        /// <summary>Number of days an object is noncurrent before Scaleway Object Storage can perform the associated action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#noncurrent_days ObjectBucket#noncurrent_days}
        /// </remarks>
        [JsiiProperty(name: "noncurrentDays", typeJson: "{\"primitive\":\"number\"}")]
        double NoncurrentDays
        {
            get;
        }

        /// <summary>Specifies the Scaleway Object Storage class to which you want the object to transition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#storage_class ObjectBucket#storage_class}
        /// </remarks>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClass
        {
            get;
        }

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

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLifecycleRuleNoncurrentVersionTransition), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleNoncurrentVersionTransition")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketLifecycleRuleNoncurrentVersionTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of days an object is noncurrent before Scaleway Object Storage can perform the associated action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#noncurrent_days ObjectBucket#noncurrent_days}
            /// </remarks>
            [JsiiProperty(name: "noncurrentDays", typeJson: "{\"primitive\":\"number\"}")]
            public double NoncurrentDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Specifies the Scaleway Object Storage class to which you want the object to transition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#storage_class ObjectBucket#storage_class}
            /// </remarks>
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClass
            {
                get => GetInstanceProperty<string>()!;
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
        }
    }
}

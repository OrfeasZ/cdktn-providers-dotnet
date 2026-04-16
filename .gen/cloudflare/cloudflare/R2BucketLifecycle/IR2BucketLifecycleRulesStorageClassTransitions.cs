using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiInterface(nativeType: typeof(IR2BucketLifecycleRulesStorageClassTransitions), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions")]
    public interface IR2BucketLifecycleRulesStorageClassTransitions
    {
        /// <summary>Condition for lifecycle transitions to apply after an object reaches an age in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#condition R2BucketLifecycle#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsCondition\"}")]
        cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitionsCondition Condition
        {
            get;
        }

        /// <summary>Available values: "InfrequentAccess".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#storage_class R2BucketLifecycle#storage_class}
        /// </remarks>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClass
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLifecycleRulesStorageClassTransitions), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Condition for lifecycle transitions to apply after an object reaches an age in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#condition R2BucketLifecycle#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsCondition\"}")]
            public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitionsCondition Condition
            {
                get => GetInstanceProperty<cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitionsCondition>()!;
            }

            /// <summary>Available values: "InfrequentAccess".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#storage_class R2BucketLifecycle#storage_class}
            /// </remarks>
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClass
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

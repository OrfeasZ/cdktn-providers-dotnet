using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiInterface(nativeType: typeof(IR2BucketLifecycleRulesConditions), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions")]
    public interface IR2BucketLifecycleRulesConditions
    {
        /// <summary>Transitions will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#prefix R2BucketLifecycle#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLifecycleRulesConditions), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Transitions will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#prefix R2BucketLifecycle#prefix}
            /// </remarks>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiInterface(nativeType: typeof(IR2BucketLifecycleRulesDeleteObjectsTransition), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition")]
    public interface IR2BucketLifecycleRulesDeleteObjectsTransition
    {
        /// <summary>Condition for lifecycle transitions to apply after an object reaches an age in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#condition R2BucketLifecycle#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransitionCondition? Condition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLifecycleRulesDeleteObjectsTransition), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Condition for lifecycle transitions to apply after an object reaches an age in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#condition R2BucketLifecycle#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionCondition\"}", isOptional: true)]
            public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransitionCondition? Condition
            {
                get => GetInstanceProperty<cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransitionCondition?>();
            }
        }
    }
}

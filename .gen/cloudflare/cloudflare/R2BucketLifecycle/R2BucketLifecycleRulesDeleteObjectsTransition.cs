using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiByValue(fqn: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition")]
    public class R2BucketLifecycleRulesDeleteObjectsTransition : cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition
    {
        /// <summary>Condition for lifecycle transitions to apply after an object reaches an age in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#condition R2BucketLifecycle#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionCondition\"}", isOptional: true)]
        public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransitionCondition? Condition
        {
            get;
            set;
        }
    }
}

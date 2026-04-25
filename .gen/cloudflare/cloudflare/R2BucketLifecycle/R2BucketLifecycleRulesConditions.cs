using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions")]
    public class R2BucketLifecycleRulesConditions : cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions
    {
        /// <summary>Transitions will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#prefix R2BucketLifecycle#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }
    }
}

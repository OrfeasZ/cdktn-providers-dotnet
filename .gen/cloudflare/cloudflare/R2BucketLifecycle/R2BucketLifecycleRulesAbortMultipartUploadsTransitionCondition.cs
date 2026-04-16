using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition")]
    public class R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition : cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#max_age R2BucketLifecycle#max_age}.</summary>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxAge
        {
            get;
            set;
        }

        /// <summary>Available values: "Age".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#type R2BucketLifecycle#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}

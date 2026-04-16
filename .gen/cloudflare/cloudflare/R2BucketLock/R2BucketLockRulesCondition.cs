using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLock
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2BucketLock.R2BucketLockRulesCondition")]
    public class R2BucketLockRulesCondition : cloudflare.R2BucketLock.IR2BucketLockRulesCondition
    {
        /// <summary>Available values: "Age", "Date", "Indefinite".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#type R2BucketLock#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#date R2BucketLock#date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Date
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#max_age_seconds R2BucketLock#max_age_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAgeSeconds
        {
            get;
            set;
        }
    }
}

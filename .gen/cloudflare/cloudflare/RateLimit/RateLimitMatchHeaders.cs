using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiByValue(fqn: "cloudflare.rateLimit.RateLimitMatchHeaders")]
    public class RateLimitMatchHeaders : cloudflare.RateLimit.IRateLimitMatchHeaders
    {
        /// <summary>The name of the response header to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#name RateLimit#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The operator used when matching: `eq` means "equal" and `ne` means "not equal". Available values: "eq", "ne".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#op RateLimit#op}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "op", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Op
        {
            get;
            set;
        }

        /// <summary>The value of the response header, which must match exactly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#value RateLimit#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiByValue(fqn: "cloudflare.rateLimit.RateLimitMatchRequest")]
    public class RateLimitMatchRequest : cloudflare.RateLimit.IRateLimitMatchRequest
    {
        /// <summary>The HTTP methods to match.</summary>
        /// <remarks>
        /// You can specify a subset (for example, <c>['POST','PUT']</c>) or all methods (<c>['_ALL_']</c>). This field is optional when creating a rate limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#methods RateLimit#methods}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "methods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Methods
        {
            get;
            set;
        }

        /// <summary>The HTTP schemes to match.</summary>
        /// <remarks>
        /// You can specify one scheme (<c>['HTTPS']</c>), both schemes (<c>['HTTP','HTTPS']</c>), or all schemes (<c>['_ALL_']</c>). This field is optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#schemes RateLimit#schemes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Schemes
        {
            get;
            set;
        }

        /// <summary>The URL pattern to match, composed of a host and a path such as `example.org/path*`. Normalization is applied before the pattern is matched. `*` wildcards are expanded to match applicable traffic. Query strings are not matched. Set the value to `*` to match all traffic to your zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#url RateLimit#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }
    }
}

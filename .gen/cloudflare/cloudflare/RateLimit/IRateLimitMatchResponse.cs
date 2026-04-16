using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiInterface(nativeType: typeof(IRateLimitMatchResponse), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatchResponse")]
    public interface IRateLimitMatchResponse
    {
        /// <summary>When true, only the uncached traffic served from your origin servers will count towards rate limiting.</summary>
        /// <remarks>
        /// In this case, any cached traffic served by Cloudflare will not count towards rate limiting. This field is optional.
        /// Notes: This field is deprecated. Instead, use response headers and set "origin_traffic" to "false" to avoid legacy behaviour interacting with the "response_headers" property.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#origin_traffic RateLimit#origin_traffic}
        /// </remarks>
        [JsiiProperty(name: "originTraffic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginTraffic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRateLimitMatchResponse), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatchResponse")]
        internal sealed class _Proxy : DeputyBase, cloudflare.RateLimit.IRateLimitMatchResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When true, only the uncached traffic served from your origin servers will count towards rate limiting.</summary>
            /// <remarks>
            /// In this case, any cached traffic served by Cloudflare will not count towards rate limiting. This field is optional.
            /// Notes: This field is deprecated. Instead, use response headers and set "origin_traffic" to "false" to avoid legacy behaviour interacting with the "response_headers" property.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#origin_traffic RateLimit#origin_traffic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originTraffic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OriginTraffic
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

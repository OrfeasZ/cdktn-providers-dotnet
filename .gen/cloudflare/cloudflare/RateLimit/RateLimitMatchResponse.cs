using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiByValue(fqn: "cloudflare.rateLimit.RateLimitMatchResponse")]
    public class RateLimitMatchResponse : cloudflare.RateLimit.IRateLimitMatchResponse
    {
        private object? _originTraffic;

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
            get => _originTraffic;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _originTraffic = value;
            }
        }
    }
}

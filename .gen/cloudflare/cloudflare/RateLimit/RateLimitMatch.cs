using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiByValue(fqn: "cloudflare.rateLimit.RateLimitMatch")]
    public class RateLimitMatch : cloudflare.RateLimit.IRateLimitMatch
    {
        private object? _headers;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#headers RateLimit#headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.RateLimit.IRateLimitMatchHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.RateLimit.IRateLimitMatchHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#request RateLimit#request}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "request", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchRequest\"}", isOptional: true)]
        public cloudflare.RateLimit.IRateLimitMatchRequest? Request
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#response RateLimit#response}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchResponse\"}", isOptional: true)]
        public cloudflare.RateLimit.IRateLimitMatchResponse? Response
        {
            get;
            set;
        }
    }
}

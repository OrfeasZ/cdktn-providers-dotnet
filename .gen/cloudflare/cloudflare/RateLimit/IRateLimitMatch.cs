using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiInterface(nativeType: typeof(IRateLimitMatch), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatch")]
    public interface IRateLimitMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#headers RateLimit#headers}.</summary>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#request RateLimit#request}.</summary>
        [JsiiProperty(name: "request", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.RateLimit.IRateLimitMatchRequest? Request
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#response RateLimit#response}.</summary>
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.RateLimit.IRateLimitMatchResponse? Response
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRateLimitMatch), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatch")]
        internal sealed class _Proxy : DeputyBase, cloudflare.RateLimit.IRateLimitMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#headers RateLimit#headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#request RateLimit#request}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "request", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchRequest\"}", isOptional: true)]
            public cloudflare.RateLimit.IRateLimitMatchRequest? Request
            {
                get => GetInstanceProperty<cloudflare.RateLimit.IRateLimitMatchRequest?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#response RateLimit#response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatchResponse\"}", isOptional: true)]
            public cloudflare.RateLimit.IRateLimitMatchResponse? Response
            {
                get => GetInstanceProperty<cloudflare.RateLimit.IRateLimitMatchResponse?>();
            }
        }
    }
}

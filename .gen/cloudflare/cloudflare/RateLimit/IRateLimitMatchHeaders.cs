using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiInterface(nativeType: typeof(IRateLimitMatchHeaders), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatchHeaders")]
    public interface IRateLimitMatchHeaders
    {
        /// <summary>The name of the response header to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#name RateLimit#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The operator used when matching: `eq` means "equal" and `ne` means "not equal". Available values: "eq", "ne".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#op RateLimit#op}
        /// </remarks>
        [JsiiProperty(name: "op", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Op
        {
            get
            {
                return null;
            }
        }

        /// <summary>The value of the response header, which must match exactly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#value RateLimit#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRateLimitMatchHeaders), fullyQualifiedName: "cloudflare.rateLimit.RateLimitMatchHeaders")]
        internal sealed class _Proxy : DeputyBase, cloudflare.RateLimit.IRateLimitMatchHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the response header to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#name RateLimit#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The operator used when matching: `eq` means "equal" and `ne` means "not equal". Available values: "eq", "ne".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#op RateLimit#op}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "op", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Op
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The value of the response header, which must match exactly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#value RateLimit#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

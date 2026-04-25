using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstancePublicEndpointParamsRateLimit), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit")]
    public interface IAiSearchInstancePublicEndpointParamsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#period_ms AiSearchInstance#period_ms}.</summary>
        [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeriodMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#requests AiSearchInstance#requests}.</summary>
        [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#technique AiSearchInstance#technique}
        /// </remarks>
        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Technique
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstancePublicEndpointParamsRateLimit), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#period_ms AiSearchInstance#period_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeriodMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#requests AiSearchInstance#requests}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Requests
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Available values: "fixed", "sliding".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#technique AiSearchInstance#technique}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Technique
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

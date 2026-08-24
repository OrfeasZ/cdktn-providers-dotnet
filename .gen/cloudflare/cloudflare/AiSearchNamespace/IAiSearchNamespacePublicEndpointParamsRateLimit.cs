using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchNamespace
{
    [JsiiInterface(nativeType: typeof(IAiSearchNamespacePublicEndpointParamsRateLimit), fullyQualifiedName: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit")]
    public interface IAiSearchNamespacePublicEndpointParamsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#period_ms AiSearchNamespace#period_ms}.</summary>
        [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeriodMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#requests AiSearchNamespace#requests}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#technique AiSearchNamespace#technique}
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

        [JsiiTypeProxy(nativeType: typeof(IAiSearchNamespacePublicEndpointParamsRateLimit), fullyQualifiedName: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#period_ms AiSearchNamespace#period_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeriodMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#requests AiSearchNamespace#requests}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Requests
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Available values: "fixed", "sliding".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#technique AiSearchNamespace#technique}
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

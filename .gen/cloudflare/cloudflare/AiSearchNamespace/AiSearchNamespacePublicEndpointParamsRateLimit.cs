using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchNamespace
{
    [JsiiByValue(fqn: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit")]
    public class AiSearchNamespacePublicEndpointParamsRateLimit : cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#period_ms AiSearchNamespace#period_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#requests AiSearchNamespace#requests}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Requests
        {
            get;
            set;
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#technique AiSearchNamespace#technique}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Technique
        {
            get;
            set;
        }
    }
}

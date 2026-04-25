using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit")]
    public class AiSearchInstancePublicEndpointParamsRateLimit : cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#period_ms AiSearchInstance#period_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#requests AiSearchInstance#requests}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Requests
        {
            get;
            set;
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#technique AiSearchInstance#technique}
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

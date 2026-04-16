using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptions")]
    public class AiSearchInstanceRetrievalOptions : cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptions
    {
        /// <summary>Controls how keyword search terms are matched.</summary>
        /// <remarks>
        /// exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
        /// Available values: "exact_match", "fuzzy_match".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#keyword_match_mode AiSearchInstance#keyword_match_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keywordMatchMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordMatchMode
        {
            get;
            set;
        }
    }
}

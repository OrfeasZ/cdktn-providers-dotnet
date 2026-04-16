using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceRetrievalOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptions")]
    public interface IAiSearchInstanceRetrievalOptions
    {
        /// <summary>Controls how keyword search terms are matched.</summary>
        /// <remarks>
        /// exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
        /// Available values: "exact_match", "fuzzy_match".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#keyword_match_mode AiSearchInstance#keyword_match_mode}
        /// </remarks>
        [JsiiProperty(name: "keywordMatchMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeywordMatchMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceRetrievalOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

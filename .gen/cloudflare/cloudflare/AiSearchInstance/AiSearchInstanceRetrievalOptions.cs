using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptions")]
    public class AiSearchInstanceRetrievalOptions : cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptions
    {
        private object? _boostBy;

        /// <summary>Metadata fields to boost search results by.</summary>
        /// <remarks>
        /// Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#boost_by AiSearchInstance#boost_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boostBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptionsBoostBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BoostBy
        {
            get => _boostBy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptionsBoostBy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptionsBoostBy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _boostBy = value;
            }
        }

        /// <summary>Controls which documents are candidates for BM25 scoring.</summary>
        /// <remarks>
        /// 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
        /// Available values: "and", "or".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#keyword_match_mode AiSearchInstance#keyword_match_mode}
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

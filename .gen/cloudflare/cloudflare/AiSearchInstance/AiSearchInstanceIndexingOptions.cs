using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceIndexingOptions")]
    public class AiSearchInstanceIndexingOptions : cloudflare.AiSearchInstance.IAiSearchInstanceIndexingOptions
    {
        /// <summary>Tokenizer used for keyword search indexing.</summary>
        /// <remarks>
        /// porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
        /// Available values: "porter", "trigram".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#keyword_tokenizer AiSearchInstance#keyword_tokenizer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keywordTokenizer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordTokenizer
        {
            get;
            set;
        }
    }
}

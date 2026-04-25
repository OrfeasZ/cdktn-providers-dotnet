using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptionsBoostBy")]
    public class AiSearchInstanceRetrievalOptionsBoostBy : cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptionsBoostBy
    {
        /// <summary>Metadata field name to boost by.</summary>
        /// <remarks>
        /// Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#field AiSearchInstance#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Boost direction.</summary>
        /// <remarks>
        /// 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional - defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
        /// Available values: "asc", "desc", "exists", "not_exists".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#direction AiSearchInstance#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceRetrievalOptionsBoostBy), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptionsBoostBy")]
    public interface IAiSearchInstanceRetrievalOptionsBoostBy
    {
        /// <summary>Metadata field name to boost by.</summary>
        /// <remarks>
        /// Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#field AiSearchInstance#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        /// <summary>Boost direction.</summary>
        /// <remarks>
        /// 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional - defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
        /// Available values: "asc", "desc", "exists", "not_exists".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#direction AiSearchInstance#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceRetrievalOptionsBoostBy), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceRetrievalOptionsBoostBy")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceRetrievalOptionsBoostBy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Metadata field name to boost by.</summary>
            /// <remarks>
            /// Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#field AiSearchInstance#field}
            /// </remarks>
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

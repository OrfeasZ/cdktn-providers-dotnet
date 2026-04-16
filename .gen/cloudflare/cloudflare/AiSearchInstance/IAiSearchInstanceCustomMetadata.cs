using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceCustomMetadata), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceCustomMetadata")]
    public interface IAiSearchInstanceCustomMetadata
    {
        /// <summary>Available values: "text", "number", "boolean".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#data_type AiSearchInstance#data_type}
        /// </remarks>
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        string DataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#field_name AiSearchInstance#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        string FieldName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceCustomMetadata), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceCustomMetadata")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceCustomMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "text", "number", "boolean".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#data_type AiSearchInstance#data_type}
            /// </remarks>
            [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#field_name AiSearchInstance#field_name}.</summary>
            [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

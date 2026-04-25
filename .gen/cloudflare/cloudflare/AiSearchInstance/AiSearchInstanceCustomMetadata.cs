using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceCustomMetadata")]
    public class AiSearchInstanceCustomMetadata : cloudflare.AiSearchInstance.IAiSearchInstanceCustomMetadata
    {
        /// <summary>Available values: "text", "number", "boolean", "datetime".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#data_type AiSearchInstance#data_type}
        /// </remarks>
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public string DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#field_name AiSearchInstance#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldName
        {
            get;
            set;
        }
    }
}

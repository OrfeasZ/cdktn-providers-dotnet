using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceMetadataCreatedFromEmdashPlugin")]
    public class AiSearchInstanceMetadataCreatedFromEmdashPlugin : cloudflare.AiSearchInstance.IAiSearchInstanceMetadataCreatedFromEmdashPlugin
    {
        /// <summary>Available values: "native", "rest".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#type AiSearchInstance#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#version AiSearchInstance#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceMetadataCreatedFromEmdashPlugin), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceMetadataCreatedFromEmdashPlugin")]
    public interface IAiSearchInstanceMetadataCreatedFromEmdashPlugin
    {
        /// <summary>Available values: "native", "rest".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#type AiSearchInstance#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#version AiSearchInstance#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceMetadataCreatedFromEmdashPlugin), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceMetadataCreatedFromEmdashPlugin")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceMetadataCreatedFromEmdashPlugin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "native", "rest".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#type AiSearchInstance#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/ai_search_instance#version AiSearchInstance#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

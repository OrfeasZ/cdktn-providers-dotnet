using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentApiKeys), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentApiKeys")]
    public interface IDataDigitaloceanAgentPlatformAgentApiKeys
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#api_key DataDigitaloceanAgentPlatformAgent#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentApiKeys), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentApiKeys")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentApiKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#api_key DataDigitaloceanAgentPlatformAgent#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

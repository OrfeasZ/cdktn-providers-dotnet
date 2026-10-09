using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentChatbotIdentifiers), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChatbotIdentifiers")]
    public interface IDataDigitaloceanAgentPlatformAgentChatbotIdentifiers
    {
        /// <summary>Chatbot ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#chatbot_id DataDigitaloceanAgentPlatformAgent#chatbot_id}
        /// </remarks>
        [JsiiProperty(name: "chatbotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ChatbotId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentChatbotIdentifiers), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChatbotIdentifiers")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentChatbotIdentifiers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Chatbot ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#chatbot_id DataDigitaloceanAgentPlatformAgent#chatbot_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chatbotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ChatbotId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

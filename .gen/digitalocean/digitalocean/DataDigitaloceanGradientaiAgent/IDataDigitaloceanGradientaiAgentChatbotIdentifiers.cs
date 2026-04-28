using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiAgentChatbotIdentifiers), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentChatbotIdentifiers")]
    public interface IDataDigitaloceanGradientaiAgentChatbotIdentifiers
    {
        /// <summary>Chatbot ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#chatbot_id DataDigitaloceanGradientaiAgent#chatbot_id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiAgentChatbotIdentifiers), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentChatbotIdentifiers")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentChatbotIdentifiers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Chatbot ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#chatbot_id DataDigitaloceanGradientaiAgent#chatbot_id}
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

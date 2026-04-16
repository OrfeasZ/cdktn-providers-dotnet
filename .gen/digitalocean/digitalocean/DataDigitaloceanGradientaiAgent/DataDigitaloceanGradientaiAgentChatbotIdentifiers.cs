using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentChatbotIdentifiers")]
    public class DataDigitaloceanGradientaiAgentChatbotIdentifiers : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentChatbotIdentifiers
    {
        /// <summary>Chatbot ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#chatbot_id DataDigitaloceanGradientaiAgent#chatbot_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatbotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChatbotId
        {
            get;
            set;
        }
    }
}

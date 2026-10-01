using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChatbotIdentifiers")]
    public class DataDigitaloceanAgentPlatformAgentChatbotIdentifiers : digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentChatbotIdentifiers
    {
        /// <summary>Chatbot ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#chatbot_id DataDigitaloceanAgentPlatformAgent#chatbot_id}
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

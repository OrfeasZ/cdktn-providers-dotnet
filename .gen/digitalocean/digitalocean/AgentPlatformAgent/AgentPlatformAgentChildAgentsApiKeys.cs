using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeys")]
    public class AgentPlatformAgentChildAgentsApiKeys : digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#api_key AgentPlatformAgent#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }
    }
}

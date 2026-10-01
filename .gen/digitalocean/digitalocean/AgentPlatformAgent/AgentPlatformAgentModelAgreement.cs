using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformAgent.AgentPlatformAgentModelAgreement")]
    public class AgentPlatformAgentModelAgreement : digitalocean.AgentPlatformAgent.IAgentPlatformAgentModelAgreement
    {
        /// <summary>Description of the agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Name of the agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>URL of the agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#url AgentPlatformAgent#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>UUID of the agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}

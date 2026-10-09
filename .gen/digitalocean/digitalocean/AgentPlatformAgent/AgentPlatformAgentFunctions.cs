using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformAgent.AgentPlatformAgentFunctions")]
    public class AgentPlatformAgentFunctions : digitalocean.AgentPlatformAgent.IAgentPlatformAgentFunctions
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#api_key AgentPlatformAgent#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }

        /// <summary>Description of the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#faasname AgentPlatformAgent#faasname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "faasname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Faasname
        {
            get;
            set;
        }

        /// <summary>Namespace of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#faasnamespace AgentPlatformAgent#faasnamespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "faasnamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Faasnamespace
        {
            get;
            set;
        }

        /// <summary>Guardrail UUID for the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#guardrail_uuid AgentPlatformAgent#guardrail_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuardrailUuid
        {
            get;
            set;
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Url of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#url AgentPlatformAgent#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformAgent.AgentPlatformAgentParentAgentsChatbot")]
    public class AgentPlatformAgentParentAgentsChatbot : digitalocean.AgentPlatformAgent.IAgentPlatformAgentParentAgentsChatbot
    {
        /// <summary>Background color for the chatbot button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#button_background_color AgentPlatformAgent#button_background_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buttonBackgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ButtonBackgroundColor
        {
            get;
            set;
        }

        /// <summary>Logo for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#logo AgentPlatformAgent#logo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Logo
        {
            get;
            set;
        }

        /// <summary>Name of the chatbot.</summary>
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

        /// <summary>Primary color for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#primary_color AgentPlatformAgent#primary_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryColor
        {
            get;
            set;
        }

        /// <summary>Secondary color for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#secondary_color AgentPlatformAgent#secondary_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecondaryColor
        {
            get;
            set;
        }

        /// <summary>Starting message for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#starting_message AgentPlatformAgent#starting_message}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startingMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingMessage
        {
            get;
            set;
        }
    }
}

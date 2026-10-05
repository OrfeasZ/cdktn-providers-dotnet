using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChatbot")]
    public class DataDigitaloceanAgentPlatformAgentChatbot : digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentChatbot
    {
        /// <summary>Background color for the chatbot button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#button_background_color DataDigitaloceanAgentPlatformAgent#button_background_color}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#logo DataDigitaloceanAgentPlatformAgent#logo}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#primary_color DataDigitaloceanAgentPlatformAgent#primary_color}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#secondary_color DataDigitaloceanAgentPlatformAgent#secondary_color}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agent#starting_message DataDigitaloceanAgentPlatformAgent#starting_message}
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

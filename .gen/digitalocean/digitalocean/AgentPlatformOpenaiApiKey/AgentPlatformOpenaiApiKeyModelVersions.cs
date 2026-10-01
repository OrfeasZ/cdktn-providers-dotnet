using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformOpenaiApiKey
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformOpenaiApiKey.AgentPlatformOpenaiApiKeyModelVersions")]
    public class AgentPlatformOpenaiApiKeyModelVersions : digitalocean.AgentPlatformOpenaiApiKey.IAgentPlatformOpenaiApiKeyModelVersions
    {
        /// <summary>Major version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_openai_api_key#major AgentPlatformOpenaiApiKey#major}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "major", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Major
        {
            get;
            set;
        }

        /// <summary>Minor version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_openai_api_key#minor AgentPlatformOpenaiApiKey#minor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minor
        {
            get;
            set;
        }

        /// <summary>Patch version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_openai_api_key#patch AgentPlatformOpenaiApiKey#patch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Patch
        {
            get;
            set;
        }
    }
}

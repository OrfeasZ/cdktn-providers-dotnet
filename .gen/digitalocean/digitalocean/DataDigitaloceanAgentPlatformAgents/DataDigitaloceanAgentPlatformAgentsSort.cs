using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgents
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsSort")]
    public class DataDigitaloceanAgentPlatformAgentsSort : digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agents#key DataDigitaloceanAgentPlatformAgents#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agents#direction DataDigitaloceanAgentPlatformAgents#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}

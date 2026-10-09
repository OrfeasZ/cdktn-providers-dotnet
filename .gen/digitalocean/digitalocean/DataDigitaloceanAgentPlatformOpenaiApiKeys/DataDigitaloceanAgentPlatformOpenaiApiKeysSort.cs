using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformOpenaiApiKeys
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformOpenaiApiKeys.DataDigitaloceanAgentPlatformOpenaiApiKeysSort")]
    public class DataDigitaloceanAgentPlatformOpenaiApiKeysSort : digitalocean.DataDigitaloceanAgentPlatformOpenaiApiKeys.IDataDigitaloceanAgentPlatformOpenaiApiKeysSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#key DataDigitaloceanAgentPlatformOpenaiApiKeys#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#direction DataDigitaloceanAgentPlatformOpenaiApiKeys#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}

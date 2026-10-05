using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformKnowledgeBases
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformKnowledgeBases.DataDigitaloceanAgentPlatformKnowledgeBasesSort")]
    public class DataDigitaloceanAgentPlatformKnowledgeBasesSort : digitalocean.DataDigitaloceanAgentPlatformKnowledgeBases.IDataDigitaloceanAgentPlatformKnowledgeBasesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_knowledge_bases#key DataDigitaloceanAgentPlatformKnowledgeBases#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_knowledge_bases#direction DataDigitaloceanAgentPlatformKnowledgeBases#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}

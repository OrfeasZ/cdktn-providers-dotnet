using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource")]
    public class AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource : digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource
    {
        /// <summary>The name of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#bucket_name AgentPlatformKnowledgeBase#bucket_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>The path to the item in the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#item_path AgentPlatformKnowledgeBase#item_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "itemPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ItemPath
        {
            get;
            set;
        }

        /// <summary>The region of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#region AgentPlatformKnowledgeBase#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}

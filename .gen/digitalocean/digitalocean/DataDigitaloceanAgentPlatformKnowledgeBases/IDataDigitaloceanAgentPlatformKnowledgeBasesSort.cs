using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformKnowledgeBases
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformKnowledgeBasesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformKnowledgeBases.DataDigitaloceanAgentPlatformKnowledgeBasesSort")]
    public interface IDataDigitaloceanAgentPlatformKnowledgeBasesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_knowledge_bases#key DataDigitaloceanAgentPlatformKnowledgeBases#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_knowledge_bases#direction DataDigitaloceanAgentPlatformKnowledgeBases#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformKnowledgeBasesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformKnowledgeBases.DataDigitaloceanAgentPlatformKnowledgeBasesSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformKnowledgeBases.IDataDigitaloceanAgentPlatformKnowledgeBasesSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_knowledge_bases#key DataDigitaloceanAgentPlatformKnowledgeBases#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_knowledge_bases#direction DataDigitaloceanAgentPlatformKnowledgeBases#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

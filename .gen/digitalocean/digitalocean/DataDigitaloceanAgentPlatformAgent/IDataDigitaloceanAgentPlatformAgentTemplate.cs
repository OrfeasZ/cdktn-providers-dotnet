using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentTemplate), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplate")]
    public interface IDataDigitaloceanAgentPlatformAgentTemplate
    {
        /// <summary>Description of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Instruction for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#instruction DataDigitaloceanAgentPlatformAgent#instruction}
        /// </remarks>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instruction
        {
            get
            {
                return null;
            }
        }

        /// <summary>K value for the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#k DataDigitaloceanAgentPlatformAgent#k}
        /// </remarks>
        [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? K
        {
            get
            {
                return null;
            }
        }

        /// <summary>knowledge_bases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#knowledge_bases DataDigitaloceanAgentPlatformAgent#knowledge_bases}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplateKnowledgeBases" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplateKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum tokens allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#max_tokens DataDigitaloceanAgentPlatformAgent#max_tokens}
        /// </remarks>
        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTokens
        {
            get
            {
                return null;
            }
        }

        /// <summary>model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#model DataDigitaloceanAgentPlatformAgent#model}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplateModel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplateModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Agent temperature setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#temperature DataDigitaloceanAgentPlatformAgent#temperature}
        /// </remarks>
        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Temperature
        {
            get
            {
                return null;
            }
        }

        /// <summary>Top P sampling parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#top_p DataDigitaloceanAgentPlatformAgent#top_p}
        /// </remarks>
        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TopP
        {
            get
            {
                return null;
            }
        }

        /// <summary>uuid of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentTemplate), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplate")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Description of the Agent Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Instruction for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#instruction DataDigitaloceanAgentPlatformAgent#instruction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instruction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>K value for the Agent Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#k DataDigitaloceanAgentPlatformAgent#k}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? K
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>knowledge_bases block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#knowledge_bases DataDigitaloceanAgentPlatformAgent#knowledge_bases}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplateKnowledgeBases" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplateKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum tokens allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#max_tokens DataDigitaloceanAgentPlatformAgent#max_tokens}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTokens
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>model block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#model DataDigitaloceanAgentPlatformAgent#model}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplateModel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplateModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Model
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the Agent Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Agent temperature setting.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#temperature DataDigitaloceanAgentPlatformAgent#temperature}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Temperature
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Top P sampling parameter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#top_p DataDigitaloceanAgentPlatformAgent#top_p}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TopP
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>uuid of the Agent Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

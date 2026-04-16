using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplate")]
    public class DataDigitaloceanGradientaiAgentTemplate : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplate
    {
        /// <summary>Description of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#description DataDigitaloceanGradientaiAgent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Instruction for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#instruction DataDigitaloceanGradientaiAgent#instruction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instruction
        {
            get;
            set;
        }

        /// <summary>K value for the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#k DataDigitaloceanGradientaiAgent#k}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? K
        {
            get;
            set;
        }

        private object? _knowledgeBases;

        /// <summary>knowledge_bases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#knowledge_bases DataDigitaloceanGradientaiAgent#knowledge_bases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplateKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KnowledgeBases
        {
            get => _knowledgeBases;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateKnowledgeBases[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateKnowledgeBases).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _knowledgeBases = value;
            }
        }

        /// <summary>Maximum tokens allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#max_tokens DataDigitaloceanGradientaiAgent#max_tokens}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTokens
        {
            get;
            set;
        }

        private object? _model;

        /// <summary>model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#model DataDigitaloceanGradientaiAgent#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplateModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Model
        {
            get => _model;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _model = value;
            }
        }

        /// <summary>Name of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Agent temperature setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#temperature DataDigitaloceanGradientaiAgent#temperature}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Temperature
        {
            get;
            set;
        }

        /// <summary>Top P sampling parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#top_p DataDigitaloceanGradientaiAgent#top_p}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TopP
        {
            get;
            set;
        }

        /// <summary>uuid of the Agent Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#uuid DataDigitaloceanGradientaiAgent#uuid}
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

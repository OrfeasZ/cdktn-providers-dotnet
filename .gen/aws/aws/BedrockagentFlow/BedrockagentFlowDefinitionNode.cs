using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNode")]
    public class BedrockagentFlowDefinitionNode : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#name BedrockagentFlow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#type BedrockagentFlow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _configuration;

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#configuration BedrockagentFlow#configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Configuration
        {
            get => _configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configuration = value;
            }
        }

        private object? _input;

        /// <summary>input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#input BedrockagentFlow#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Input
        {
            get => _input;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeInput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeInput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _input = value;
            }
        }

        private object? _output;

        /// <summary>output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#output BedrockagentFlow#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Output
        {
            get => _output;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeOutput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeOutput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _output = value;
            }
        }
    }
}

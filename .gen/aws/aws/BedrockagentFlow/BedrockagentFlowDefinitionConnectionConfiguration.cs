using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfiguration")]
    public class BedrockagentFlowDefinitionConnectionConfiguration : aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfiguration
    {
        private object? _conditional;

        /// <summary>conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#conditional BedrockagentFlow#conditional}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Conditional
        {
            get => _conditional;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationConditional[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationConditional).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditional = value;
            }
        }

        private object? _data;

        /// <summary>data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#data BedrockagentFlow#data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Data
        {
            get => _data;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _data = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPrompt")]
    public class BedrockagentFlowDefinitionNodeConfigurationPrompt : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPrompt
    {
        private object? _guardrailConfiguration;

        /// <summary>guardrail_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_configuration BedrockagentFlow#guardrail_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GuardrailConfiguration
        {
            get => _guardrailConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _guardrailConfiguration = value;
            }
        }

        private object? _sourceConfiguration;

        /// <summary>source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#source_configuration BedrockagentFlow#source_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceConfiguration
        {
            get => _sourceConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceConfiguration = value;
            }
        }
    }
}

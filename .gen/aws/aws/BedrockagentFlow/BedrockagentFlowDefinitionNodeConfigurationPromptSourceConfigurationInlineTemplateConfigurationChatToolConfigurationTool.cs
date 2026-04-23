using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool")]
    public class BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool
    {
        private object? _cachePoint;

        /// <summary>cache_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#cache_point BedrockagentFlow#cache_point}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cachePoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CachePoint
        {
            get => _cachePoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cachePoint = value;
            }
        }

        private object? _toolSpec;

        /// <summary>tool_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool_spec BedrockagentFlow#tool_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "toolSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ToolSpec
        {
            get => _toolSpec;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _toolSpec = value;
            }
        }
    }
}

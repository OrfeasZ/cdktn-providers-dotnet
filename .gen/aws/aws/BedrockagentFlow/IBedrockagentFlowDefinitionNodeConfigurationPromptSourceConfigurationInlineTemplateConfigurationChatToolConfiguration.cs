using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration
    {
        /// <summary>tool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool BedrockagentFlow#tool}
        /// </remarks>
        [JsiiProperty(name: "tool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tool
        {
            get
            {
                return null;
            }
        }

        /// <summary>tool_choice block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool_choice BedrockagentFlow#tool_choice}
        /// </remarks>
        [JsiiProperty(name: "toolChoice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolChoice
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool BedrockagentFlow#tool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tool
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tool_choice block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool_choice BedrockagentFlow#tool_choice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolChoice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolChoice
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice
    {
        /// <summary>any block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#any BedrockagentFlow#any}
        /// </remarks>
        [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Any
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#auto BedrockagentFlow#auto}
        /// </remarks>
        [JsiiProperty(name: "auto", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Auto
        {
            get
            {
                return null;
            }
        }

        /// <summary>tool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool BedrockagentFlow#tool}
        /// </remarks>
        [JsiiProperty(name: "tool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tool
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>any block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#any BedrockagentFlow#any}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Any
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>auto block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#auto BedrockagentFlow#auto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auto", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Auto
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#tool BedrockagentFlow#tool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tool
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#text BedrockagentFlow#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        string Text
        {
            get;
        }

        /// <summary>cache_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#cache_point BedrockagentFlow#cache_point}
        /// </remarks>
        [JsiiProperty(name: "cachePoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CachePoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#input_variable BedrockagentFlow#input_variable}
        /// </remarks>
        [JsiiProperty(name: "inputVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputVariable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#text BedrockagentFlow#text}.</summary>
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
            public string Text
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cache_point block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#cache_point BedrockagentFlow#cache_point}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cachePoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CachePoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>input_variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#input_variable BedrockagentFlow#input_variable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputVariable
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

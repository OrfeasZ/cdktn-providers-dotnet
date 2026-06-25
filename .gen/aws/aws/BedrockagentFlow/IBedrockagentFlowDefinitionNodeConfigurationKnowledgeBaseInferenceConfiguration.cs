using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration
    {
        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagent_flow#text BedrockagentFlow#text}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagent_flow#text BedrockagentFlow#text}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Text
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

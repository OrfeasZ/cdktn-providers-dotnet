using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChatMessage), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessage")]
    public interface IBedrockagentPromptVariantTemplateConfigurationChatMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#role BedrockagentPrompt#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#content BedrockagentPrompt#content}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatMessageContent" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessageContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Content
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChatMessage), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessage")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatMessage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#role BedrockagentPrompt#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>content block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#content BedrockagentPrompt#content}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatMessageContent" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessageContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Content
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantTemplateConfiguration), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfiguration")]
    public interface IBedrockagentPromptVariantTemplateConfiguration
    {
        /// <summary>chat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_prompt#chat BedrockagentPrompt#chat}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChat" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "chat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Chat
        {
            get
            {
                return null;
            }
        }

        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_prompt#text BedrockagentPrompt#text}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationText" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantTemplateConfiguration), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>chat block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_prompt#chat BedrockagentPrompt#chat}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChat" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Chat
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_prompt#text BedrockagentPrompt#text}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationText" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Text
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

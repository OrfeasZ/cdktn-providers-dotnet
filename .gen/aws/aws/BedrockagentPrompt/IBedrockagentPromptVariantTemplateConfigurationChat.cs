using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChat), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChat")]
    public interface IBedrockagentPromptVariantTemplateConfigurationChat
    {
        /// <summary>input_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#input_variable BedrockagentPrompt#input_variable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatInputVariable" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "inputVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatInputVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputVariable
        {
            get
            {
                return null;
            }
        }

        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#message BedrockagentPrompt#message}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatMessage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#system BedrockagentPrompt#system}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatSystem" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "systemAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SystemAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>tool_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#tool_configuration BedrockagentPrompt#tool_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatToolConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "toolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatToolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChat), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChat")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>input_variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#input_variable BedrockagentPrompt#input_variable}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatInputVariable" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatInputVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputVariable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#message BedrockagentPrompt#message}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatMessage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Message
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#system BedrockagentPrompt#system}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatSystem" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SystemAttribute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tool_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_prompt#tool_configuration BedrockagentPrompt#tool_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatToolConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatToolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

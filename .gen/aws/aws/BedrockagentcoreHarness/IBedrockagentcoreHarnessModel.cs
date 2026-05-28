using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessModel), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModel")]
    public interface IBedrockagentcoreHarnessModel
    {
        /// <summary>bedrock_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#bedrock_model_config BedrockagentcoreHarness#bedrock_model_config}
        /// </remarks>
        [JsiiProperty(name: "bedrockModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelBedrockModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BedrockModelConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>gemini_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#gemini_model_config BedrockagentcoreHarness#gemini_model_config}
        /// </remarks>
        [JsiiProperty(name: "geminiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelGeminiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeminiModelConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>openai_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#openai_model_config BedrockagentcoreHarness#openai_model_config}
        /// </remarks>
        [JsiiProperty(name: "openaiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelOpenaiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpenaiModelConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessModel), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModel")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bedrock_model_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#bedrock_model_config BedrockagentcoreHarness#bedrock_model_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bedrockModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelBedrockModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BedrockModelConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>gemini_model_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#gemini_model_config BedrockagentcoreHarness#gemini_model_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geminiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelGeminiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GeminiModelConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>openai_model_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#openai_model_config BedrockagentcoreHarness#openai_model_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openaiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelOpenaiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpenaiModelConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

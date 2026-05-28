using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModel")]
    public class BedrockagentcoreHarnessModel : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModel
    {
        private object? _bedrockModelConfig;

        /// <summary>bedrock_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#bedrock_model_config BedrockagentcoreHarness#bedrock_model_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bedrockModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelBedrockModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BedrockModelConfig
        {
            get => _bedrockModelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelBedrockModelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelBedrockModelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bedrockModelConfig = value;
            }
        }

        private object? _geminiModelConfig;

        /// <summary>gemini_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#gemini_model_config BedrockagentcoreHarness#gemini_model_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geminiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelGeminiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeminiModelConfig
        {
            get => _geminiModelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelGeminiModelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelGeminiModelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geminiModelConfig = value;
            }
        }

        private object? _openaiModelConfig;

        /// <summary>openai_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#openai_model_config BedrockagentcoreHarness#openai_model_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openaiModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelOpenaiModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenaiModelConfig
        {
            get => _openaiModelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelOpenaiModelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelOpenaiModelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openaiModelConfig = value;
            }
        }
    }
}

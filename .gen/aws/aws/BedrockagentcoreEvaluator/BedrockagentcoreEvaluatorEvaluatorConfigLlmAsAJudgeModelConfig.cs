using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfig")]
    public class BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfig : aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfig
    {
        private object? _bedrockEvaluatorModelConfig;

        /// <summary>bedrock_evaluator_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_evaluator#bedrock_evaluator_model_config BedrockagentcoreEvaluator#bedrock_evaluator_model_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bedrockEvaluatorModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BedrockEvaluatorModelConfig
        {
            get => _bedrockEvaluatorModelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bedrockEvaluatorModelConfig = value;
            }
        }
    }
}

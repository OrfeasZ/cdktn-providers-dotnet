using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfig")]
    public class BedrockagentcoreEvaluatorEvaluatorConfig : aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfig
    {
        private object? _codeBased;

        /// <summary>code_based block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_evaluator#code_based BedrockagentcoreEvaluator#code_based}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeBased", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigCodeBased\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeBased
        {
            get => _codeBased;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigCodeBased).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeBased = value;
            }
        }

        private object? _llmAsAJudge;

        /// <summary>llm_as_a_judge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_evaluator#llm_as_a_judge BedrockagentcoreEvaluator#llm_as_a_judge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "llmAsAJudge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LlmAsAJudge
        {
            get => _llmAsAJudge;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudge[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudge).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _llmAsAJudge = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical), fullyQualifiedName: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical")]
    public interface IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_evaluator#definition BedrockagentcoreEvaluator#definition}.</summary>
        [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
        string Definition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_evaluator#label BedrockagentcoreEvaluator#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        string Label
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical), fullyQualifiedName: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_evaluator#definition BedrockagentcoreEvaluator#definition}.</summary>
            [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
            public string Definition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_evaluator#label BedrockagentcoreEvaluator#label}.</summary>
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
            public string Label
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

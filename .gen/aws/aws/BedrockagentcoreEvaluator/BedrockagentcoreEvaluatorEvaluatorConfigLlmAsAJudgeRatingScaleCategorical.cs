using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical")]
    public class BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical : aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagentcore_evaluator#definition BedrockagentcoreEvaluator#definition}.</summary>
        [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
        public string Definition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagentcore_evaluator#label BedrockagentcoreEvaluator#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public string Label
        {
            get;
            set;
        }
    }
}

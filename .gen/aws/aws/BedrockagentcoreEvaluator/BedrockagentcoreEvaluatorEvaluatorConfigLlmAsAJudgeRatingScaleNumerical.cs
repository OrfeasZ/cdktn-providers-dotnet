using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreEvaluator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreEvaluator.BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleNumerical")]
    public class BedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleNumerical : aws.BedrockagentcoreEvaluator.IBedrockagentcoreEvaluatorEvaluatorConfigLlmAsAJudgeRatingScaleNumerical
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_evaluator#definition BedrockagentcoreEvaluator#definition}.</summary>
        [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
        public string Definition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_evaluator#label BedrockagentcoreEvaluator#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public string Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_evaluator#value BedrockagentcoreEvaluator#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}

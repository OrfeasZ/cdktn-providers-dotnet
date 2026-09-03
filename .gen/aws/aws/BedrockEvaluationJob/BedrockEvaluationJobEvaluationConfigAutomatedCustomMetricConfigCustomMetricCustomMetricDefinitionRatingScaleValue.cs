using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue")]
    public class BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#float_value BedrockEvaluationJob#float_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "floatValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FloatValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#string_value BedrockEvaluationJob#string_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StringValue
        {
            get;
            set;
        }
    }
}

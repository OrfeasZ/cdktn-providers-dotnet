using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig")]
    public class BedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#latency BedrockEvaluationJob#latency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Latency
        {
            get;
            set;
        }
    }
}

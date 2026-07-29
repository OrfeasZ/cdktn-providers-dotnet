using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource")]
    public class BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#inference_source_identifier BedrockEvaluationJob#inference_source_identifier}.</summary>
        [JsiiProperty(name: "inferenceSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string InferenceSourceIdentifier
        {
            get;
            set;
        }
    }
}

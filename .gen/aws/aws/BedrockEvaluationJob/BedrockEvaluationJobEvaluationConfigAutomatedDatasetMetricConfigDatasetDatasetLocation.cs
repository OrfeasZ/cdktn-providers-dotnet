using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation")]
    public class BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#s3_uri BedrockEvaluationJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }
    }
}

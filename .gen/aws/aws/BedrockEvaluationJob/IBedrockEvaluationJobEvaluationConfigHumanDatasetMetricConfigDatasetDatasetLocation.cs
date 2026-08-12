using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation")]
    public interface IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#s3_uri BedrockEvaluationJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#s3_uri BedrockEvaluationJob#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

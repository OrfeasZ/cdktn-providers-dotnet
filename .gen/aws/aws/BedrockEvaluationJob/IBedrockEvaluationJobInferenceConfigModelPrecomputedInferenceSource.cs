using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource")]
    public interface IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#inference_source_identifier BedrockEvaluationJob#inference_source_identifier}.</summary>
        [JsiiProperty(name: "inferenceSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string InferenceSourceIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#inference_source_identifier BedrockEvaluationJob#inference_source_identifier}.</summary>
            [JsiiProperty(name: "inferenceSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string InferenceSourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

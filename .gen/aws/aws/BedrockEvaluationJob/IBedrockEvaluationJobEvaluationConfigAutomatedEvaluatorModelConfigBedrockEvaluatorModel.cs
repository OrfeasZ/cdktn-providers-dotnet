using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel")]
    public interface IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#model_identifier BedrockEvaluationJob#model_identifier}.</summary>
        [JsiiProperty(name: "modelIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ModelIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#model_identifier BedrockEvaluationJob#model_identifier}.</summary>
            [JsiiProperty(name: "modelIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig")]
    public interface IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#rag_source_identifier BedrockEvaluationJob#rag_source_identifier}.</summary>
        [JsiiProperty(name: "ragSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string RagSourceIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#rag_source_identifier BedrockEvaluationJob#rag_source_identifier}.</summary>
            [JsiiProperty(name: "ragSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string RagSourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

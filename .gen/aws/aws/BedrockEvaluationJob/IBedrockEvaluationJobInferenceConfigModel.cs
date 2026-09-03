using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobInferenceConfigModel), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModel")]
    public interface IBedrockEvaluationJobInferenceConfigModel
    {
        /// <summary>bedrock_model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#bedrock_model BedrockEvaluationJob#bedrock_model}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "bedrockModel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BedrockModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>precomputed_inference_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#precomputed_inference_source BedrockEvaluationJob#precomputed_inference_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "precomputedInferenceSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrecomputedInferenceSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobInferenceConfigModel), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModel")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bedrock_model block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#bedrock_model BedrockEvaluationJob#bedrock_model}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bedrockModel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BedrockModel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>precomputed_inference_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#precomputed_inference_source BedrockEvaluationJob#precomputed_inference_source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "precomputedInferenceSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrecomputedInferenceSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

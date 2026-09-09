using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockModelInvocationJobInputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfig")]
    public interface IBedrockModelInvocationJobInputDataConfig
    {
        /// <summary>s3_input_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_input_data_config BedrockModelInvocationJob#s3_input_data_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3InputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigS3InputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3InputDataConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockModelInvocationJobInputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_input_data_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_input_data_config BedrockModelInvocationJob#s3_input_data_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3InputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigS3InputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3InputDataConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

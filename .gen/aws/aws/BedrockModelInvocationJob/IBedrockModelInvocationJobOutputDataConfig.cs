using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockModelInvocationJobOutputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfig")]
    public interface IBedrockModelInvocationJobOutputDataConfig
    {
        /// <summary>s3_output_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_output_data_config BedrockModelInvocationJob#s3_output_data_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3OutputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigS3OutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3OutputDataConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockModelInvocationJobOutputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_output_data_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_output_data_config BedrockModelInvocationJob#s3_output_data_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3OutputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigS3OutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3OutputDataConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

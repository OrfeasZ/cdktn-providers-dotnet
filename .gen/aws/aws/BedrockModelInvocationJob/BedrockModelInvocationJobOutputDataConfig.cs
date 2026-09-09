using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiByValue(fqn: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfig")]
    public class BedrockModelInvocationJobOutputDataConfig : aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig
    {
        private object? _s3OutputDataConfig;

        /// <summary>s3_output_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_output_data_config BedrockModelInvocationJob#s3_output_data_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigS3OutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3OutputDataConfig
        {
            get => _s3OutputDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3OutputDataConfig = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiByValue(fqn: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfig")]
    public class BedrockModelInvocationJobInputDataConfig : aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig
    {
        private object? _s3InputDataConfig;

        /// <summary>s3_input_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_input_data_config BedrockModelInvocationJob#s3_input_data_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3InputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigS3InputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3InputDataConfig
        {
            get => _s3InputDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3InputDataConfig = value;
            }
        }
    }
}

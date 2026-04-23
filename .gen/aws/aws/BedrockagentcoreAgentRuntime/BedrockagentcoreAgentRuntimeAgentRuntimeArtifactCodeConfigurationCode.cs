using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCode")]
    public class BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCode : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCode
    {
        private object? _s3;

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#s3 BedrockagentcoreAgentRuntime#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCodeS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3
        {
            get => _s3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCodeS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationCodeS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3 = value;
            }
        }
    }
}

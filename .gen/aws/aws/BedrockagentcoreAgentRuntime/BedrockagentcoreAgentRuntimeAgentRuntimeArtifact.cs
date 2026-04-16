using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifact")]
    public class BedrockagentcoreAgentRuntimeAgentRuntimeArtifact : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifact
    {
        private object? _codeConfiguration;

        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#code_configuration BedrockagentcoreAgentRuntime#code_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeConfiguration
        {
            get => _codeConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeConfiguration = value;
            }
        }

        private object? _containerConfiguration;

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#container_configuration BedrockagentcoreAgentRuntime#container_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContainerConfiguration
        {
            get => _containerConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containerConfiguration = value;
            }
        }
    }
}

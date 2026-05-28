using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironment")]
    public class BedrockagentcoreHarnessEnvironment : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironment
    {
        private object? _agentcoreRuntimeEnvironment;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_runtime_environment BedrockagentcoreHarness#agentcore_runtime_environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentcoreRuntimeEnvironment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentcoreRuntimeEnvironment
        {
            get => _agentcoreRuntimeEnvironment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentcoreRuntimeEnvironment = value;
            }
        }
    }
}

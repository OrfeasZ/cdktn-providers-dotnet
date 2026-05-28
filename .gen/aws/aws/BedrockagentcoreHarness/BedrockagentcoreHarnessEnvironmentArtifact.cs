using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentArtifact")]
    public class BedrockagentcoreHarnessEnvironmentArtifact : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentArtifact
    {
        private object? _containerConfiguration;

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#container_configuration BedrockagentcoreHarness#container_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containerConfiguration = value;
            }
        }
    }
}

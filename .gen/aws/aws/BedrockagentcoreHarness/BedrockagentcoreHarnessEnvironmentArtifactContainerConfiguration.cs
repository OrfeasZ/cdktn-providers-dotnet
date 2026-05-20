using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration")]
    public class BedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#container_uri BedrockagentcoreHarness#container_uri}.</summary>
        [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerUri
        {
            get;
            set;
        }
    }
}

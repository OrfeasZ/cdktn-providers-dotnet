using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration")]
    public interface IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#container_uri BedrockagentcoreHarness#container_uri}.</summary>
        [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentArtifactContainerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#container_uri BedrockagentcoreHarness#container_uri}.</summary>
            [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

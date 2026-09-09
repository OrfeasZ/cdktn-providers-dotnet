using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSkillS3), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillS3")]
    public interface IBedrockagentcoreHarnessSkillS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#uri BedrockagentcoreHarness#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSkillS3), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillS3")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#uri BedrockagentcoreHarness#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

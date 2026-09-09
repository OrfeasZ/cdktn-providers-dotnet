using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSkillAwsSkills), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillAwsSkills")]
    public interface IBedrockagentcoreHarnessSkillAwsSkills
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#paths BedrockagentcoreHarness#paths}.</summary>
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Paths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSkillAwsSkills), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillAwsSkills")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillAwsSkills
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#paths BedrockagentcoreHarness#paths}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Paths
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSkillGitAuth), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGitAuth")]
    public interface IBedrockagentcoreHarnessSkillGitAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#credential_arn BedrockagentcoreHarness#credential_arn}.</summary>
        [JsiiProperty(name: "credentialArn", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#username BedrockagentcoreHarness#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSkillGitAuth), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGitAuth")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGitAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#credential_arn BedrockagentcoreHarness#credential_arn}.</summary>
            [JsiiProperty(name: "credentialArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#username BedrockagentcoreHarness#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

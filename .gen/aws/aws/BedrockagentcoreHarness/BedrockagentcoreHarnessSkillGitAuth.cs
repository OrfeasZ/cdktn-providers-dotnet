using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGitAuth")]
    public class BedrockagentcoreHarnessSkillGitAuth : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGitAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#credential_arn BedrockagentcoreHarness#credential_arn}.</summary>
        [JsiiProperty(name: "credentialArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#username BedrockagentcoreHarness#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}

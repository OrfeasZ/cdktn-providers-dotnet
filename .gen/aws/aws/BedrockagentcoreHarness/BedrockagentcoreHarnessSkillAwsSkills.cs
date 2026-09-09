using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillAwsSkills")]
    public class BedrockagentcoreHarnessSkillAwsSkills : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillAwsSkills
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#paths BedrockagentcoreHarness#paths}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Paths
        {
            get;
            set;
        }
    }
}

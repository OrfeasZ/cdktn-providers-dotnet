using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter")]
    public class BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#code_interpreter_arn BedrockagentcoreHarness#code_interpreter_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "codeInterpreterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CodeInterpreterArn
        {
            get;
            set;
        }
    }
}

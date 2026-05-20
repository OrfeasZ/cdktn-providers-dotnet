using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigInlineFunction")]
    public class BedrockagentcoreHarnessToolConfigInlineFunction : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigInlineFunction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#description BedrockagentcoreHarness#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#input_schema BedrockagentcoreHarness#input_schema}.</summary>
        [JsiiProperty(name: "inputSchema", typeJson: "{\"primitive\":\"string\"}")]
        public string InputSchema
        {
            get;
            set;
        }
    }
}

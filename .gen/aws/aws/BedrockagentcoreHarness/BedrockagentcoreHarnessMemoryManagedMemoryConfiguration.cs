using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryManagedMemoryConfiguration")]
    public class BedrockagentcoreHarnessMemoryManagedMemoryConfiguration : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#encryption_key_arn BedrockagentcoreHarness#encryption_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#event_expiry_duration BedrockagentcoreHarness#event_expiry_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventExpiryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EventExpiryDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#strategies BedrockagentcoreHarness#strategies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Strategies
        {
            get;
            set;
        }
    }
}

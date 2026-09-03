using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryManagedMemoryConfiguration")]
    public interface IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#encryption_key_arn BedrockagentcoreHarness#encryption_key_arn}.</summary>
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#event_expiry_duration BedrockagentcoreHarness#event_expiry_duration}.</summary>
        [JsiiProperty(name: "eventExpiryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EventExpiryDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#strategies BedrockagentcoreHarness#strategies}.</summary>
        [JsiiProperty(name: "strategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Strategies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryManagedMemoryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#encryption_key_arn BedrockagentcoreHarness#encryption_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#event_expiry_duration BedrockagentcoreHarness#event_expiry_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventExpiryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EventExpiryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#strategies BedrockagentcoreHarness#strategies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Strategies
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessTruncationConfigSlidingWindow), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSlidingWindow")]
    public interface IBedrockagentcoreHarnessTruncationConfigSlidingWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#messages_count BedrockagentcoreHarness#messages_count}.</summary>
        [JsiiProperty(name: "messagesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessagesCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessTruncationConfigSlidingWindow), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSlidingWindow")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessTruncationConfigSlidingWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#messages_count BedrockagentcoreHarness#messages_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messagesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessagesCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

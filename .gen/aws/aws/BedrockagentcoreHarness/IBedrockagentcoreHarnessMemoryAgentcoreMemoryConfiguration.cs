using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration")]
    public interface IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#arn BedrockagentcoreHarness#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#actor_id BedrockagentcoreHarness#actor_id}.</summary>
        [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActorId
        {
            get
            {
                return null;
            }
        }

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

        /// <summary>retrieval_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#retrieval_config BedrockagentcoreHarness#retrieval_config}
        /// </remarks>
        [JsiiProperty(name: "retrievalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RetrievalConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#arn BedrockagentcoreHarness#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#actor_id BedrockagentcoreHarness#actor_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#messages_count BedrockagentcoreHarness#messages_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messagesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessagesCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>retrieval_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#retrieval_config BedrockagentcoreHarness#retrieval_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retrievalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RetrievalConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

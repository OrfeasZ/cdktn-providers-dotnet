using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration")]
    public class BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#arn BedrockagentcoreHarness#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#actor_id BedrockagentcoreHarness#actor_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#messages_count BedrockagentcoreHarness#messages_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messagesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessagesCount
        {
            get;
            set;
        }

        private object? _retrievalConfig;

        /// <summary>retrieval_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#retrieval_config BedrockagentcoreHarness#retrieval_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retrievalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RetrievalConfig
        {
            get => _retrievalConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retrievalConfig = value;
            }
        }
    }
}

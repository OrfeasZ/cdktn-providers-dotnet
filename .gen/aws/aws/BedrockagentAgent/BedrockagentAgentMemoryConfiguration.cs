using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentMemoryConfiguration")]
    public class BedrockagentAgentMemoryConfiguration : aws.BedrockagentAgent.IBedrockagentAgentMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_agent#enabled_memory_types BedrockagentAgent#enabled_memory_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledMemoryTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledMemoryTypes
        {
            get;
            set;
        }

        private object? _sessionSummaryConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_agent#session_summary_configuration BedrockagentAgent#session_summary_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionSummaryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentMemoryConfigurationSessionSummaryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SessionSummaryConfiguration
        {
            get => _sessionSummaryConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentAgent.IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentAgent.IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sessionSummaryConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_agent#storage_days BedrockagentAgent#storage_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StorageDays
        {
            get;
            set;
        }
    }
}

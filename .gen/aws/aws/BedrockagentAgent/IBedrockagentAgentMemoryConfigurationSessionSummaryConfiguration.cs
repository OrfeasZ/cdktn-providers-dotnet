using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentMemoryConfigurationSessionSummaryConfiguration")]
    public interface IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_agent#max_recent_sessions BedrockagentAgent#max_recent_sessions}.</summary>
        [JsiiProperty(name: "maxRecentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRecentSessions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentMemoryConfigurationSessionSummaryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgent.IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_agent#max_recent_sessions BedrockagentAgent#max_recent_sessions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRecentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRecentSessions
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

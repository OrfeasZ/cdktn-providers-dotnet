using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreAgentRuntimeLifecycleConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeLifecycleConfiguration")]
    public interface IBedrockagentcoreAgentRuntimeLifecycleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#idle_runtime_session_timeout BedrockagentcoreAgentRuntime#idle_runtime_session_timeout}.</summary>
        [JsiiProperty(name: "idleRuntimeSessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IdleRuntimeSessionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#max_lifetime BedrockagentcoreAgentRuntime#max_lifetime}.</summary>
        [JsiiProperty(name: "maxLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxLifetime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreAgentRuntimeLifecycleConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeLifecycleConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeLifecycleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#idle_runtime_session_timeout BedrockagentcoreAgentRuntime#idle_runtime_session_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idleRuntimeSessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IdleRuntimeSessionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#max_lifetime BedrockagentcoreAgentRuntime#max_lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxLifetime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

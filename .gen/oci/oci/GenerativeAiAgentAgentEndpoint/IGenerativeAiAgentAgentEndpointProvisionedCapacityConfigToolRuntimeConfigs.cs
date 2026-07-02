using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs")]
    public interface IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_config_type GenerativeAiAgentAgentEndpoint#tool_runtime_config_type}.</summary>
        [JsiiProperty(name: "toolRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string ToolRuntimeConfigType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_config_type GenerativeAiAgentAgentEndpoint#tool_runtime_config_type}.</summary>
            [JsiiProperty(name: "toolRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string ToolRuntimeConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
